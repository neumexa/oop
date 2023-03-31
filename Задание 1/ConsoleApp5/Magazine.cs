using System;
using ConsoleApp5;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mag
{
    class Magazine : Item
    {
        private string volume; // том
        private int number; // номер
        private string title; // название
        private int year; // год выпуска
        public Magazine()
        { }
        public Magazine(string volume, int number, string title, int year, long invNumber, bool taken) : base(invNumber, taken)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }
         public override void Show()
        {
            Console.WriteLine($"\nЖурнал:\n Том: {volume}\n Номер: {number}\n Название: { title}\n Год выпуска: { year}", volume, number, title, year);
            base.Show();
        }
        public override void Return() // операция "вернуть"
        {
            taken = true;
        }


    }

}
