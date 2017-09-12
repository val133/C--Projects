namespace WindowsFormsApplication17
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
            this.button1CreateFolder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowFolderButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GetFOlderContent = new System.Windows.Forms.Label();
            this.CreateFile = new System.Windows.Forms.Button();
            this.DeleteFIleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1CreateFolder
            // 
            this.button1CreateFolder.Location = new System.Drawing.Point(165, 116);
            this.button1CreateFolder.Name = "button1CreateFolder";
            this.button1CreateFolder.Size = new System.Drawing.Size(75, 23);
            this.button1CreateFolder.TabIndex = 0;
            this.button1CreateFolder.Text = "CreateFolder";
            this.button1CreateFolder.UseVisualStyleBackColor = true;
            this.button1CreateFolder.Click += new System.EventHandler(this.button1CreateFolder_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "FileName";
            // 
            // ShowFolderButton
            // 
            this.ShowFolderButton.Location = new System.Drawing.Point(12, 116);
            this.ShowFolderButton.Name = "ShowFolderButton";
            this.ShowFolderButton.Size = new System.Drawing.Size(110, 23);
            this.ShowFolderButton.TabIndex = 3;
            this.ShowFolderButton.Text = "ShowFolderContent";
            this.ShowFolderButton.UseVisualStyleBackColor = true;
            this.ShowFolderButton.Click += new System.EventHandler(this.ShowFolderButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // GetFOlderContent
            // 
            this.GetFOlderContent.AutoSize = true;
            this.GetFOlderContent.Location = new System.Drawing.Point(18, 83);
            this.GetFOlderContent.Name = "GetFOlderContent";
            this.GetFOlderContent.Size = new System.Drawing.Size(69, 13);
            this.GetFOlderContent.TabIndex = 5;
            this.GetFOlderContent.Text = "FolderAddres";
            // 
            // CreateFile
            // 
            this.CreateFile.Location = new System.Drawing.Point(165, 163);
            this.CreateFile.Name = "CreateFile";
            this.CreateFile.Size = new System.Drawing.Size(75, 23);
            this.CreateFile.TabIndex = 6;
            this.CreateFile.Text = "CreateFILE";
            this.CreateFile.UseVisualStyleBackColor = true;
            this.CreateFile.Click += new System.EventHandler(this.CreateFile_Click);
            // 
            // DeleteFIleButton
            // 
            this.DeleteFIleButton.Location = new System.Drawing.Point(12, 163);
            this.DeleteFIleButton.Name = "DeleteFIleButton";
            this.DeleteFIleButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteFIleButton.TabIndex = 7;
            this.DeleteFIleButton.Text = "DeleteFIle";
            this.DeleteFIleButton.UseVisualStyleBackColor = true;
            this.DeleteFIleButton.Click += new System.EventHandler(this.DeleteFIleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DeleteFIleButton);
            this.Controls.Add(this.CreateFile);
            this.Controls.Add(this.GetFOlderContent);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ShowFolderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1CreateFolder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1CreateFolder;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ShowFolderButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label GetFOlderContent;
        private System.Windows.Forms.Button CreateFile;
        private System.Windows.Forms.Button DeleteFIleButton;
    }
}

