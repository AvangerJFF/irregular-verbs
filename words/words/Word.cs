using System;
using System.Collections.Generic;
using System.Text;

namespace words
{
    class Word
    {

        public string ruWord { get; set; }
        public string firstForm { get; set; }
        public string secondForm { get; set; }
        public string thirdForm { get; set; }

        public Word()
        {

        }
        public Word(string ruWord, string firstForm, string secondForm, string thirdForm)
        {
            this.ruWord = ruWord;
            this.firstForm = firstForm;
            this.secondForm = secondForm;
            this.thirdForm = thirdForm;

        }
 

    }
}
