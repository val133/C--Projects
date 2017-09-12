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

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1CreateFolder_Click(object sender, EventArgs e)
        {
            string path1 = textBox1.Text;
            string stringpath = System.IO.Path.Combine(path1, "VLADIMIR");
            if (!Directory.Exists(stringpath))
            {
                Directory.CreateDirectory(stringpath);
                MessageBox.Show("Folder created");

            }
            else { MessageBox.Show("folder exist"); }
        }

        private void ShowFolderButton_Click(object sender, EventArgs e)
        {
            string stringtext = textBox2.Text;
            DirectoryInfo file = new DirectoryInfo(stringtext);
            FileInfo[] info = file.GetFiles();
            string str = "";
            foreach (FileInfo information in info)
            {
                str = str + ", " + information.Name;
            }
            MessageBox.Show(str);
            {

            }
        }

        private void CreateFile_Click(object sender, EventArgs e)
        {
            string exefile = textBox1.Text;
            if (!File.Exists(exefile))
            {
                File.Create(exefile);
                MessageBox.Show("file created");
            }
            else
            {
                MessageBox.Show("file is no created");
            }

        }

        private void DeleteFIleButton_Click(object sender, EventArgs e)
        {
            string deletefile = textBox2.Text;
            if (!File.Exists(deletefile))
            {
                MessageBox.Show("delete is not");
            }
            else
            {
                File.Delete(deletefile); MessageBox.Show("file is deleted");


            }
        }
    }
}
