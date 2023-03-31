using System;
using ConsoleApp5;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Создание_и_использование_классов;

namespace ConsoleApp5
{
    abstract class Item
    {
        protected long invNumber; // инвентарный номер – целое число
        protected bool taken; // хранит состояние объекта – имеется в библиотеке или нет, то есть взят на руки

        public bool IsAvailable() // истина, если предмет имеется в библиотеке
        {
            if (taken == true) return true; else return false;
        }
        public long GetInvNumber() // инвентарный номер
        {
            return invNumber;
        }
         public void Take() // операция "взять"
        {
            taken = false;
        }
        abstract public void Return();  // операция "вернуть"

        public virtual void Show()
        {
            Console.WriteLine($"Состояние единицы хранения:\n Инвентарныйномер: {invNumber}\n Наличие: {taken} ", invNumber, taken);
        }
        public Item(long invNumber, bool taken)
        {
            this.invNumber = invNumber;
            this.taken = taken;
        }
        public Item()
        {
            this.taken = true;
        }
        public void TakeItem()
        {
            if (this.IsAvailable()) this.Take();
        }


    }
}
