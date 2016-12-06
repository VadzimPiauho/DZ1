using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Необходимо ввести А и В, причем А<B");
            try
            {
                Console.WriteLine("Введите А");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите B");
                int B = Convert.ToInt32(Console.ReadLine());
                if (A>=B||A<=0||B<=0)
                {
                    Console.WriteLine("Не соблюдено условие А<B либо числа A и B не положительные ");
                    return; 
                }
                Console.Clear();
                for (int i = A; i <= B; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
                Environment.Exit(0);
            }  
        }
    }
}
