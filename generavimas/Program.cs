using System;
using System.Text;

namespace generavimas
{
    public class Example
    {
        public static void Main()
        {
            Console.Write("Kokio ilgio noresite tureti slaptazodi? ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kiek noresite tureti slaptazodziu? ");
            int num = Convert.ToInt32(Console.ReadLine());

            Passw obj = new Passw();
            obj.GetRandomPassword(length, num);  
        }
    }
}