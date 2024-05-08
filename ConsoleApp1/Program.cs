using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования
            TaxiSystem taxiSystem = new TaxiSystem();

            // Добавление такси в систему
            taxiSystem.AddTaxi(new Taxi { TaxiID = 1, DriverName = "Джон", CarModel = "Toyota", Available = true });
            taxiSystem.AddTaxi(new Taxi { TaxiID = 2, DriverName = "Алиса", CarModel = "Honda", Available = false });
            taxiSystem.AddTaxi(new Taxi { TaxiID = 3, DriverName = "Боб", CarModel = "Ford", Available = true });
            taxiSystem.AddTaxi(new Taxi { TaxiID = 4, DriverName = "Джек", CarModel = "Mercedes", Available = false });
            taxiSystem.AddTaxi(new Taxi { TaxiID = 5, DriverName = "Адам", CarModel = "Mercedes-Benz", Available = true });
            taxiSystem.AddTaxi(new Taxi { TaxiID = 6, DriverName = "Эдвард", CarModel = "Volksvagen", Available = true });
            taxiSystem.AddTaxi(new Taxi { TaxiID = 7, DriverName = "Марк", CarModel = "Skoda", Available = true });
            taxiSystem.AddTaxi(new Taxi { TaxiID = 8, DriverName = "Майкл", CarModel = "BMV", Available = false });
            taxiSystem.AddTaxi(new Taxi { TaxiID = 9, DriverName = "Энни", CarModel = "Renault", Available = false });
            taxiSystem.AddTaxi(new Taxi { TaxiID = 10, DriverName = "Бен", CarModel = "Opel", Available = false });
            taxiSystem.AddTaxi(new Taxi { TaxiID = 11, DriverName = "Кларк", CarModel = "Peugeot", Available = true });
            taxiSystem.AddTaxi(new Taxi { TaxiID = 12, DriverName = "Уейт", CarModel = "Honda", Available = true });
            taxiSystem.AddTaxi(new Taxi { TaxiID = 13, DriverName = "Джейк", CarModel = "Mercedes", Available = true });

            // Поиск доступного такси
            Taxi availableTaxi = taxiSystem.FindAvailableTaxi();
            if (availableTaxi != null)
            {
                Console.WriteLine($"Доступное такси: ID {availableTaxi.TaxiID}, Водитель {availableTaxi.DriverName}, Модель {availableTaxi.CarModel}");
            }
            else
            {
                Console.WriteLine("Нет доступного такси.");
            }

            // Добавление информации о количестве пользователей такси
            int worldwideTaxiUsersDaily = 1_000_000; // Примерное количество пользователей такси ежедневно во всем мире
            int countryTaxiUsersWeekly = 100_000; // Примерное количество пользователей такси еженедельно в стране
            int cityTaxiUsersMonthly = 50_000; // Примерное количество пользователей такси ежемесячно в городе

            Console.WriteLine($"Во всем мире пользуются такси ежедневно: {worldwideTaxiUsersDaily} человек");
            Console.WriteLine($"В нашей стране пользуются такси еженедельно: {countryTaxiUsersWeekly} человек");
            Console.WriteLine($"В нашем городе пользуются такси ежемесячно: {cityTaxiUsersMonthly} человек");

            // Обзор существующих информационных систем о наличии такси
            Console.WriteLine("Обзор существующих информационных систем о наличии такси:");
            Console.WriteLine("- Система А: Uber это Одна из самых популярных и широко используемых информационных систем для заказа такси. Пользователи могут увидеть доступные автомобили на карте, оценить стоимость поездки и заказать такси непосредственно через мобильное приложение.");
            Console.WriteLine("- Система B: Yandex.Taxi это российская платформа, предоставляющая услуги такси. Подобно Uber, она позволяет пользователям заказывать такси через мобильное приложение, а также отслеживать местоположение машины и оценивать стоимость поездки.");
            Console.WriteLine("- Система C: Lyft еще одна популярная альтернатива Uber, предоставляющая услуги такси и каршеринга в США и нескольких других странах. Пользователи могут заказать поездку через мобильное приложение и отслеживать приближение машины.");
            Console.WriteLine("- Система D: Gett эта платформа, активная в нескольких странах, включая Россию, Израиль и Великобританию, также предоставляет услуги заказа такси через мобильное приложение.");
            Console.WriteLine("- Система G: Didi Chuxing: Крупнейшая китайская платформа такси, предоставляющая услуги по всей стране. Пользователи могут заказать такси, а также оценивать водителей и оставлять отзывы.");

            // Приведение данных о росте рынка такси за последние годы
            Console.WriteLine("Данные о росте рынка такси за последние годы:");
            Console.WriteLine("Год | Объем рынка (млн. $)");
            Console.WriteLine("2008 | 11");
            Console.WriteLine("2009 | 13");
            Console.WriteLine("2010 | 14");
            Console.WriteLine("2011 | 15");
            Console.WriteLine("2012 | 16");
            Console.WriteLine("2013 | 17");
            Console.WriteLine("2014 | 18");
            Console.WriteLine("2015 | 20");
            Console.WriteLine("2016 | 30");
            Console.WriteLine("2017 | 40");
            Console.WriteLine("2018 | 50");
            Console.WriteLine("2019 | 60");
            Console.WriteLine("2020 | 70");
            Console.WriteLine("2021 | 80");
            Console.WriteLine("2022 | 90");

            // Описание проблем, с которыми сталкиваются люди при поиске такси
            Console.WriteLine("Проблемы при поиске такси:");
            Console.WriteLine("- Долгие ожидания");
            Console.WriteLine("- Отсутствие свободных машин");
            Console.WriteLine("- Завышенные цены");
            Console.WriteLine("- Неадекватные действия водителя такси");
            Console.WriteLine("- Отсутствие машин в часы пик");
            Console.WriteLine("- Сброс заказа таксистом");

            // Преимущества использования информационных систем для отслеживания наличия такси
            Console.WriteLine("Преимущества использования информационных систем для отслеживания наличия такси:");
            Console.WriteLine("- Повышение эффективности работы служб такси");
            Console.WriteLine("- Улучшение качества обслуживания клиентов");
            Console.WriteLine("- Снижение времени ожидания такси");
            Console.WriteLine("- Увеличение прибыли служб такси");
            Console.WriteLine("- Снижение транспортных проблем в крупных городах");
            Console.ReadKey();
        }
    }
}
