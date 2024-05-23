using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextProcessingApplication
{
    internal class TextProcessor
    {
        public event EventHandler ProcessingCompleted;

        string text;
        public TextProcessor(string text)
        {
            this.text = text;
        }

        public void ProcessText(string text)
        {
            Console.WriteLine(CountWords(text));

            foreach (var element in CalculateCharFrequency(text))
            {

                Console.WriteLine(element.ToString());

            }


        }

        private int CountWords(string text)
        {
            int amountWords = text.Split(' ').Where(word => word.Length > 0).Count() ;

            return amountWords;

            
       }

        private Dictionary<char, int> CalculateCharFrequency(string text)
        {
            Dictionary<char, int> lettersFrequency = new Dictionary<char, int>();

            foreach (char c in text) {


                if (!lettersFrequency.ContainsKey(c))
                {
                    int frequency = text.Split().GroupBy(c => c).Count();

                    lettersFrequency.Add(c, frequency);

                }

            }
            return lettersFrequency;
        }

        //private string FindLongestWord(string text)
        //{

        //}

        protected virtual void OnProcessingCompleted(EventArgs e)
        {

        }

    }
}
