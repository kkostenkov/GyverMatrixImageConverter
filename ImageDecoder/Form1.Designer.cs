namespace ImageDecoder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.convertSingleButton = new System.Windows.Forms.Button();
            this.convertFolderButton = new System.Windows.Forms.Button();
            this.matrix16by16 = new System.Windows.Forms.RadioButton();
            this.matrix8by8 = new System.Windows.Forms.RadioButton();
            this.matrixCustomSize = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arrayName = new System.Windows.Forms.TextBox();
            this.matrixSizeBack = new System.Windows.Forms.GroupBox();
            this.customMatrixMultLabel = new System.Windows.Forms.Label();
            this.customMatrixX = new System.Windows.Forms.TextBox();
            this.customMatrixY = new System.Windows.Forms.TextBox();
            this.manualConverterBox = new System.Windows.Forms.GroupBox();
            this.manualConvertButton = new System.Windows.Forms.Button();
            this.manualPaletteTo16 = new System.Windows.Forms.GroupBox();
            this.manualPaletteTo16input = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.manualPaletteTo16output = new System.Windows.Forms.TextBox();
            this.manual16To24 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.manual16To24output = new System.Windows.Forms.TextBox();
            this.manual16To24input = new System.Windows.Forms.TextBox();
            this.manual24to16 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.manual24to16output = new System.Windows.Forms.TextBox();
            this.manual24to16input = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gyverLink = new System.Windows.Forms.LinkLabel();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.matrixSizeBack.SuspendLayout();
            this.manualConverterBox.SuspendLayout();
            this.manualPaletteTo16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manualPaletteTo16input)).BeginInit();
            this.manual16To24.SuspendLayout();
            this.manual24to16.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(154, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // convertSingleButton
            // 
            this.convertSingleButton.Location = new System.Drawing.Point(32, 213);
            this.convertSingleButton.Name = "convertSingleButton";
            this.convertSingleButton.Size = new System.Drawing.Size(99, 34);
            this.convertSingleButton.TabIndex = 8;
            this.convertSingleButton.Text = "Конвертировать файл";
            this.convertSingleButton.UseVisualStyleBackColor = true;
            this.convertSingleButton.Click += new System.EventHandler(this.convertSingleButton_Click);
            // 
            // convertFolderButton
            // 
            this.convertFolderButton.Location = new System.Drawing.Point(154, 213);
            this.convertFolderButton.Name = "convertFolderButton";
            this.convertFolderButton.Size = new System.Drawing.Size(140, 34);
            this.convertFolderButton.TabIndex = 9;
            this.convertFolderButton.Text = "Конвертировать все файлы в папке";
            this.convertFolderButton.UseVisualStyleBackColor = true;
            this.convertFolderButton.Click += new System.EventHandler(this.convertFolderButton_Click);
            // 
            // matrix16by16
            // 
            this.matrix16by16.AutoSize = true;
            this.matrix16by16.Checked = true;
            this.matrix16by16.Location = new System.Drawing.Point(6, 19);
            this.matrix16by16.Name = "matrix16by16";
            this.matrix16by16.Size = new System.Drawing.Size(53, 17);
            this.matrix16by16.TabIndex = 10;
            this.matrix16by16.TabStop = true;
            this.matrix16by16.Text = "16*16";
            this.matrix16by16.UseVisualStyleBackColor = true;
            // 
            // matrix8by8
            // 
            this.matrix8by8.AutoSize = true;
            this.matrix8by8.Location = new System.Drawing.Point(6, 42);
            this.matrix8by8.Name = "matrix8by8";
            this.matrix8by8.Size = new System.Drawing.Size(41, 17);
            this.matrix8by8.TabIndex = 11;
            this.matrix8by8.Text = "8*8";
            this.matrix8by8.UseVisualStyleBackColor = true;
            // 
            // matrixCustomSize
            // 
            this.matrixCustomSize.AutoSize = true;
            this.matrixCustomSize.Location = new System.Drawing.Point(6, 65);
            this.matrixCustomSize.Name = "matrixCustomSize";
            this.matrixCustomSize.Size = new System.Drawing.Size(91, 17);
            this.matrixCustomSize.TabIndex = 12;
            this.matrixCustomSize.Text = "Свой размер";
            this.matrixCustomSize.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.arrayName);
            this.groupBox1.Location = new System.Drawing.Point(24, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 59);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Название массива";
            // 
            // arrayName
            // 
            this.arrayName.Location = new System.Drawing.Point(11, 24);
            this.arrayName.Name = "arrayName";
            this.arrayName.Size = new System.Drawing.Size(83, 20);
            this.arrayName.TabIndex = 21;
            this.arrayName.Text = "frame";
            // 
            // matrixSizeBack
            // 
            this.matrixSizeBack.Controls.Add(this.customMatrixMultLabel);
            this.matrixSizeBack.Controls.Add(this.customMatrixX);
            this.matrixSizeBack.Controls.Add(this.customMatrixY);
            this.matrixSizeBack.Controls.Add(this.matrix16by16);
            this.matrixSizeBack.Controls.Add(this.matrix8by8);
            this.matrixSizeBack.Controls.Add(this.matrixCustomSize);
            this.matrixSizeBack.Location = new System.Drawing.Point(24, 12);
            this.matrixSizeBack.Name = "matrixSizeBack";
            this.matrixSizeBack.Size = new System.Drawing.Size(113, 130);
            this.matrixSizeBack.TabIndex = 0;
            this.matrixSizeBack.TabStop = false;
            this.matrixSizeBack.Text = "Размер матрицы";
            // 
            // customMatrixMultLabel
            // 
            this.customMatrixMultLabel.AutoSize = true;
            this.customMatrixMultLabel.Location = new System.Drawing.Point(53, 91);
            this.customMatrixMultLabel.Name = "customMatrixMultLabel";
            this.customMatrixMultLabel.Size = new System.Drawing.Size(11, 13);
            this.customMatrixMultLabel.TabIndex = 16;
            this.customMatrixMultLabel.Text = "*";
            // 
            // customMatrixX
            // 
            this.customMatrixX.Location = new System.Drawing.Point(6, 88);
            this.customMatrixX.MaxLength = 256;
            this.customMatrixX.Name = "customMatrixX";
            this.customMatrixX.Size = new System.Drawing.Size(41, 20);
            this.customMatrixX.TabIndex = 14;
            // 
            // customMatrixY
            // 
            this.customMatrixY.Location = new System.Drawing.Point(67, 88);
            this.customMatrixY.MaxLength = 256;
            this.customMatrixY.Name = "customMatrixY";
            this.customMatrixY.Size = new System.Drawing.Size(40, 20);
            this.customMatrixY.TabIndex = 15;
            // 
            // manualConverterBox
            // 
            this.manualConverterBox.Controls.Add(this.manualConvertButton);
            this.manualConverterBox.Controls.Add(this.manualPaletteTo16);
            this.manualConverterBox.Controls.Add(this.manual16To24);
            this.manualConverterBox.Controls.Add(this.manual24to16);
            this.manualConverterBox.Location = new System.Drawing.Point(318, 12);
            this.manualConverterBox.Name = "manualConverterBox";
            this.manualConverterBox.Size = new System.Drawing.Size(222, 228);
            this.manualConverterBox.TabIndex = 18;
            this.manualConverterBox.TabStop = false;
            this.manualConverterBox.Text = "Конвертировать цвет вручную";
            // 
            // manualConvertButton
            // 
            this.manualConvertButton.Location = new System.Drawing.Point(62, 190);
            this.manualConvertButton.Name = "manualConvertButton";
            this.manualConvertButton.Size = new System.Drawing.Size(100, 23);
            this.manualConvertButton.TabIndex = 4;
            this.manualConvertButton.Text = "Конвертировать";
            this.manualConvertButton.UseVisualStyleBackColor = true;
            this.manualConvertButton.Click += new System.EventHandler(this.manualConvertButton_Click);
            // 
            // manualPaletteTo16
            // 
            this.manualPaletteTo16.Controls.Add(this.manualPaletteTo16input);
            this.manualPaletteTo16.Controls.Add(this.label4);
            this.manualPaletteTo16.Controls.Add(this.manualPaletteTo16output);
            this.manualPaletteTo16.Location = new System.Drawing.Point(6, 82);
            this.manualPaletteTo16.Name = "manualPaletteTo16";
            this.manualPaletteTo16.Size = new System.Drawing.Size(200, 48);
            this.manualPaletteTo16.TabIndex = 3;
            this.manualPaletteTo16.TabStop = false;
            this.manualPaletteTo16.Text = "palette -> 16 bit";
            // 
            // manualPaletteTo16input
            // 
            this.manualPaletteTo16input.BackColor = System.Drawing.Color.Red;
            this.manualPaletteTo16input.Location = new System.Drawing.Point(14, 19);
            this.manualPaletteTo16input.Name = "manualPaletteTo16input";
            this.manualPaletteTo16input.Size = new System.Drawing.Size(71, 20);
            this.manualPaletteTo16input.TabIndex = 19;
            this.manualPaletteTo16input.TabStop = false;
            this.manualPaletteTo16input.Click += new System.EventHandler(this.manualPaletteTo16input_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "->";
            // 
            // manualPaletteTo16output
            // 
            this.manualPaletteTo16output.Location = new System.Drawing.Point(113, 19);
            this.manualPaletteTo16output.Name = "manualPaletteTo16output";
            this.manualPaletteTo16output.ReadOnly = true;
            this.manualPaletteTo16output.Size = new System.Drawing.Size(63, 20);
            this.manualPaletteTo16output.TabIndex = 1;
            // 
            // manual16To24
            // 
            this.manual16To24.Controls.Add(this.label3);
            this.manual16To24.Controls.Add(this.manual16To24output);
            this.manual16To24.Controls.Add(this.manual16To24input);
            this.manual16To24.Location = new System.Drawing.Point(6, 136);
            this.manual16To24.Name = "manual16To24";
            this.manual16To24.Size = new System.Drawing.Size(200, 48);
            this.manual16To24.TabIndex = 3;
            this.manual16To24.TabStop = false;
            this.manual16To24.Text = "16 bit -> 24 bit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "->";
            // 
            // manual16To24output
            // 
            this.manual16To24output.Location = new System.Drawing.Point(113, 19);
            this.manual16To24output.Name = "manual16To24output";
            this.manual16To24output.ReadOnly = true;
            this.manual16To24output.Size = new System.Drawing.Size(63, 20);
            this.manual16To24output.TabIndex = 1;
            // 
            // manual16To24input
            // 
            this.manual16To24input.Location = new System.Drawing.Point(14, 19);
            this.manual16To24input.Name = "manual16To24input";
            this.manual16To24input.Size = new System.Drawing.Size(71, 20);
            this.manual16To24input.TabIndex = 0;
            this.manual16To24input.Text = "0x13A8";
            // 
            // manual24to16
            // 
            this.manual24to16.Controls.Add(this.label2);
            this.manual24to16.Controls.Add(this.manual24to16output);
            this.manual24to16.Controls.Add(this.manual24to16input);
            this.manual24to16.Location = new System.Drawing.Point(6, 19);
            this.manual24to16.Name = "manual24to16";
            this.manual24to16.Size = new System.Drawing.Size(200, 48);
            this.manual24to16.TabIndex = 0;
            this.manual24to16.TabStop = false;
            this.manual24to16.Text = "24 bit -> 16 bit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "->";
            // 
            // manual24to16output
            // 
            this.manual24to16output.Location = new System.Drawing.Point(113, 19);
            this.manual24to16output.Name = "manual24to16output";
            this.manual24to16output.ReadOnly = true;
            this.manual24to16output.Size = new System.Drawing.Size(63, 20);
            this.manual24to16output.TabIndex = 1;
            // 
            // manual24to16input
            // 
            this.manual24to16input.Location = new System.Drawing.Point(14, 19);
            this.manual24to16input.Name = "manual24to16input";
            this.manual24to16input.Size = new System.Drawing.Size(71, 20);
            this.manual24to16input.TabIndex = 0;
            this.manual24to16input.Text = "0x180d00";
            // 
            // gyverLink
            // 
            this.gyverLink.AutoSize = true;
            this.gyverLink.Location = new System.Drawing.Point(335, 243);
            this.gyverLink.Name = "gyverLink";
            this.gyverLink.Size = new System.Drawing.Size(64, 13);
            this.gyverLink.TabIndex = 3;
            this.gyverLink.TabStop = true;
            this.gyverLink.Text = "alexgyver.ru";
            this.gyverLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gyverLink_LinkClicked);
            // 
            // githubLink
            // 
            this.githubLink.AutoSize = true;
            this.githubLink.Location = new System.Drawing.Point(445, 243);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(79, 13);
            this.githubLink.TabIndex = 19;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "Исходный код";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(567, 279);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.gyverLink);
            this.Controls.Add(this.manualConverterBox);
            this.Controls.Add(this.matrixSizeBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.convertFolderButton);
            this.Controls.Add(this.convertSingleButton);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.matrixSizeBack.ResumeLayout(false);
            this.matrixSizeBack.PerformLayout();
            this.manualConverterBox.ResumeLayout(false);
            this.manualPaletteTo16.ResumeLayout(false);
            this.manualPaletteTo16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manualPaletteTo16input)).EndInit();
            this.manual16To24.ResumeLayout(false);
            this.manual16To24.PerformLayout();
            this.manual24to16.ResumeLayout(false);
            this.manual24to16.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button convertSingleButton;
        private System.Windows.Forms.Button convertFolderButton;
        private System.Windows.Forms.RadioButton matrix16by16;
        private System.Windows.Forms.RadioButton matrix8by8;
        private System.Windows.Forms.RadioButton matrixCustomSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox matrixSizeBack;
        private System.Windows.Forms.Label customMatrixMultLabel;
        private System.Windows.Forms.TextBox customMatrixX;
        private System.Windows.Forms.TextBox customMatrixY;
        private System.Windows.Forms.TextBox arrayName;
        private System.Windows.Forms.GroupBox manualConverterBox;
        private System.Windows.Forms.GroupBox manualPaletteTo16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox manualPaletteTo16output;
        private System.Windows.Forms.GroupBox manual16To24;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox manual16To24output;
        private System.Windows.Forms.TextBox manual16To24input;
        private System.Windows.Forms.GroupBox manual24to16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox manual24to16output;
        private System.Windows.Forms.TextBox manual24to16input;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox manualPaletteTo16input;
        private System.Windows.Forms.Button manualConvertButton;
        private System.Windows.Forms.LinkLabel gyverLink;
        private System.Windows.Forms.LinkLabel githubLink;
    }
}

