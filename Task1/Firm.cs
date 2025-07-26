using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;    
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
        public List<Employers>? Employers { get; set; }
        public int EmployeeCount { get; set; }
        public string Address { get; set; }

        public Firm() 
        { 
            Name = string.Empty;
            FoundationDate = DateOnly.MinValue;
            BusinessProfile = string.Empty;
            DirectorFullName = string.Empty;
            Employers = new List<Employers>();
            EmployeeCount = 0;
            Address = string.Empty;
        }
        public Firm(string name, DateOnly foundationDate, string businessProfile, string directorFullName, List<Employers> empls, string address)
        {
            Name = name;
            FoundationDate = foundationDate;
            BusinessProfile = businessProfile;
            DirectorFullName = directorFullName;
            Employers = empls;
            EmployeeCount = Employers.Count;
            Address = address;
        }
        public Firm(string name, DateOnly foundationDate, string businessProfile, string directorFullName, int count, string address)//for task1 and 2
        {
            Name = name;
            FoundationDate = foundationDate;
            BusinessProfile = businessProfile;
            DirectorFullName = directorFullName;
            Employers = null;
            EmployeeCount = count;
            Address = address;
        }
        public void AddEmployers(Employers employer)
        {
            if (employer == null)
            {
                throw new ArgumentNullException(nameof(employer), "Employer cannot be null");
            }
            if (Employers == null)
            {
                Employers = new List<Employers> { employer };
                EmployeeCount = Employers.Count;
                return;
            }

            Employers.Add(employer);
            EmployeeCount = Employers.Count;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Name: {Name}, Foundation Date: {FoundationDate}, Business Profile: {BusinessProfile}, Director: {DirectorFullName}, Address: {Address}");

            if (Employers != null && Employers.Count > 0)
            {
                string employeesStr = string.Join("; ", Employers.Select(e => e.ToString()));
                sb.Append($"\nEmployees: [{employeesStr}], {EmployeeCount}");
            }
            else
            {
                sb.Append($"\nКоличество сотрудников: {EmployeeCount}");
            }

            return sb.ToString();
        }


    }
}
