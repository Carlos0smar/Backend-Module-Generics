using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_20_5_2024
{
    internal class Dictionaries
    {
        public Dictionary<string, int> dictionary;

        public Dictionaries()
        {
            this.dictionary = new Dictionary<string, int>();
        }

        public void fillDictionary()
        {
            dictionary.Add("Carlos", 7);
            dictionary.Add("Miguel", 5);
            dictionary.Add("Pedro", 6);
            dictionary.Add("Alejandro", 8);
            dictionary.Add("Alejandra", 7);

        }

        public void printAll()
        {
            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"{key}: {dictionary[key]} ");
            }
        }


        public void updateStudent()
        {
            dictionary["Carlos"] = 10;
            dictionary.Remove("Miguel");
        }

    }
}
