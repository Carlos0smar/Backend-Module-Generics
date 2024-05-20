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
            stack.Push("principito");
            stack.Push("principito");
            stack.Push("principito");
            stack.Push("principito");
        }
    }
}
