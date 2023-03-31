
using ConsoleApp5;
using Mag;
using System;
using Создание_и_использование_классов;

namespace Zadanie1
{
    class pr1
    {
        static void Main()
        {
            Book b1 = new Book();
       

            b1.SetBook("Пушкин А.С.", "Капитанская дочка", "Вильямс", 123, 2012);
            Book.SetPrice(12);
            b1.Show();
            Console.WriteLine($"\n Итоговая стоимость аренды: {b1.PriceBook(3)} p.", b1.PriceBook(3));

            Book b2 = new Book("Толстой Л.Н.", "Война и мир", "Наука и жизнь", 1234, 2013, 101, true);
            b2.TakeItem();
            b2.Show();

            Magazine mag1 = new Magazine("О природе", 5, "Земля и мы", 2014, 1235, true);
            mag1.Show();

            Console.WriteLine("\nТестирование полиморфизма");
            Item it;
            it = b2;
            it.TakeItem();
            it.Return();
            it.Show();
            it = mag1;
            it.TakeItem();
            it.Return();
            it.Show(); 


            Console.ReadLine();
        }

    }
}