using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace words
{
    public partial class Form1 : Form
    {
        WordManager _wordManager = new WordManager();
        List<Word> _words = new List<Word>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _wordManager.PullWords();
            _words = _wordManager.TakeAllWords();
            for (int i = 0; i < _words.Count; i++)
            {
                testBox.Text += _words[i].ruWord + " " + _words[i].firstForm + " " + _words[i].secondForm + " " + _words[i].thirdForm + Environment.NewLine;
            }
        }
    }
}
