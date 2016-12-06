using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 6 значный билет");
            try
            {
                string Sticket = Console.ReadLine();
                if (Sticket.Length < 0 && Sticket.Length > 6)
                {
                    throw new IndexOutOfRangeException();
                }
                int Iticket = Convert.ToInt32(Sticket);
                Console.WriteLine((Convert.ToInt32(Convert.ToString(Sticket)[0].ToString()) +
                                   Convert.ToInt32(Convert.ToString(Sticket)[1].ToString()) +
                                   Convert.ToInt32(Convert.ToString(Sticket)[2].ToString())) ==
                                  (Convert.ToInt32(Convert.ToString(Sticket)[3].ToString()) +
                                   Convert.ToInt32(Convert.ToString(Sticket)[4].ToString()) +
                                   Convert.ToInt32(Convert.ToString(Sticket)[5].ToString()))
                    ? "Билет счастливый"
                    : "Билет не является счастливым");
            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
                Environment.Exit(0);
            }
        }
    }
}