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
        public static int ToInt(this String val)
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

        public static int ToInt<T>(this T val) where T: struct
        {
            try
            {
                Type type = typeof(T);

                if (type == typeof(string))
                {
                    return -100; //Dla testu
                }
                if (val is double)
                {
                    int x = int.Parse(val.ToString());
                    //int z = val as int?;

                    return Convert.ToInt32(x + 1);
                }
                return Convert.ToInt32(val);
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static int ToInt1(String val)
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
        public static string Left(this string val, int digits)
        {
            return val.Substring(0, digits);
        }
        public static void Log(this string text)
        {
            try
            {
                string directory = "D:/Loggs";
                File.AppendAllText(Path.Combine(directory, "Info.txt"),
                    $"{Environment.NewLine} Data: {DateTime.Now.ToShortDateString()} Informacja: {text}");
            }
            catch (DirectoryNotFoundException dnfe)
            {
               // LogError(dnfe.Message);
            }
            catch (Exception)
            {
               // LogError("Coś się zepsuło");
            }
        }
    }
}
