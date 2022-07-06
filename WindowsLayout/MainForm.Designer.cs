namespace WindowsLayout
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chooseFolderWithPictures = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lableCurrentPicture = new System.Windows.Forms.Label();
            this.skipPicture = new System.Windows.Forms.Button();
            this.WithWindow = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.NameAndCoordinates = new System.Windows.Forms.ListBox();
            this.clearListBox = new System.Windows.Forms.Button();
            this.WithoutWindow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseFolderWithPictures
            // 
            this.chooseFolderWithPictures.Location = new System.Drawing.Point(12, 15);
            this.chooseFolderWithPictures.Name = "chooseFolderWithPictures";
            this.chooseFolderWithPictures.Size = new System.Drawing.Size(114, 41);
            this.chooseFolderWithPictures.TabIndex = 0;
            this.chooseFolderWithPictures.Text = "Выбрать папку с фотографиями";
            this.chooseFolderWithPictures.UseVisualStyleBackColor = true;
            this.chooseFolderWithPictures.Click += new System.EventHandler(this.chooseFolderWithPictures_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // lableCurrentPicture
            // 
            this.lableCurrentPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lableCurrentPicture.AutoSize = true;
            this.lableCurrentPicture.Location = new System.Drawing.Point(500, 28);
            this.lableCurrentPicture.Name = "lableCurrentPicture";
            this.lableCurrentPicture.Size = new System.Drawing.Size(13, 15);
            this.lableCurrentPicture.TabIndex = 1;
            this.lableCurrentPicture.Text = "0";
            // 
            // skipPicture
            // 
            this.skipPicture.Location = new System.Drawing.Point(12, 627);
            this.skipPicture.Name = "skipPicture";
            this.skipPicture.Size = new System.Drawing.Size(114, 41);
            this.skipPicture.TabIndex = 2;
            this.skipPicture.Text = "Пропустить";
            this.skipPicture.UseVisualStyleBackColor = true;
            this.skipPicture.Click += new System.EventHandler(this.skipPicture_Click);
            // 
            // WithWindow
            // 
            this.WithWindow.Location = new System.Drawing.Point(275, 627);
            this.WithWindow.Name = "WithWindow";
            this.WithWindow.Size = new System.Drawing.Size(114, 41);
            this.WithWindow.TabIndex = 3;
            this.WithWindow.Text = "Есть";
            this.WithWindow.UseVisualStyleBackColor = true;
            this.WithWindow.Click += new System.EventHandler(this.WithWindow_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(12, 82);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(960, 539);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // NameAndCoordinates
            // 
            this.NameAndCoordinates.FormattingEnabled = true;
            this.NameAndCoordinates.ItemHeight = 15;
            this.NameAndCoordinates.Location = new System.Drawing.Point(988, 82);
            this.NameAndCoordinates.Name = "NameAndCoordinates";
            this.NameAndCoordinates.Size = new System.Drawing.Size(192, 184);
            this.NameAndCoordinates.TabIndex = 5;
            // 
            // clearListBox
            // 
            this.clearListBox.Location = new System.Drawing.Point(1051, 272);
            this.clearListBox.Name = "clearListBox";
            this.clearListBox.Size = new System.Drawing.Size(85, 23);
            this.clearListBox.TabIndex = 6;
            this.clearListBox.Text = "Очистить";
            this.clearListBox.UseVisualStyleBackColor = true;
            this.clearListBox.Click += new System.EventHandler(this.clearListBox_Click);
            // 
            // WithoutWindow
            // 
            this.WithoutWindow.Location = new System.Drawing.Point(141, 627);
            this.WithoutWindow.Name = "WithoutWindow";
            this.WithoutWindow.Size = new System.Drawing.Size(114, 41);
            this.WithoutWindow.TabIndex = 7;
            this.WithoutWindow.Text = "Нет";
            this.WithoutWindow.UseVisualStyleBackColor = true;
            this.WithoutWindow.Click += new System.EventHandler(this.WithoutWindow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 676);
            this.Controls.Add(this.WithoutWindow);
            this.Controls.Add(this.clearListBox);
            this.Controls.Add(this.NameAndCoordinates);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.WithWindow);
            this.Controls.Add(this.skipPicture);
            this.Controls.Add(this.lableCurrentPicture);
            this.Controls.Add(this.chooseFolderWithPictures);
            this.MinimumSize = new System.Drawing.Size(1225, 715);
            this.Name = "MainForm";
            this.Text = "Pumba";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFolderWithPictures;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lableCurrentPicture;
        private System.Windows.Forms.Button skipPicture;
        private System.Windows.Forms.Button WithWindow;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ListBox NameAndCoordinates;
        private System.Windows.Forms.Button clearListBox;
        private System.Windows.Forms.Button WithoutWindow;
    }
}
