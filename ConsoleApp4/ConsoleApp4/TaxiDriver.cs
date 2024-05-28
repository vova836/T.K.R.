using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp4
{
    class TaxiDriver
    {
        private string[] driverMetting = {
        "Здравствуйте, диспетчер сообщил мне куда нам надо ехать.",
        "Добрый день, мне диспетчер сообщил куда вам нужно ехать.",
        "Здравствуйте, у меня уже есть информация о вашем пункте назначения.",
        "Здрастье, диспетчер указал мне куда нам нужна ехать."
    };
        private string[] driverSaying = {
        "Так что садитесь начинаем выезжать.",
        "Садитесь мы сейчас выезжаем.",
        "Садитесь, начинаем выезжать."
    };
        private string[] driverQuestion = {
        "Хотите музыку или радио?",
        "Включить вам радио или музыку?",
        "Вам включить радио или музыку?",
        "Радио или музыку вам включить?"
    };
        private string[] driverDrivedialog = {
        "Мы уже в пути, скоро доедим, еще нужно подождать.",
        "Мы скоро уже приедем, надо вам просто подожать.",
        "Мы скоро доедим, а пока потерпите.",
        "Потерпите немного и мы уже приедем."
    };
        private string[] driverArrived = {
        "Все мы приехали с вас 67 рублей",
        "Мы приехали с вас 67 рублей",
        "Мы уже приехали с вас 67 рублей"
    };
        public void ProcessDriveTaxi()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            /// <summary>
            /// Задержка потока которая приостанавливает выполнения программы на 2 секунды
            /// </summary>
            Thread.Sleep(2000);
            /// <summary>
            /// Приезд водителя такси
            /// </summary>
            Console.WriteLine("Приезжает водитель такси:");

            Random rand = new Random();
            int index = rand.Next(driverMetting.Length);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(1000);
            Console.WriteLine("Водитель: " + driverMetting[index]);
 
            index = rand.Next(driverSaying.Length);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(1000);
            Console.WriteLine("Водитель: " + driverSaying[index]);

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Write("Клиент: ");
            string pickupLocation = Console.ReadLine();

            index = rand.Next(driverQuestion.Length);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(1000);
            Console.WriteLine("Водитель: " + driverQuestion[index]);

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Write("Клиент: ");
            string destination = Console.ReadLine();

            // Проверка на наличие слова "нет" в ответе пользователя
            if (!destination.ToLower().Contains("нет"))
            {
                if (destination.ToLower().Contains("музыка"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Thread.Sleep(1000);
                    Console.WriteLine("Водитель: Хорошо, включу вам музыку.");
                    // Здесь можно добавить код для включения музыки
                }
                else if (destination.ToLower().Contains("музыку"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Thread.Sleep(1000);
                    Console.WriteLine("Водитель: Хорошо, включу вам музыку.");
                }
                else if (destination.ToLower().Contains("радио"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Thread.Sleep(1000);
                    Console.WriteLine("Водитель: Хорошо, включу вам радио.");
                    // Здесь можно добавить код для включения радио
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Thread.Sleep(1000);
                Console.WriteLine("Водитель: Хорошо, как скажите, вам решать.");
            }


            // В процессе поездки
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(2000);
            Console.WriteLine("В процессе поездки:");

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Write("Клиент: ");
            string pickupLocations = Console.ReadLine();


            index = rand.Next(driverDrivedialog.Length);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(1000);
            Console.WriteLine("Водитель: " + driverDrivedialog[index]);

            // В процессе поездки
            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(2000);
            Console.WriteLine("После приезда:");

            index = rand.Next(driverArrived.Length);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Водитель: " + driverArrived[index]);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(1000);
            Console.WriteLine("Водитель: Платить вы будете наличными и картой?");

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Write("Клиент: ");
            string arrivedpay = Console.ReadLine();

            if (arrivedpay.ToLower().Contains("Наличными"))
            {
               Console.ForegroundColor = ConsoleColor.DarkYellow;
               Thread.Sleep(1000);
               Console.WriteLine("Водитель: Хорошо, платите наличными.");
            }
            else if (arrivedpay.ToLower().Contains("Картой"))
            {
               Console.ForegroundColor = ConsoleColor.DarkYellow;
               Thread.Sleep(1000);
               Console.WriteLine("Водитель: Хорошо, платите картой.");
            }

            Console.ForegroundColor = ConsoleColor.Black;
            Thread.Sleep(2000);
            Console.WriteLine("Происходит оплата: ");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Thread.Sleep(1000);
            Console.WriteLine("Водитель: A nеперь оцените пожалуйста, мою работу по шкале от 1 до 5.");

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Write("Клиент: ");
            string driverrating = Console.ReadLine();

            // Проверка на наличие слова "нет" в ответе пользователя
            if (!driverrating.ToLower().Contains("1"))
            {
                if (driverrating.ToLower().Contains("2"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Thread.Sleep(1000);
                    Console.WriteLine("Водитель: Похоже вам что-то не понравилось.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Водитель: Прошу прощения если вы чем-то не довольны мною.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Водитель: Похоже если вам что-то не понравилось.");
                    Thread.Sleep(1000);
                    Console.WriteLine("До свидания всего вам хорошего.");


                    // Здесь можно добавить код для включения музыки
                }
                else if (driverrating.ToLower().Contains("3"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Thread.Sleep(1000);
                    Console.WriteLine("Водитель: Прошу прощения если вы чем-то недовольны.");
                    Thread.Sleep(1000);
                    Console.WriteLine("До свидания всего вам хорошего.");
                }
                else if (driverrating.ToLower().Contains("4"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Thread.Sleep(1000);
                    Console.WriteLine("Водитель: Спасибо за ваш отзыв.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Водитель: До свидания всего вам хорошего");
                }
                else if (driverrating.ToLower().Contains("5"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Thread.Sleep(1000);
                    Console.WriteLine("Водитель: Спасибо за ваш отзыв!");
                    Thread.Sleep(1000);
                    Console.WriteLine("Водитель: До свидания всего вам хорошего");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Thread.Sleep(1000);
                Console.WriteLine("Водитель: Оу ладно я вас понял.");
                Thread.Sleep(1000);
                Console.WriteLine("Водитель: Простите если вам что-то не понравилось во время поездки.");
                Thread.Sleep(1000);
                Console.WriteLine("Водитель: До свидания всего вам хорошего");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Write("Клиент: ");
            string goodbyeing = Console.ReadLine();
        }
    }
}
