using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generavimas
{
    internal class Passw
    {
        public void GetRandomPassword(int length, int num)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ?!@#$%^&";
            string[] mas = { " " };

            Random rnd = new Random();

            for (int j = 0; j < num; j++)
            {
                StringBuilder sb = new StringBuilder();
                Console.Write(j + 1 + ". ");
                for (int i = 0; i < length; i++)
                {
                    int index = rnd.Next(chars.Length);
                    sb.Append(chars[index]);   
                }
                Array.Resize(ref mas, mas.Length + 1);
                mas[j] = sb.ToString();
                Console.WriteLine(mas[j]);
            }
        }
    }
}
