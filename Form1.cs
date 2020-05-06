using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Play the song 
            
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }
    }
}
