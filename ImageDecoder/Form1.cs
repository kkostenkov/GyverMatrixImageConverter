using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace ImageDecoder
{
    public partial class Form1 : Form
    {
        IOHandler ioHandler;

        public Form1()
        {
            InitializeComponent();
            ioHandler = new IOHandler();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = TestImagesStorage.GetMarioImage();
        }

        private void convertSingleButton_Click(object sender, EventArgs e)
        {
            var filePath = ioHandler.SelectFile();

            var matrixSize = GetMatrixSize();
            string error;
            var encodedImage = ColorCutter.EncodeImage(filePath, matrixSize[0], matrixSize[1], out error);
            if (!string.IsNullOrEmpty(error) || encodedImage == null)
            {
                ShowErrorNotification(error);
                return;
            }
            var sb = new StringBuilder();
            var arrayElementName = string.Format("{0}00", GetArrayPrefixName());
            ioHandler.EncodeAndAddAsText(encodedImage, arrayElementName, sb);
            var arrayElementNames = new List<string>() { arrayElementName };
            ioHandler.AddArrayDeclaration(sb, arrayElementNames);
            ioHandler.SaveToFile(sb);
            pictureBox1.Image = TestImagesStorage.DecodeImage(encodedImage);
        }

        private void convertFolderButton_Click(object sender, EventArgs e)
        {
            var folderPath = ioHandler.SelectFolder();
            var supportedExtentions = new[] { "*.jpg", "*.jpeg", "*.png", "*.bmp" };
            List<string> foundFiles = new List<string>();
            for (int i = 0; i < supportedExtentions.Length; i++)
            {
                var ext = supportedExtentions[i];
                var extFiles = Directory.GetFiles(folderPath, ext, SearchOption.TopDirectoryOnly);
                if (extFiles != null && extFiles.Length > 0)
                {
                    foundFiles.AddRange(extFiles);
                }
            }
            MessageBox.Show("Files found: " + foundFiles.Count.ToString(), "Message");

            var matrixSize = GetMatrixSize();
            string error;
            var sb = new StringBuilder();
            var arrayElementPrefix = GetArrayPrefixName();
            var arrayElementNames = new List<string>();
            for (int i = 0; i < foundFiles.Count; i++)
            {
                var filePath = foundFiles[i];
                var encodedImage = ColorCutter.EncodeImage(filePath, matrixSize[0], matrixSize[1], out error);
                if (!string.IsNullOrEmpty(error) || encodedImage == null)
                {
                    ShowErrorNotification(error);
                    continue;
                }
                var fileName = string.Format("{0}{1}", arrayElementPrefix, i);
                arrayElementNames.Add(fileName);
                ioHandler.EncodeAndAddAsText(encodedImage, fileName, sb);
                
            }
            ioHandler.AddArrayDeclaration(sb, arrayElementNames);
            ioHandler.SaveToFile(sb);

            //pictureBox1.Image = TestImagesStorage.DecodeImage(encodedImage);
        }

        // Shows palette to choose color
        private void manualPaletteTo16input_Click(object sender, EventArgs e)
        {
            // Show the color dialog.
            DialogResult result = colorDialog1.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                manualPaletteTo16input.BackColor = colorDialog1.Color;
            }
        }

        // Converts all manual inputs
        private void manualConvertButton_Click(object sender, EventArgs e)
        {
            // 24->16
            var expandedColorText = manual24to16input.Text;
            if (!expandedColorText.StartsWith("0x"))
                expandedColorText = "0x" + expandedColorText;
            int expandedColorInt = 0;
            try
            {
                expandedColorInt = Convert.ToInt32(expandedColorText, 16);
                var shrinkedColor = ColorCutter.ShrinkColor(expandedColorInt);
                
                manual24to16output.Text = string.Format("0x{0}", shrinkedColor.ToString("X4"));
            }
            catch (Exception exc)
            {
                ShowExceptionNotification(exc);
            }

            // Palette -> 16
            try
            {
                var manualPaletteColor = manualPaletteTo16input.BackColor.ToArgb();   
                var shrinkedColor = ColorCutter.ShrinkColor(manualPaletteColor);
                manualPaletteTo16output.Text = string.Format("0x{0}", shrinkedColor.ToString("X4"));
            }
            catch (Exception exc)
            {
                ShowExceptionNotification(exc);
            }

            // 16 -> 24
            var color16text = manual16To24input.Text;
            var colorInt = 0;
            try
            {
                colorInt = Convert.ToInt32(color16text, 16);
                var expandedColor = ColorCutter.ExpandColor(colorInt);
                manual16To24output.Text = "0x" + expandedColor.ToString("x");
            }
            catch (Exception exc)
            {
                ShowExceptionNotification(exc);
            }      
        }

        private void ShowExceptionNotification(Exception e)
        {
            MessageBox.Show(e.Message, "Exception", MessageBoxButtons.OK);
        }

        private void ShowErrorNotification(string errorMsg)
        {
            MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK);
        }

        private const string DEFAULT_ARRAY_PREFIX = "frame";
        // Some basic validation of user input
        private string GetArrayPrefixName()
        {
            var userArrayNameInput = arrayName.Text;
            if (string.IsNullOrEmpty(userArrayNameInput))
            {
                return DEFAULT_ARRAY_PREFIX;
            }
            else if (!char.IsLetter(userArrayNameInput[0]))
            {
                ShowErrorNotification("Array name should start from letter");
                userArrayNameInput = "z" + userArrayNameInput;
            }
            return userArrayNameInput;
        }

        private int[] GetMatrixSize()
        {
            int x = 0, y = 0;
            if (matrix16by16.Checked)
            {
                x = 16; y = 16;
            }
            else if (matrix8by8.Checked)
            {
                x = 8; y = 8;
            }
            else
            {
                bool inputParsed = true;
                if (!Int32.TryParse(customMatrixX.Text, out x))
                {
                    inputParsed = false;
                    x = 16;
                }
                if (!Int32.TryParse(customMatrixY.Text, out y))
                {
                    inputParsed = false;
                    y = 16;
                }
                if (!inputParsed)
                {
                    ShowErrorNotification("Unknown matrix size");
                }
                x = Math.Max(1, x);
                y = Math.Max(1, y);
            }
            var result = new int[2] { x, y };
            return result;
        }

        private void gyverLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http:/alexgyver.ru/");
            Process.Start(sInfo);
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://github.com/kkostenkov/GyverMatrixImageConverter/");
            Process.Start(sInfo);
        }
    }
}
