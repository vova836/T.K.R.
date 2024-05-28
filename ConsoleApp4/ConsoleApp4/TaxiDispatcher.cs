using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;

namespace ConsoleApp4
{
    class TaxiDispatcher
    {
        private string[] dispatcherMetting = {
        "Здравствуйте, укажите пожалуйста, адрес откуда вас нужно забрать.",
        "Здравствуйте! Пожалуйста, укажите свое место назначения.",
        "Здравствуйте, укажите пожалуйста ваш адрес.",
        "Здравствуйте, пожалуйста укажите где вы сейчас находитесь."
    };
        private string[] dispatcherGoing = {
        "И куда вас нужно отвезти?",
        "Теперь скажите, куда вы хотите ехать?",
        "Скажите, пожалуйста, куда вам надо ехать?",
        "Куда вам нужно направиться сегодня?"
    };
        private string[] dispatcherTimadialog = {
        "Приблизительное время подачи такси?",
        "Пожалуйста укажите время подачи такси?",
        "Через сколько минут или часов вы хотите чтобы к вам подъехала такси?",
        "Через сколько времени к вам должно подъехать такси?"
    };
        private string[] dispatcherTaxidiases = {
        "Хорошо! Ваш заказ принят, к вам приедет свободное такси.",
        "Хорошо, к вам будет отправлено свободное такси.",
        "Принято к вам скоро приедет такси.",
        "Понял, к вам скоро будет отправлен такси."
    };
        private string[] inappropriateResponses = {
        "Пожалуйста, не используйте ненормативную лексику. Мы хотим вам помочь.",
        "Попрошу вас говорить культурно. Мы здесь, чтобы помочь вам.",
        "Давайте общаться без грубостей. Чтобы вы могли нормально поехать.",
        "Пожалуйста ведите себя прилично."
    };

        private string[] apologyResponses = {
        "Ладно не беспокойтесь, наверное у вас тяжелый день."
    };

        private int currentStep = 0;
        private bool awaitingApology = false;
        private string lastDispatcherMessage;

        public void ProcessTaxiOrder()
        {
            while (currentStep < 5)
            {
                if (awaitingApology)
                {
                    HandleApology();
                }
                else
                {
                    HandleStep();
                }
            }
        }

        private void HandleStep()
        {
            string userInput;

            switch (currentStep)
            {
                case 0:
                    if (PromptAndHandleResponse(dispatcherMetting, out userInput)) return;
                    currentStep++;
                    break;
                case 1:
                    if (PromptAndHandleResponse(dispatcherGoing, out userInput)) return;
                    currentStep++;
                    break;
                case 2:
                    if (PromptAndHandleResponse(dispatcherTimadialog, out userInput)) return;
                    currentStep++;
                    break;
                case 3:
                    if (PromptAndHandleResponse(dispatcherTaxidiases, out userInput)) return;
                    currentStep++;
                    break;
                case 4:
                    NotifyUserOfTaxiDetails();
                    currentStep++;
                    break;
            }
        }

        private bool PromptAndHandleResponse(string[] responses, out string userInput)
        {
            PromptUser(out userInput);
            if (HandleInappropriateLanguage(userInput)) return true;
            lastDispatcherMessage = RandomlyRespond(responses);
            return false;
        }

        private void PromptUser(out string userInput)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Write("Клиент: ");
            userInput = Console.ReadLine();
        }

        private string RandomlyRespond(string[] responses)
        {
            Random rand = new Random();
            int index = rand.Next(responses.Length);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Thread.Sleep(1000);
            string response = "Диспетчер: " + responses[index];
            Console.WriteLine(response);
            return response;
        }

        private void NotifyUserOfTaxiDetails()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Thread.Sleep(1000);
            Console.WriteLine("Диспетчер: Также вы получите уведомление на телефон.");
            Thread.Sleep(1000);
            Console.WriteLine("Диспетчер: Какая машина к вам приедет и кто водитель.");

            Taxi taxi = new Taxi
            {
                CarNumber = "789-CD-789",
                Color = "белый",
                DriverName = "Петров Петр Петрович"
            };

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Thread.Sleep(3000);
            Console.WriteLine($"Уведомление: Вам назначено такси.");
            Console.WriteLine($"Уведомление: Номер машины {taxi.CarNumber}");
            Console.WriteLine($"Уведомление: Цвет машины {taxi.Color}");
            Console.WriteLine($"Уведомление: Водитель такси {taxi.DriverName} ");
        }

        private bool HandleInappropriateLanguage(string input)
        {
            if (ContainsInappropriateLanguage(input))
            {
                RespondWithInappropriateLanguageWarning();
                awaitingApology = true;
                return true;
            }
            return false;
        }

        private bool ContainsInappropriateLanguage(string input)
        {
            string[] inappropriateWords = { "блядь", "сука", "нахуй", "хуй", "ебать", "пиздец" };
            foreach (string word in inappropriateWords)
            {
                if (Regex.IsMatch(input, @"\b" + Regex.Escape(word) + @"\b", RegexOptions.IgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void RespondWithInappropriateLanguageWarning()
        {
            Random rand = new Random();
            int index = rand.Next(inappropriateResponses.Length);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Диспетчер: " + inappropriateResponses[index]);
        }

        private void HandleApology()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(1000);
            Console.Write("Клиент: ");
            string userInput = Console.ReadLine();

            if (IsApology(userInput))
            {
                RespondWithApology();
                awaitingApology = false;
                // Повторяем последний запрос диспетчера
                Console.WriteLine(lastDispatcherMessage);
            }
            else if (ContainsInappropriateLanguage(userInput))
            {
                RespondWithInappropriateLanguageWarning();
            }
            else
            {
                awaitingApology = false;
                ResumeConversation(userInput);
            }
        }

        private bool IsApology(string input)
        {
            return Regex.IsMatch(input, @"\b(прости|прошу прощения|извините|простите)\b", RegexOptions.IgnoreCase);
        }

        private void RespondWithApology()
        {
            Random rand = new Random();
            int index = rand.Next(apologyResponses.Length);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Диспетчер: " + apologyResponses[index]);
        }

        private void ResumeConversation(string userInput)
        {
            HandleStep();
        }
    }
}

