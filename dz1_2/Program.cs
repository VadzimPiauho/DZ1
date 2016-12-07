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
                string sticket = Console.ReadLine();
                if (sticket.Length < 0 && sticket.Length > 6)
                {
                    throw new IndexOutOfRangeException();
                }
                int Iticket = Convert.ToInt32(sticket);
                Console.WriteLine((Convert.ToInt32(Convert.ToString(sticket)[0].ToString()) +
                                   Convert.ToInt32(Convert.ToString(sticket)[1].ToString()) +
                                   Convert.ToInt32(Convert.ToString(sticket)[2].ToString())) ==
                                  (Convert.ToInt32(Convert.ToString(sticket)[3].ToString()) +
                                   Convert.ToInt32(Convert.ToString(sticket)[4].ToString()) +
                                   Convert.ToInt32(Convert.ToString(sticket)[5].ToString()))
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