using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;


namespace PasswordCheckDemo
{
    internal class ConsoleOutputPrinter
    {
        public static void PrintResults(IExcelDataReader reader)
        {
            Console.WriteLine(" Felhasználó".PadRight(20) + "Jelszó");
            Console.WriteLine(new string('-', 54)); 

            bool isHeaderRow = true; // A fejléc sor az első sor

            while (reader.Read())
            {
                PasswordValidator validator = new PasswordValidator();
                if (isHeaderRow)
                {
                    isHeaderRow = false;
                    continue; // Kihagyjuk a fejléc sort
                }

                if (reader.FieldCount >= 2)
                {
                    string username = reader[0].ToString();
                    string password = reader[1].ToString();
                    string result = validator.IsStrongPassword(password) ? "Erős Jelszó" : "Gyenge Jelszó";
                    Console.WriteLine(username.PadRight(20) + password.PadRight(20) + result);
                }
            }
        }
    }
}
