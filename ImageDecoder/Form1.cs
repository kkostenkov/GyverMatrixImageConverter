using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Linq;
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
            
            var sidePixelCount = 8;
            string error;
            var encodedImage = ColorCutter.EncodeImage(filePath, sidePixelCount, sidePixelCount, out error);
            if (!string.IsNullOrEmpty(error) || encodedImage == null)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                return;
            }
            var sb = new StringBuilder();
            ioHandler.EncodeAndAddAsText(encodedImage, "frame00", sb);
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

            var sidePixelCount = 8;
            string error;
            var sb = new StringBuilder();
            for (int i = 0; i < foundFiles.Count; i++)
            {
                var filePath = foundFiles[i];
                var encodedImage = ColorCutter.EncodeImage(filePath, sidePixelCount, sidePixelCount, out error);
                if (!string.IsNullOrEmpty(error) || encodedImage == null)
                {
                    MessageBox.Show(error, "Error", MessageBoxButtons.OK);
                    continue;
                }
                var fileName = string.Format("frame{0}", i); 
                ioHandler.EncodeAndAddAsText(encodedImage, fileName, sb);
                
            }
            ioHandler.SaveToFile(sb);

            //pictureBox1.Image = TestImagesStorage.DecodeImage(encodedImage);
        }


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
            MessageBox.Show(e.Message, "Exception");
        }
    }
}
