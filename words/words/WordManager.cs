using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace words
{
    class WordManager
    {
        private List<Word> words = new List<Word>();
        string path = "1.txt";
        string dir = Directory.GetCurrentDirectory();

        public void PullWords()
        {
            using(StreamReader reader = new StreamReader(path))
            {
                int lineCount = System.IO.File.ReadAllLines(path).Length;

                for (int i = 0; i < lineCount; i++)
                {
                    string[] line = reader.ReadLine().Split(";");
                    Word word = new Word(line[0], line[1], line[2], line[3]);
                    words.Add(word);
                }
            }
        }

        public List<Word> TakeAllWords()
        {
            return words;
        }
    }
}
