using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace dz1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int spaceValue = 0;
            ConsoleKeyInfo Symbol;
            Console.WriteLine("Программа подсчета веденных пробелов"); 
            do
            {
                Console.WriteLine("Введите символ");
                Console.WriteLine("Для окончания ввода нажмите точку ");
                Symbol = Console.ReadKey();
                Console.WriteLine();
                Console.Clear();
                //if ((Symbol.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
                //if ((Symbol.Key==ConsoleKey.DownArrow)) Console.Write(Symbol.Key);

                Console.WriteLine(Symbol.Key);
                if (Symbol.KeyChar == ' ')
                {
                    Console.WriteLine("Пробел");
                    spaceValue++;
                }
                if (Symbol.KeyChar == '.')
                {
                    break;
                }
            } while (true);
            Console.WriteLine("Количество введенных пробелов = " + spaceValue);  
        }
    }
}
