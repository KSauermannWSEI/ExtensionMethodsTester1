using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsTester1
{
    class Program
    {
        class Roman //Inner class -> zalezność calosciowa agregacja/kompozycja, gdzie klasa Roman nie może istnieć bez klasy Program
        {
            public int MyProperty { get; set; }
        }
        static void Main(string[] args)
        {
            string number = "3"; // Przykladowy ciąg który będziemy konwertować na int.
            int n = Extensions.ToInt1(number); // Użycie zwykłej metody do konwersji.
            int n2 = number.ToInt(); // Użycie metody rozszerzającej do konwersji. 

            double d = 43.4d; 
            int dd = d.ToInt(); //Użycie metody rozszerzającej generycznej          

            Console.WriteLine(dd);

            string text = "Maria lubi koty st dfg h fghfg hf gh fgh";

            text.Log(); //Użycie metody rozszerzającej do logowania tekstu na dysk.

            //Przkład z logowaniem blędów
            try
            {
                throw new Exception("Nie używaj tej aplikacji");
            }
            catch (Exception exe)
            {
                exe.Message.Log("Error.txt");
            }

            //Uzycie metody Left gdzie podajemy ile znaków od lewej strony ma byc zwrócone ze stringa
            string left = text.Left(5);
            Console.WriteLine(left);

            Console.Read();
        }
    }
}
