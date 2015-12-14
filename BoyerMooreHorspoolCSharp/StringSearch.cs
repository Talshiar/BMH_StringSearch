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
        bool usingFile = false;
        string text = "";
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
                    text = File.ReadAllText(file);
                    int size = text.Length;
                    textBoxFileText.Text = text;
                    groupBoxType.Enabled = false;
                    usingFile = true;
                }
                catch(IOException)
                {
                    MessageBox.Show("Error reading the file.");
                }

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            inputDataCheck();
            int index = search(text, textBoxPattern.Text);
         
        }

        public int[] badCharactersTable(string pattern)
        {
            int[] table = new int[256];
            for (int i = 0; i < 256; ++i)
            {
                table[i] = pattern.Length;
            }
            for (int i = 0; i < pattern.Length - 1; ++i)
            {
                table[pattern[i]] = pattern.Length - 1 - i;
            }
            return table;
        }

        public int search(string text, string pattern)
        {
            int[] badTable = badCharactersTable(textBoxPattern.Text);
            int skip = 0;
            int i;
            while (text.Length - skip >= pattern.Length)
            {
                i = pattern.Length - 1;
                while (text[skip + i] == pattern[i])
                {
                    if (i == 0) return skip;
                    i = i - 1;
                }
                skip = skip + badTable[text[skip + pattern.Length - 1]];
            }
            return -1;
        }
        public void inputDataCheck()
        {
            if (!usingFile && textBoxInput.Text != "") text = textBoxInput.Text;
            else if (!usingFile)
            {
                MessageBox.Show("Please browse for a text file or input random text to search through.");
                return;
            }
            if (textBoxPattern.Text == "")
            {
                MessageBox.Show("Please enter a pattern you want to search for.");
                return;
            }
            if (textBoxPattern.Text.Length > text.Length)
            {
                MessageBox.Show("The provided pattern is longer than the text you are searching through. Please write a shorter pattern.");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
