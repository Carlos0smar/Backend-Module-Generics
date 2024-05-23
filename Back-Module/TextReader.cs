using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextProcessingApplication
{
    static class TextReader
    {
        public static string readText(this string textFile)
        {
            try
            { 
                using StreamReader reader = new(textFile);

                return reader.ReadToEnd();
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return "";
            }

        }
    }
}