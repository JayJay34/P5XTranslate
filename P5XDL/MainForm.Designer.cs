namespace P5XDLForm
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
            downloadPB = new ProgressBar();
            okBtn = new Button();
            TitleTxt = new Label();
            downloadTxt = new Label();
            SuspendLayout();
            // 
            // downloadPB
            // 
            downloadPB.Location = new Point(12, 29);
            downloadPB.Name = "downloadPB";
            downloadPB.Size = new Size(416, 22);
            downloadPB.TabIndex = 2;
            downloadPB.Click += progressBar1_Click;
            // 
            // okBtn
            // 
            okBtn.Enabled = false;
            okBtn.Location = new Point(180, 80);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(75, 23);
            okBtn.TabIndex = 0;
            okBtn.Text = "OK";
            okBtn.UseVisualStyleBackColor = true;
            okBtn.Click += button1_Click;
            // 
            // TitleTxt
            // 
            TitleTxt.Location = new Point(12, 9);
            TitleTxt.Name = "TitleTxt";
            TitleTxt.Size = new Size(416, 17);
            TitleTxt.TabIndex = 1;
            TitleTxt.Text = "Downloading Translation Files....";
            TitleTxt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // downloadTxt
            // 
            downloadTxt.Location = new Point(12, 54);
            downloadTxt.Name = "downloadTxt";
            downloadTxt.Size = new Size(416, 19);
            downloadTxt.TabIndex = 3;
            downloadTxt.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 110);
            Controls.Add(downloadTxt);
            Controls.Add(downloadPB);
            Controls.Add(TitleTxt);
            Controls.Add(okBtn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            Text = "P5X Translator DL Updater";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button okBtn;
        private Label TitleTxt;
        public ProgressBar downloadPB;
        private Label downloadTxt;
    }
}