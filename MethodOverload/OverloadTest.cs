using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    public class OverloadTest
    {
        public void PrintMessage(string text, int number)
        {
            Console.WriteLine($"Your Text: {text} and your number: {number}");
        }

        public void PrintMessage(string text1, string text2)
        {
            Console.WriteLine($"Your Text: {text1} and your other text: {text2}");
        }
    }
}
