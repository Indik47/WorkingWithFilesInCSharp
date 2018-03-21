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
        string filePath02 = "C:\\Users\\d.oligov\\Csharp\\dftg.txt";
        string filePath03 = "C:\\Users\\d.oligov\\Csharp\\b.txt";
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
        }

        private void buttonFileStreamWrite_Click(object sender, EventArgs e)
        {
            fs = File.Open(filePath02, FileMode.OpenOrCreate);                            //create FileStream
            string randomString = "cucu ruku" + Environment.NewLine + "master juku";    //make some string(random text)
            byte[] bytesFromRandomString = Encoding.Default.GetBytes(randomString);     //convert it to bytes and write into byte array

            fs.Write(bytesFromRandomString, 0, bytesFromRandomString.Length);           //write FileStream to file

            fs.Close();
        }

        private void buttonFileStreamRead_Click(object sender, EventArgs e)
        {
            fs = File.Open(filePath02, FileMode.OpenOrCreate);    //open FileStream
            FileInfo file = new FileInfo(filePath02);             //make FileInfo var for retrieving file length later
            
            byte[] byteArrFromFile = new byte[file.Length];     //create byte array same length as file

            for (int i = 0; i < file.Length; i++)
            {
                byteArrFromFile[i] = (byte)fs.ReadByte();       //use FileStream to read file byte by byte
            }
            textBoxStreams.AppendText(Encoding.Default.GetString(byteArrFromFile));  //convert FileStream to string and output to textBox

            fs.Close();

        }

        private void buttonTxtFiles_Click(object sender, EventArgs e)
        {
            //get txt files from directory and its subdirs
            DirectoryInfo myDataDir = new DirectoryInfo(@"C:\Users\d.oligov\Csharp");
            FileInfo[] txtFiles = myDataDir.GetFiles("*.txt", SearchOption.AllDirectories);

            //print them out to textBox
            foreach (FileInfo fi in txtFiles)
            {
                textBoxOutput.AppendText(Environment.NewLine + fi.FullName + " size: " + fi.Length);
            }
        }

        private void buttonReadFromFile_Click(object sender, EventArgs e)
        {
            //read all lines from a file and write them to textBox
            int lineCounter = 0;
            foreach (string name in File.ReadAllLines(filePath02))
            {
                lineCounter++;
                textBoxOutput.AppendText(String.Format(Environment.NewLine + "{0,-5} : {1}", lineCounter, name));
            }
        }

        private void buttonWriteToFile_Click(object sender, EventArgs e)
        {
            DirectoryInfo newDir = new DirectoryInfo(@"C:\Users\d.oligov\Csharp");      //create DirectoryInfo
            //if (!newDir.Exists) { newDir.Create(); }                                  //creare directory if it doesnt exist
            string filePath01 = newDir.FullName + "\\a.txt";                              //create filePath string
            FileInfo newFile = new FileInfo(filePath01);                                  //create FileInfo
            string textToWrite = textBoxOutput.Text;



            using (StreamWriter sw = newFile.CreateText())
            {
                sw.Write(textToWrite);
            }

            //File.AppendAllText(newDir.FullName + "\\a.txt", textToWrite); //write it to file 2nd way
        }

        private void buttonStreamWriter_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText(filePath03);

            sw.Write(DateTime.Today);
            sw.Close();

        }
    }
}
