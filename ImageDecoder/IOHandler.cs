using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ImageDecoder
{
    class IOHandler
    {
        public string SelectFile()
        {
            string filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                }
            }
            return filePath;
        }

        public string SelectFolder()
        {
            string folderPath = string.Empty;
            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                openFolderDialog.ShowNewFolderButton = false;
                // Default to the My Documents folder.
                openFolderDialog.RootFolder = Environment.SpecialFolder.DesktopDirectory;
                DialogResult result = openFolderDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    folderPath = openFolderDialog.SelectedPath;
                }
            }
            return folderPath;
        }


        public void EncodeAndAddAsText(int[][] image, string imageName, StringBuilder sb)
        {
            if (image == null || image.Length < 1 || image[0] == null) return;

            var header = "const uint16_t {0}[] PROGMEM = ";
            sb.Append(string.Format(header, imageName));
            sb.AppendLine("{");
            var width = image[0].Length;
            var height = image.Length;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    var stringedVal = string.Format("0x{0}", image[y][x].ToString("X4"));
                    // 0x0000
                    sb.Append(stringedVal);
                    var isLastElement = (x == width - 1) && (y == height - 1);
                    if (!isLastElement)
                    {
                        sb.Append(", ");
                    }
                }
                sb.AppendLine();
            }
            sb.AppendLine("};");
            sb.AppendLine();
        }

        internal void AddArrayDeclaration(StringBuilder sb, string arrayName, List<string> names)
        {
            //const uint16_t* const framesArray1[4] PROGMEM = { frame00, frame01, frame02, frame03 };
            var arrayOpening = string.Format("const uint16_t* const {0}_array[{1}] = ", arrayName, names.Count);
            sb.Append(arrayOpening);
            sb.AppendLine("  {");
            for (int i = 0; i < names.Count; i++)
            {
                sb.Append(names[i]);
                if (i < names.Count - 1) // not last line
                {
                    sb.Append(", ");
                }
                if (i % 10 == 9)
                    sb.AppendLine();

            }
            sb.AppendLine("};");
        }

        public void SaveToFile(StringBuilder sb)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "h Files(*.h)|*.h|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = saveFileDialog.FileName;
                // сохраняем текст в файл
                System.IO.File.WriteAllText(filename, sb.ToString());
            }

            MessageBox.Show("Файл сохранен");
        }
    }
}
