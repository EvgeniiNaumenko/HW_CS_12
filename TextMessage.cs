using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_12_21_06_2024
{
    internal class TextMessage
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
        public void SayGoodBye(string name)
        {
            Console.WriteLine($"Goodbye {name}!");
        }
        public void AskAge(string name)
        {
            Console.WriteLine($"How old are you {name}?");
        }


    }
}
