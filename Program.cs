using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game__Guess_the_number_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int lower, higher;
            int triesCount = 5;
            int userInput;
            Random random= new Random();

            number = random.Next(0, 101); 
            lower = random.Next(number - 10, number); 
            higher = random.Next(number + 1, number + 10);

            Console.WriteLine($"Я загадал число от 0 до 100, оно больше чем {lower}, но меньше чем {higher}.");
            Console.WriteLine($"Что это за число? У тебя {triesCount} попыток отгадать.");

            while (triesCount-- > 0)
            {
                Console.Write("Ваш ответ: ");
                userInput = Convert.ToInt32( Console.ReadLine() );
                if (userInput == number)
                {
                    Console.WriteLine("Ты прав_а, это было число " + number + ".");
                    break;
                }
                else
                {
                    Console.WriteLine("Не-а, попробуй еще раз.");
                }
            }
           
            if (triesCount < 0)
            {
                Console.WriteLine("Ты проиграл_а. В следующий раз повезет! Это было число " + number);
            }
        }
    }
}
