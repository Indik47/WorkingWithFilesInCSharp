namespace WorkingWithFilesInCSh
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
            this.buttonCurrentDirectory = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxFileStream = new System.Windows.Forms.TextBox();
            this.buttonFileStreamWrite = new System.Windows.Forms.Button();
            this.buttonFileStreamRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCurrentDirectory
            // 
            this.buttonCurrentDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCurrentDirectory.Location = new System.Drawing.Point(136, 122);
            this.buttonCurrentDirectory.Name = "buttonCurrentDirectory";
            this.buttonCurrentDirectory.Size = new System.Drawing.Size(151, 44);
            this.buttonCurrentDirectory.TabIndex = 0;
            this.buttonCurrentDirectory.Text = "DirectoryAndFileInfo";
            this.buttonCurrentDirectory.UseVisualStyleBackColor = true;
            this.buttonCurrentDirectory.Click += new System.EventHandler(this.buttonCurrentDirectory_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(136, 172);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(393, 225);
            this.textBoxOutput.TabIndex = 1;
            // 
            // textBoxFileStream
            // 
            this.textBoxFileStream.Location = new System.Drawing.Point(624, 172);
            this.textBoxFileStream.Multiline = true;
            this.textBoxFileStream.Name = "textBoxFileStream";
            this.textBoxFileStream.Size = new System.Drawing.Size(500, 225);
            this.textBoxFileStream.TabIndex = 2;
            // 
            // buttonFileStreamWrite
            // 
            this.buttonFileStreamWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileStreamWrite.Location = new System.Drawing.Point(624, 122);
            this.buttonFileStreamWrite.Name = "buttonFileStreamWrite";
            this.buttonFileStreamWrite.Size = new System.Drawing.Size(151, 44);
            this.buttonFileStreamWrite.TabIndex = 0;
            this.buttonFileStreamWrite.Text = "FileStreamWrite";
            this.buttonFileStreamWrite.UseVisualStyleBackColor = true;
            this.buttonFileStreamWrite.Click += new System.EventHandler(this.buttonFileStreamWrite_Click);
            // 
            // buttonFileStreamRead
            // 
            this.buttonFileStreamRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileStreamRead.Location = new System.Drawing.Point(799, 122);
            this.buttonFileStreamRead.Name = "buttonFileStreamRead";
            this.buttonFileStreamRead.Size = new System.Drawing.Size(151, 44);
            this.buttonFileStreamRead.TabIndex = 0;
            this.buttonFileStreamRead.Text = "FileStreamRead";
            this.buttonFileStreamRead.UseVisualStyleBackColor = true;
            this.buttonFileStreamRead.Click += new System.EventHandler(this.buttonFileStreamRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 438);
            this.Controls.Add(this.textBoxFileStream);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonFileStreamRead);
            this.Controls.Add(this.buttonFileStreamWrite);
            this.Controls.Add(this.buttonCurrentDirectory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCurrentDirectory;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxFileStream;
        private System.Windows.Forms.Button buttonFileStreamWrite;
        private System.Windows.Forms.Button buttonFileStreamRead;
    }
}

