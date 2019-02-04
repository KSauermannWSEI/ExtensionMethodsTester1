using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsTester1
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "3";
            int n = Extensions.ToInt1(number);
            int n2 = number.ToInt();
            

            Console.WriteLine(n2);

            string text = "Maria lubi koty st dfg h fghfg hf gh fgh";

            text.Log();
            try
            {
                throw new Exception("Nie używaj tej aplikacji");
            }
            catch (Exception exe)
            {
                exe.Message.Log();                
            }
            string left = text.Left(5);
            Console.WriteLine(left);

            Console.Read();
        }
    }
}
