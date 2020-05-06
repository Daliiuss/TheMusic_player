using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TheMusic_player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] files, paths;

        //FileInfo[] Files = null;
        //string[] paths = null;
        private void button1_Click(object sender, EventArgs e)
        {

            
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Text = folderBrowserDialog1.SelectedPath;
                //DirectoryInfo d = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                files = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.mp3");
                paths = files;
                //Files = d.GetFiles("*.mp3");
                //paths = d.GetFiles("*.mp3");
                /*string str = "";
                string path = "";
                
                for(int i =0;i<Files.Count();i++)
                {
                    str = str + Files[i].Name;
                    listBox1.Items.Add(str);
                    path = path + folderBrowserDialog1.SelectedPath;
                    paths[i] = path + str;
                }*/
                // Save only the names
                // Save the full paths
               
                // Add songs to the listbox
                for (int i = 0; i < files.Length; i++)
                {
                    listBox1.Items.Add(Path.GetFileName(files[i]));
                }
            }
            /*if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Save only the names
                files = openFileDialog1.SafeFileNames;
                // Save the full paths
                paths = openFileDialog1.FileNames;
                // Add songs to the listbox
                for (int i = 0; i < files.Length; i++)
                {
                    listBox1.Items.Add(files[i]); 
                }
            }*/
        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
        //play button controls
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
                    //paths[listBox1.SelectedIndex];
            }
            else
            {
                MessageBox.Show("No files selected");
            }
        }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        
        }
        //remove button controls
        private void button3_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox1);
            selectedItems = listBox1.SelectedItems;
            if (listBox1.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    listBox1.Items.Remove(selectedItems[i]);
            }
            else
            {
                MessageBox.Show("No files selected");
            }
        }
        //stop button controls
        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muzikinių bylų (mp3) grojimo programa (iš nurodyto aplankalo).");
        }

        //list control
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }
    }
}
