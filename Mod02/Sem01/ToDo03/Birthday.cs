using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo03
{
    class Birthday
    {
        string name; // Закрытое поле – фамилия.
        int year, month, day; // Закрытые поля: год, месяц, день рождения

        // Добавление в класс Birthday конструктор без параметров, устанавливающий
        // поля объекта класса в состояние «1 января 1970».
        public Birthday() : this("", 1970, 1, 1) { }

        public Birthday(string name, int y, int m, int d)
        {
            this.name = name;
            year = y; month = m; day = d;
        }

        // Замените методов SetName(), GetName() свойством.
        public string Name { get => name; set => name = value; }

        DateTime Date // закрытое свойство - дата рождения
        { 
            get { return new DateTime(year, month, day); }
        }
        public string Information // свойство-сведения о человеке
        { 
            get
            {
                return name + ", дата рождения " + day + ":" + month + ":" + year;
            }
        }
        public int HowManyDays // свойство - сколько дней до дня рождения
        { 
            get
            {
                // Решение проблемы високосного года (учтите верно количество дней до дня рождения).

                // номер сего дня от начала года:
                int nowDOY = DateTime.Now.DayOfYear;

                // номер дня рождения от начала года:
                int myDOY = Date.DayOfYear;

                // Текущий год.
                int year = DateTime.Now.Year;

                // Если день Рождения прошёл, то следующий будет в следующем году.
                if (nowDOY >= myDOY) year++;

                // Создание объекта DateTime с датой следующего дня Рождения.
                DateTime nextBirthday = new DateTime(year, Date.Month, Date.Day);

                // Получить разницу дней между датами и округлить в большую сторону: Math.Ceiling().
                double period = (int)Math.Ceiling((nextBirthday - DateTime.Now).TotalDays);

                return (int)period;
            }
        }

        // Добавление в класс Birthday методы, позволяющий получить информацию о дне рождения со
        // следующими форматами представления даты: DD Month YYYY, DD-MM-YY.
        public string GetDate() => new DateTime(year, month, day).ToString("dd-MM-yy");
        public string GetFullDate() => new DateTime(year, month, day).ToString("dd MMMM yyyy");

        // Добавление методов для получение текущего значения и изменения значения поля name.
        public void SetName(string value) => name = value;
        public string GetName() => name;
    }
}
