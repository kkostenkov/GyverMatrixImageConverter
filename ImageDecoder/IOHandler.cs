using System;
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

            var header = "const uint16_t {0}[][{1}] PROGMEM = ";
            sb.Append(string.Format(header, imageName, image[0].Length));
            sb.AppendLine("{");
            var width = image.Length;
            var height = image[0].Length;
            for (int y = 0; y < height; y++)
            {
                sb.Append("  {");
                for (int x = 0; x < width; x++)
                {
                    var stringedVal = string.Format("0x{0}", image[y][x].ToString("X4"));
                    // 0x0000
                    sb.Append(stringedVal);
                    if (x < width - 1) // not last line
                    {
                        sb.Append(", ");
                    }
                }
                sb.AppendLine(" },");
            }
            sb.AppendLine("};");
            sb.AppendLine();

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
