using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int SpaceValue = 0;
            ConsoleKeyInfo Symbol;  
            do
            {    
                Console.WriteLine("Введите символ для конвертации регистра");
                Console.WriteLine("Для окончания ввода нажмите ESC ");
                Symbol = Console.ReadKey();
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("Введенный символ " + Symbol.KeyChar);
                //Console.WriteLine("Введенный символ " + Convert.ToInt32(Symbol.KeyChar));

                if (Convert.ToInt32(Symbol.KeyChar)>=65&& Convert.ToInt32(Symbol.KeyChar)<=90)
                {
                    Console.WriteLine("Конвертируемый символ " + Convert.ToChar(Convert.ToInt32(Symbol.KeyChar)+32));
                }
                if (Convert.ToInt32(Symbol.KeyChar) >= 97 && Convert.ToInt32(Symbol.KeyChar) <= 122)
                {
                    Console.WriteLine("Конвертируемый символ " + Convert.ToChar(Convert.ToInt32(Symbol.KeyChar) - 32));
                }
                if (Convert.ToInt32(Symbol.KeyChar) == 27)
                {
                    break;
                }
            } while (true);         
        }
    }
}
