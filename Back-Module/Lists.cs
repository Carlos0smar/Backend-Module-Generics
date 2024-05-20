using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_20_5_2024
{


    internal class Lists
    {
        public List<int> integerCollection;

        public Lists() { 
            this.integerCollection = new List<int>();
        }

        public void fillList()
        {
            integerCollection.Add(1);
            integerCollection.Add(2);
            integerCollection.Add(3);
            integerCollection.Add(4);
            integerCollection.Add(5);
            integerCollection.Add(6);
            integerCollection.Add(7);
            integerCollection.Add(8);
            integerCollection.Add(9);
            integerCollection.Add(10);
        }

        public void removeFirstAndLast()
        {
            integerCollection.RemoveAt(integerCollection.Count - 1);
            integerCollection.RemoveAt(0);
        }

        public void printList()
        {
            foreach(int num in integerCollection) { 
                Console.WriteLine(num);
            }
        }

    }

}
