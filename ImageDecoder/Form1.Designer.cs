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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gyverLink = new System.Windows.Forms.LinkLabel();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.matrixSizeBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(154, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // convertSingleButton
            // 
            this.convertSingleButton.Location = new System.Drawing.Point(33, 213);
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
            this.convertFolderButton.Size = new System.Drawing.Size(148, 34);
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
            this.groupBox1.Size = new System.Drawing.Size(124, 59);
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
            this.matrixSizeBack.AutoSize = true;
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
            // gyverLink
            // 
            this.gyverLink.AutoSize = true;
            this.gyverLink.Location = new System.Drawing.Point(42, 266);
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
            this.githubLink.Location = new System.Drawing.Point(194, 266);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(77, 13);
            this.githubLink.TabIndex = 14;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "исходный код";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githubLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 288);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.gyverLink);
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
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.LinkLabel gyverLink;
        private System.Windows.Forms.LinkLabel githubLink;
    }
}

