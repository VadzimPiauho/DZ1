using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Необходимо ввести числом N, причем N>0");
            try
            {
                Console.WriteLine("Введите N");
                string N =Console.ReadLine();      
                if (Convert.ToInt32(N) < 0)
                {
                    Console.WriteLine("Не соблюдено условие N>0");
                    return;
                }
                Console.Clear();
                Console.WriteLine("Полученное число");
                for (int i = N.Length-1; i >= 0; i--)
                {
                    Console.Write(N[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
                Environment.Exit(0);
            }
            Console.WriteLine();

        }
    }
} 