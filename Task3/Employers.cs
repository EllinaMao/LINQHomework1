using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{/*Задание 3
Добавьте к первому заданию класс, содержащий информацию о сотрудниках. Нужно хранить такие данные:

ФИО сотрудника;
Должность;
Контактный телефон;
Email;
Заработная плата.
Добавьте информацию о сотрудниках внутрь фирмы.

Для массива сотрудников фирмы реализуйте следующие запросы:

Получить всех сотрудников конкретной фирмы;
Получить всех сотрудников конкретной фирмы, у которых заработные пла­ты больше заданной;
Получить сотрудников всех фирм, у которых должность менеджер;
Получить сотрудников, у которых телефон начинается с 23;
Получить сотрудников, у которых Email начинается с di;
Получить сотрудников, у которых имя Lionel.
*/
    public class Employers:IEmploye
    {
        public string FullName { get; set; }
        public string Position { get; set; }
        public string ContactPhone { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
        public Employers()
        {
            FullName = "Unknown";
            Position = "Unknown";
            ContactPhone = "Unknown";
            Email = "Unknown";
            Salary = 0.0m;
        }
        public Employers(string fullName, string position, string contactPhone, string email, decimal salary)
        {
            FullName = fullName;
            Position = position;
            ContactPhone = contactPhone;
            Email = email;
            Salary = salary;
        }
        public Employers(string fullName, string position, string contactPhone, string email, double salary)
        {
            FullName = fullName;
            Position = position;
            ContactPhone = contactPhone;
            Email = email;
            Salary = Convert.ToDecimal(salary);
        }
        public Employers(Employers empl)
        {
            FullName = empl.FullName;
            Position = empl.Position;
            ContactPhone = empl.ContactPhone;
            Email = empl.Email;
            Salary = empl.Salary;
        }
        public override string ToString()
        {
            return $"ФИО: {FullName}\nДолжность: {Position}\nТелефон: {ContactPhone}\nEmail: {Email}\nЗарплата: {Salary:F2}";
        }

    }
}
