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

        

        public int Validation(List<Word> word1, Word userWord)
        {
            int count = 0;
            for (int i = 0; i < word1.Count; i++)
            {
                Word word3 = userWord;
                Word word4 = word1[0];
                //if (userWord.Equals(word1[i])){
                //    count++; 
                bool test = word3.Equals(word4);
                if (test) {
                    first.Add(word1[i]);
                    second.Add(userWord);


                    count++;
                }
            }
            return count;
        }
    }
}
