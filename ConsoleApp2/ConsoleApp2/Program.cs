using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Tickets
    {
        private string hotellclass;
        private string country;
        private double price;
        private string pitanie;
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string HotellClass
        {
            get { return hotellclass; }
            set { hotellclass = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Pitanie
        {
            get { return pitanie; }
            set { pitanie = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Tickets p1 = new Tickets();
            p1.Country = "Египет";
            p1.Type = "Экскурсия";
            p1.Price = 3000;
            p1.HotellClass = "3 звезды";
            p1.Pitanie = "Все включено";

            Tickets p2 = new Tickets();
            p2.Country = "Куба";
            p2.Type = "Отдых";
            p2.Price = 10000;
            p2.HotellClass = "5 звезд";
            p2.Pitanie = "Все включено";

            Tickets p3 = new Tickets();
            p3.Country = "Греция";
            p3.Type = "Шопинг";
            p3.Price = 500;
            p3.HotellClass = "2 звезды";
            p3.Pitanie = "Все включено";

            Console.WriteLine("Выберите действие");
            Console.WriteLine("1 - Посмотреть все путевки.");
            Console.WriteLine("2 - Выбор путевки по цене.");
            int k = int.Parse(Console.ReadLine());
            if (k == 1)
            {
                Console.WriteLine("*************** TICKETS ****************");
                Console.WriteLine("************* Ticket № 1 **************");
                Console.WriteLine("");
                Console.WriteLine($"Страна:          {p1.Country}");
                Console.WriteLine($"Класс отеля:     {p1.HotellClass}");
                Console.WriteLine($"Питание:         {p1.Pitanie}");
                Console.WriteLine($"Цена:            {p1.Price} $");
                Console.WriteLine($"Тип поездки:     {p1.Type}");
                Console.WriteLine("");
                Console.WriteLine("************* Ticket № 2 **************");
                Console.WriteLine("");
                Console.WriteLine($"Страна:          {p2.Country}");
                Console.WriteLine($"Класс отеля:     {p2.HotellClass}");
                Console.WriteLine($"Питание:         {p2.Pitanie}");
                Console.WriteLine($"Цена:            {p2.Price} $");
                Console.WriteLine($"Тип поездки:     {p2.Type}");
                Console.WriteLine("");
                Console.WriteLine("************* Ticket № 3 **************");
                Console.WriteLine("");
                Console.WriteLine($"Страна:          {p3.Country}");
                Console.WriteLine($"Класс отеля:     {p3.HotellClass}");
                Console.WriteLine($"Питание:         {p3.Pitanie}");
                Console.WriteLine($"Цена:            {p3.Price} $");
                Console.WriteLine($"Тип поездки:     {p3.Type}");
                Console.ReadKey();
            }
            if (k == 2)
            {
                Console.WriteLine("Введите макс. стоимость путевки в $");
                double stoimosty = double.Parse(Console.ReadLine());
                if (stoimosty < 3000)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Страна:          {p3.Country}");
                    Console.WriteLine($"Класс отеля:     {p3.HotellClass}");
                    Console.WriteLine($"Питание:         {p3.Pitanie}");
                    Console.WriteLine($"Цена:            {p3.Price} $");
                    Console.WriteLine($"Тип поездки:     {p3.Type}");
                    Console.ReadKey();
                }
                else if (stoimosty > 3000)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Страна:          {p2.Country}");
                    Console.WriteLine($"Класс отеля:     {p2.HotellClass}");
                    Console.WriteLine($"Питание:         {p2.Pitanie}");
                    Console.WriteLine($"Цена:            {p2.Price} $");
                    Console.WriteLine($"Тип поездки:     {p2.Type}");
                    Console.ReadKey();
                }
                else 
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Страна:          {p1.Country}");
                    Console.WriteLine($"Класс отеля:     {p1.HotellClass}");
                    Console.WriteLine($"Питание:         {p1.Pitanie}");
                    Console.WriteLine($"Цена:            {p1.Price} $");
                    Console.WriteLine($"Тип поездки:     {p1.Type}");
                    Console.ReadKey();
                }
            }
        }


    }
}
