using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_20_5_2024
{
    internal class Queues
    {
        public Queue<string> queue;
        public Queues() { 
            this.queue = new Queue<string>();
        }

        public void enqueue() {
            queue.Enqueue("Alejandra");
            queue.Enqueue("Miguel");
            queue.Enqueue("Alex");
            queue.Enqueue("Max");
            queue.Enqueue("Ricardo");

        }

        public void printQueue()
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        public void dequeue() {
            queue.Dequeue();
            queue.Dequeue();

        }

        public void printUpdatedQueue()
        {
            foreach(var item in queue)
            {
                Console.Write(item);
            }
        }
    }
}
