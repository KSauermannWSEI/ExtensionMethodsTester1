using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsTester1
{
    public static class Extensions
    {
        public static int ToInt(this String val) //Przykład metody konwertujacej string na int
        {
            try
            {
                return Convert.ToInt32(val);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static int ToInt<T>(this T val) where T : struct //Przykladowa metoda rozszerzająca generyczna
        {
            try
            {
                Type type = typeof(T);

                if (type == typeof(string))//Sprawdzenie typu
                {
                    return -100; //Dla testu
                }
                if (val is double)//Sprawdzenie typu
                {
                    int x = int.Parse(val.ToString()); //Rzuci wyjątkiem jeśli dostanie liczbę z przecinkiem.
                    return Convert.ToInt32(x + 1); //nie rzuci wyjatkiem jeśli dostanie liczbę z przecinkiem -> zostawi tylko część całkowitą 
                }
                return Convert.ToInt32(val);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static int ToInt1(String val) //Zwykla metoda konwertująca
        {
            try
            {
                return Convert.ToInt32(val);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public static string Left(this string val, int digits) //Przykladowa mtoda podobna to funkcji z Excela
        {
            return val.Substring(0, digits);
        }
        public static void Log(this string text) //Przyklad bez parameru
        {
            string directory = "D:/Loggs";
            File.AppendAllText(Path.Combine(directory, "Info.txt"),
                $"{Environment.NewLine} Data: {DateTime.Now.ToShortDateString()} Informacja: {text}");
        }
        public static void Log(this string text, string fileName) //Przykład z parametrem
        {
            string directory = "D:/Loggs";
            File.AppendAllText(Path.Combine(directory, fileName),
                $"{Environment.NewLine} Data: {DateTime.Now.ToShortDateString()} Informacja: {text}");
        }
    }
}
