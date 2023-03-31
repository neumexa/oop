
using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Создание_и_использование_классов
{
    internal class Book : Item
    {
        private string author; // автор
        private string title; // название
        private string publisher; // издательство
        private int pages; // кол-во страниц
        private int year; // год издания
        private static double price = 9;
        private bool returnSrok;
        public void SetBook(String author, string title, string publisher, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }
        public static void SetPrice(double price)
        {
            Book.price = price;
        }
        public double PriceBook(int s)
        {
            double cust = s * price;
            return cust;
        }
         public override void Show()
        {
            Console.WriteLine($"\nКнига:\n Автор: {author}\n Название: {title} \n Год издания: { year}\n { pages} стр.\n Стоимость аренды: { Book.price} p.в сутки", author, title, year, pages, Book.price);
            base.Show();
        }

        public Book(string author, string title, string publisher, int pages, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.author = author;
            this.title = title;
            this.publisher = publisher;
            this.pages = pages;
            this.year = year;
        }

        public Book()
        {
        }
        public void ReturnSrok()
        {
            returnSrok = true;
        }
        public override void Return() // операция "вернуть"
        {
            if (returnSrok == true) taken = true;
            else taken = false;
        }

    }
}
