using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Меню такси:");
                Console.WriteLine("1. Информация о водителях такси.");
                Console.WriteLine("2. Информация о таксопарков.");
                Console.WriteLine("3. История появления такси.");
                Console.WriteLine("4. Вызов диспетчера.");

                ConsoleKeyInfo key = Console.ReadKey();
                Console.WriteLine();

                switch (key.KeyChar)
                {
                    case '1':
                        // Код для информации о водителях такси
                        Console.WriteLine("Информация о водителях такси");
                        break;
                    case '2':
                        // Код для информации о таксопарков
                        Console.WriteLine("Информация о таксопарков:");
                        break;
                    case '3':
                        // Код для истории появления такси
                        Console.WriteLine("История появления такси:");
                        break;
                    case '4':
                        // Код для вызова диспетчера
                        Console.WriteLine("Вызов диспетчера:");
                        TaxiDispatcher dispatcher = new TaxiDispatcher();
                        dispatcher.ProcessTaxiOrder();
                        TaxiDriver driver = new TaxiDriver();
                        driver.ProcessDriveTaxi();
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод");
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Для продолжения нажмите любую клавишу...");
                Console.ReadKey();
            }
        }
    }
}
