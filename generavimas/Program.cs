using System;
using System.Text;

namespace generavimas
{
    public class Example
    {
        /*public static string GetRandomPassword(int length)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ?!@#$%^&";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }*/

        public static void Main()
        {
            int length = 10;
            Passw obj = new Passw();
            string password;
            password = obj.GetRandomPassword(length);
            Console.WriteLine(password);
        }
    }
}