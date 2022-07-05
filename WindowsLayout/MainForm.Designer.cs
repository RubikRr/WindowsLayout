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
            this.lableCurrentPicture.Location = new System.Drawing.Point(385, 28);
            this.lableCurrentPicture.Name = "lableCurrentPicture";
            this.lableCurrentPicture.Size = new System.Drawing.Size(13, 15);
            this.lableCurrentPicture.TabIndex = 1;
            this.lableCurrentPicture.Text = "0";
            // 
            // skipPicture
            // 
            this.skipPicture.Location = new System.Drawing.Point(12, 370);
            this.skipPicture.Name = "skipPicture";
            this.skipPicture.Size = new System.Drawing.Size(114, 41);
            this.skipPicture.TabIndex = 2;
            this.skipPicture.Text = "Пропустить";
            this.skipPicture.UseVisualStyleBackColor = true;
            this.skipPicture.Click += new System.EventHandler(this.skipPicture_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.skipPicture);
            this.Controls.Add(this.lableCurrentPicture);
            this.Controls.Add(this.chooseFolderWithPictures);
            this.Name = "MainForm";
            this.Text = "Pumba";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseFolderWithPictures;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lableCurrentPicture;
        private System.Windows.Forms.Button skipPicture;
    }
}
