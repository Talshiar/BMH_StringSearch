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

namespace BoyerMooreHorspoolCSharp
{
    public partial class StringSearch : Form
    {
        public StringSearch()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "txt";
            ofd.Title = "Choose a text file";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string file = ofd.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    int size = text.Length;
                    textBoxFileText.Text = text;
                    groupBoxType.Enabled = false;
                }
                catch(IOException)
                {
                    MessageBox.Show("Error reading the file.");
                }

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }



    }
}
