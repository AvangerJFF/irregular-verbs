using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace words
{
    class WordManager
    {
        private List<Word> words = new List<Word>(); // Список типа words
        string path = "";

        string dir = Directory.GetCurrentDirectory();

        public void PullWords(int fileId)

        {
            words.Clear();
            path = $"{fileId}.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                int lineCount = System.IO.File.ReadAllLines(path).Length;

                for (int i = 0; i < lineCount; i++)
                {
                    string[] line = reader.ReadLine().Split(";");
                    Word word = new Word(line[0], line[1], line[2], line[3]);
                    words.Add(word);
                    //words[0].
                }
            }
        }

        public List<Word> TakeAllWords()
        {
            return words;
        }
        //public int count = 0; // количество ошибок
        //public int line = 0; // номер строки
        ////public char = // строк

        //public void ValidationWord()

        //{
        //    for (int = 0; int < )

        //}

        List<Word> first = new List<Word>();
        List<Word> second = new List<Word>();

        

        public int Validation(List<Word> groupWords, Word userWord)
        {
            int count = 0;
            for (int i = 0; i < groupWords.Count; i++)
            {
                if (Equals(userWord.GetType().GetProperties().GetValue(0), groupWords[i].GetType().GetProperties().GetValue(0)))
                {
                    count++;
                }
                if (EqualsTwoWords(userWord, groupWords[i]))
                {
                    count++;
                }
                
            }
            return count;
        }

        public bool EqualsTwoWords(Word firstWord, Word secondWord)
        {
            bool state = false;

            if (firstWord.ruWord.Equals(secondWord.ruWord))
            {
                if (firstWord.firstForm.Equals(secondWord.firstForm))
                {
                    if (firstWord.secondForm.Equals(secondWord.secondForm))
                    {
                        if (firstWord.thirdForm.Equals(secondWord.thirdForm))
                        {
                            state = true;
                        }
                    }
                }
            }

            return state;
        }
    }
}
