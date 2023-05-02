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
        List<Word> _correctWords = new List<Word>();
        List<Word> _uncorrectWords = new List<Word>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testBox.Text = "";
            _words = _wordManager.TakeAllWords();


            //for (int i = 0; i < _words.Count; i++)
            //{
            //    testBox.Text += _words[i].ruWord + Environment.NewLine;
            //}

            Word worduser = new Word(ruWordText.Text, firstFormText.Text, secondFormText.Text, thirdFormText.Text);

            testBox.Text = _wordManager.Validation(_words, worduser).ToString();
            

        }

        private void ChooseGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                _wordManager.PullWords(ChooseGroup.SelectedIndex + 1);
            }
            catch (Exception)
            {

                _wordManager.PullWords(ChooseGroup.SelectedIndex);
                //ex.Message.
            }
        }

        
    }
}
