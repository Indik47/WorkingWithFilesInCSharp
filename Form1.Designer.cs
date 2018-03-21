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
            this.textBoxStreams = new System.Windows.Forms.TextBox();
            this.buttonFileStreamWrite = new System.Windows.Forms.Button();
            this.buttonFileStreamRead = new System.Windows.Forms.Button();
            this.buttonTxtFiles = new System.Windows.Forms.Button();
            this.buttonReadFromFile = new System.Windows.Forms.Button();
            this.buttonWriteToFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonStreamWriter = new System.Windows.Forms.Button();
            this.buttonStreamReader = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCurrentDirectory
            // 
            this.buttonCurrentDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCurrentDirectory.Location = new System.Drawing.Point(6, 21);
            this.buttonCurrentDirectory.Name = "buttonCurrentDirectory";
            this.buttonCurrentDirectory.Size = new System.Drawing.Size(158, 44);
            this.buttonCurrentDirectory.TabIndex = 0;
            this.buttonCurrentDirectory.Text = "Directory/FileInfo Test";
            this.buttonCurrentDirectory.UseVisualStyleBackColor = true;
            this.buttonCurrentDirectory.Click += new System.EventHandler(this.buttonCurrentDirectory_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(136, 172);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(442, 225);
            this.textBoxOutput.TabIndex = 1;
            // 
            // textBoxStreams
            // 
            this.textBoxStreams.Location = new System.Drawing.Point(624, 172);
            this.textBoxStreams.Multiline = true;
            this.textBoxStreams.Name = "textBoxStreams";
            this.textBoxStreams.Size = new System.Drawing.Size(500, 225);
            this.textBoxStreams.TabIndex = 2;
            // 
            // buttonFileStreamWrite
            // 
            this.buttonFileStreamWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFileStreamWrite.Location = new System.Drawing.Point(6, 21);
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
            this.buttonFileStreamRead.Location = new System.Drawing.Point(163, 21);
            this.buttonFileStreamRead.Name = "buttonFileStreamRead";
            this.buttonFileStreamRead.Size = new System.Drawing.Size(151, 44);
            this.buttonFileStreamRead.TabIndex = 0;
            this.buttonFileStreamRead.Text = "FileStreamRead";
            this.buttonFileStreamRead.UseVisualStyleBackColor = true;
            this.buttonFileStreamRead.Click += new System.EventHandler(this.buttonFileStreamRead_Click);
            // 
            // buttonTxtFiles
            // 
            this.buttonTxtFiles.Location = new System.Drawing.Point(211, 21);
            this.buttonTxtFiles.Name = "buttonTxtFiles";
            this.buttonTxtFiles.Size = new System.Drawing.Size(136, 44);
            this.buttonTxtFiles.TabIndex = 3;
            this.buttonTxtFiles.Text = "count txt files";
            this.buttonTxtFiles.UseVisualStyleBackColor = true;
            this.buttonTxtFiles.Click += new System.EventHandler(this.buttonTxtFiles_Click);
            // 
            // buttonReadFromFile
            // 
            this.buttonReadFromFile.Location = new System.Drawing.Point(211, 71);
            this.buttonReadFromFile.Name = "buttonReadFromFile";
            this.buttonReadFromFile.Size = new System.Drawing.Size(136, 44);
            this.buttonReadFromFile.TabIndex = 3;
            this.buttonReadFromFile.Text = "Read file";
            this.buttonReadFromFile.UseVisualStyleBackColor = true;
            this.buttonReadFromFile.Click += new System.EventHandler(this.buttonReadFromFile_Click);
            // 
            // buttonWriteToFile
            // 
            this.buttonWriteToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWriteToFile.Location = new System.Drawing.Point(6, 71);
            this.buttonWriteToFile.Name = "buttonWriteToFile";
            this.buttonWriteToFile.Size = new System.Drawing.Size(158, 44);
            this.buttonWriteToFile.TabIndex = 0;
            this.buttonWriteToFile.Text = "Write to file";
            this.buttonWriteToFile.UseVisualStyleBackColor = true;
            this.buttonWriteToFile.Click += new System.EventHandler(this.buttonWriteToFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCurrentDirectory);
            this.groupBox1.Controls.Add(this.buttonReadFromFile);
            this.groupBox1.Controls.Add(this.buttonWriteToFile);
            this.groupBox1.Controls.Add(this.buttonTxtFiles);
            this.groupBox1.Location = new System.Drawing.Point(136, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 154);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directory Info";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonStreamReader);
            this.groupBox2.Controls.Add(this.buttonStreamWriter);
            this.groupBox2.Controls.Add(this.buttonFileStreamWrite);
            this.groupBox2.Controls.Add(this.buttonFileStreamRead);
            this.groupBox2.Location = new System.Drawing.Point(624, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(442, 154);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Streams";
            // 
            // buttonStreamWriter
            // 
            this.buttonStreamWriter.Location = new System.Drawing.Point(7, 72);
            this.buttonStreamWriter.Name = "buttonStreamWriter";
            this.buttonStreamWriter.Size = new System.Drawing.Size(150, 43);
            this.buttonStreamWriter.TabIndex = 1;
            this.buttonStreamWriter.Text = "StreamWrite";
            this.buttonStreamWriter.UseVisualStyleBackColor = true;
            this.buttonStreamWriter.Click += new System.EventHandler(this.buttonStreamWriter_Click);
            // 
            // buttonStreamReader
            // 
            this.buttonStreamReader.Location = new System.Drawing.Point(164, 71);
            this.buttonStreamReader.Name = "buttonStreamReader";
            this.buttonStreamReader.Size = new System.Drawing.Size(150, 43);
            this.buttonStreamReader.TabIndex = 1;
            this.buttonStreamReader.Text = "StreamRead";
            this.buttonStreamReader.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 438);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxStreams);
            this.Controls.Add(this.textBoxOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCurrentDirectory;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxStreams;
        private System.Windows.Forms.Button buttonFileStreamWrite;
        private System.Windows.Forms.Button buttonFileStreamRead;
        private System.Windows.Forms.Button buttonTxtFiles;
        private System.Windows.Forms.Button buttonReadFromFile;
        private System.Windows.Forms.Button buttonWriteToFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStreamReader;
        private System.Windows.Forms.Button buttonStreamWriter;
    }
}

