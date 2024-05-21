using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Activity_20_5_2024
{
    internal class Stacks
    {
        public Stack<string> stack;

        public Stacks() { 
            this.stack = new Stack<string>();
        }

        public void initializeStack()
        {
            stack.Push("principito");
            stack.Push("Mi planta naranja Lima");
            stack.Push("Zambo Salvito");
            stack.Push("Don Quijote de la Mancha");
            stack.Push("Raza de Bronce");
        }


        public void printStack()
        {
            foreach(var item in stack)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public void delteFromStack()
        {
            stack.Pop();
            stack.Pop();
        }
    }
}
