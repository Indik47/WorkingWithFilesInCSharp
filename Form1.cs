using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace WorkingWithFilesInCSh
{
    public partial class Form1 : Form
    {
        string filePath = "C:\\Users\\d.oligov\\Csharp\\dftg.txt";
        FileStream fs;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCurrentDirectory_Click(object sender, EventArgs e)
        {
            DirectoryInfo currDir = new DirectoryInfo(@"C:\Users\d.oligov");
            textBoxOutput.Text = "FullName = " + currDir.FullName;
            textBoxOutput.AppendText(Environment.NewLine + "Name = " + currDir.Name);
            textBoxOutput.AppendText(Environment.NewLine + "Parent = " + currDir.Parent.ToString());
            textBoxOutput.AppendText(Environment.NewLine + "Attributes = " + currDir.Attributes);
            textBoxOutput.AppendText(Environment.NewLine + "Creation time = " + currDir.CreationTime);

            //string directoryPath = String.Format(textBoxDirectoryPath.Text);  //get directory path from textBox

            DirectoryInfo newDir = new DirectoryInfo(@"C:\Users\d.oligov\Csharp");
            if (!newDir.Exists) { newDir.Create(); }                        //creare directory if it doesnt exist
            
            string filePath = newDir.FullName + "\\a.txt";
            

            string textToWrite = textBoxOutput.Text;                   //get text from textBox
            
            File.WriteAllText(filePath, textToWrite);                  //write it to file

            //output all lines that were read from file into textBox
            int lineCounter = 0;
            foreach (string name in File.ReadAllLines(filePath))
            {
                lineCounter++;
                textBoxOutput.AppendText(String.Format(Environment.NewLine + "{0,-20} : {1}", lineCounter, name));
            }

            //get txt files fro, directory and its subdirs
            DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\d.oligov\Csharp");
            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt",SearchOption.AllDirectories);

            //print them out to textBoxileInfo fi in txtFiles)
            foreach (FileInfo fi in txtFiles)
            {
                textBoxOutput.AppendText(Environment.NewLine + fi.FullName + " size: " + fi.Length);
            }
            
        }

        private void buttonFileStreamWrite_Click(object sender, EventArgs e)
        {
            fs = File.Open(filePath, FileMode.OpenOrCreate);                            //create FileStream
            string randomString = "cucu ruku" + Environment.NewLine + "master juku";    //make some string(random text)
            byte[] bytesFromRandomString = Encoding.Default.GetBytes(randomString);     //convert it to bytes and write into byte array

            fs.Write(bytesFromRandomString, 0, bytesFromRandomString.Length);           //write FileStream to file

            fs.Close();
        }

        private void buttonFileStreamRead_Click(object sender, EventArgs e)
        {
            fs = File.Open(filePath, FileMode.OpenOrCreate);    //open FileStream
            FileInfo file = new FileInfo(filePath);             //make FileInfo var for retrieving file length later
            
            byte[] byteArrFromFile = new byte[file.Length];     //create byte array same length as file

            for (int i = 0; i < file.Length; i++)
            {
                byteArrFromFile[i] = (byte)fs.ReadByte();       //use FileStream to read file byte by byte
            }
            textBoxFileStream.AppendText(Encoding.Default.GetString(byteArrFromFile));  //convert FileStream to string and output to textBox

            fs.Close();

        }
    }
}
