using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{/*Задание 1
Реализуйте пользовательский тип Фирма. В нём должна быть информация о названии фирмы, дате основания, профиле бизнеса (маркетинг, IT, и т.д.), ФИО директора, количество сотрудников, адрес.
*/   
    public class Firm:IFirm
    {
        public string Name { get; set; }
        public DateOnly FoundationDate { get; set; }
        public string BusinessProfile { get; set; }
        public string DirectorFullName { get; set; }
        public int EmployeeCount { get; set; }
        public string Address { get; set; }

        public Firm() 
        { 
            Name = string.Empty;
            FoundationDate = DateOnly.MinValue;
            BusinessProfile = string.Empty;
            DirectorFullName = string.Empty;
            EmployeeCount = 0;
            Address = string.Empty;
        }
        public Firm(string name, DateOnly foundationDate, string businessProfile, string directorFullName, int employeeCount, string address)
        {
            Name = name;
            FoundationDate = foundationDate;
            BusinessProfile = businessProfile;
            DirectorFullName = directorFullName;
            EmployeeCount = employeeCount;
            Address = address;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Foundation Date: {FoundationDate}, Business Profile: {BusinessProfile}, Director: {DirectorFullName}, Employees: {EmployeeCount}, Address: {Address}";
        }


    }
}
