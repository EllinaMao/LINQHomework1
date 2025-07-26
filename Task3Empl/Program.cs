using Task1;
using Task3;

namespace Task3Empl
{
    internal class Program
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
        static void Main(string[] args)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);

            List<Firm> firms = new List<Firm>
{
    new Firm
    {
        Name = "FoodTech",
        FoundationDate = today.AddYears(-3),
        BusinessProfile = "Marketing",
        DirectorFullName = "John White",
        Address = "London",
        Employers = new List<Employers>
        {
            new Employers { FullName = "Lionel Smith", Position = "Manager", ContactPhone = "1234567890", Email = "lionel.smith@foodtech.com", Salary = 70000 },
            new Employers { FullName = "Alice Johnson", Position = "Developer", ContactPhone = "2345678901", Email = "diice.johnson@foodtech.com", Salary = 60000 },
            new Employers { FullName = "Michael Brown", Position = "Designer", ContactPhone = "3456789012", Email = "michael.brown@foodtech.com", Salary = 75000 },
            new Employers { FullName = "Sarah Connor", Position = "QA Engineer", ContactPhone = "4567890123", Email = "sarah.connor@foodtech.com", Salary = 50000 },
            new Employers { FullName = "David Black", Position = "Analyst", ContactPhone = "5678901234", Email = "david.black@foodtech.com", Salary = 55000 }
        }
    },
    new Firm
    {
        Name = "IT Solutions",
        FoundationDate = today.AddYears(-1),
        BusinessProfile = "IT",
        DirectorFullName = "Alice Black",
        Address = "Manchester",
        Employers = new List<Employers>
        {
            new Employers { FullName = "Lionel Messi", Position = "Manager", ContactPhone = "2376543210", Email = "lionel.messi@itsolutions.com", Salary = 70000 },
            new Employers { FullName = "Emma Black", Position = "QA Engineer", ContactPhone = "2398765432", Email = "dimma.black@itsolutions.com", Salary = 48000 },
            new Employers { FullName = "David White", Position = "IT Specialist", ContactPhone = "2312345678", Email = "david.white@itsolutions.com", Salary = 65000 },
            new Employers { FullName = "Olivia Green", Position = "Support", ContactPhone = "1231231234", Email = "olivia.green@itsolutions.com", Salary = 52000 },
            new Employers { FullName = "Mark Taylor", Position = "DevOps", ContactPhone = "3213213210", Email = "diark.taylor@itsolutions.com", Salary = 64000 }
        }
    },
    new Firm
    {
        Name = "WhiteFood Inc.",
        FoundationDate = today.AddDays(-123),
        BusinessProfile = "Food",
        DirectorFullName = "Michael Black",
        Address = "Bristol",
        Employers = new List<Employers>
        {
            new Employers { FullName = "Lionel Cooper", Position = "Logistics Manager", ContactPhone = "6543210987", Email = "lionel.cooper@whitefood.com", Salary = 69000 },
            new Employers { FullName = "Natalie Portman", Position = "Designer", ContactPhone = "4564564560", Email = "natalie.portman@whitefood.com", Salary = 60000 },
            new Employers { FullName = "James Bond", Position = "Security", ContactPhone = "0070070007", Email = "james.bond@whitefood.com", Salary = 72000 },
            new Employers { FullName = "Lara Croft", Position = "Marketing", ContactPhone = "5556667777", Email = "lara.croft@whitefood.com", Salary = 58000 },
            new Employers { FullName = "Chris Evans", Position = "Technologist", ContactPhone = "8889990000", Email = "chris.evans@whitefood.com", Salary = 62000 }
        }
    },
    new Firm
    {
        Name = "MarketPros",
        FoundationDate = today.AddYears(-5),
        BusinessProfile = "Marketing",
        DirectorFullName = "Sara White",
        Address = "London",
        Employers = new List<Employers>
        {
            new Employers { FullName = "Lionel Davis", Position = "Brand Manager", ContactPhone = "2223334444", Email = "lionel.davis@marketpros.com", Salary = 71000 },
            new Employers { FullName = "Emily Stone", Position = "Content Creator", ContactPhone = "9998887777", Email = "emily.stone@marketpros.com", Salary = 53000 },
            new Employers { FullName = "Tom Hardy", Position = "SMM Specialist", ContactPhone = "4445556666", Email = "tom.hardy@marketpros.com", Salary = 49000 },
            new Employers { FullName = "Anna Bell", Position = "SEO Expert", ContactPhone = "1112223333", Email = "anna.bell@marketpros.com", Salary = 62000 },
            new Employers { FullName = "Robert Gray", Position = "PR Manager", ContactPhone = "3334445555", Email = "robert.gray@marketpros.com", Salary = 68000 }
        }
    },
    new Firm
    {
        Name = "AgroFood",
        FoundationDate = today.AddYears(-10),
        BusinessProfile = "Agriculture",
        DirectorFullName = "Tom Green",
        Address = "London",
        Employers = new List<Employers>
        {
            new Employers { FullName = "Lionel Grant", Position = "Farm Supervisor", ContactPhone = "1212121212", Email = "lionel.grant@agrofood.com", Salary = 64000 },
            new Employers { FullName = "Jessica Alba", Position = "Crop Analyst", ContactPhone = "3434343434", Email = "jessica.alba@agrofood.com", Salary = 61000 },
            new Employers { FullName = "Dwayne Johnson", Position = "Equipment Manager", ContactPhone = "5656565656", Email = "dwayne.johnson@agrofood.com", Salary = 67000 },
            new Employers { FullName = "Megan Fox", Position = "Soil Researcher", ContactPhone = "7878787878", Email = "megan.fox@agrofood.com", Salary = 63000 },
            new Employers { FullName = "Clark Kent", Position = "Engineer", ContactPhone = "9090909090", Email = "clark.kent@agrofood.com", Salary = 69000 }
        }
    }
};


            firms.AllEmployers().ToList().ForEach(e => Console.WriteLine(e.ToString()));
            LINQ.ConsoleCl.ClearConsole();
            Console.WriteLine("\nВсе сотрудники фирмы FoodTech:");
            try
            {
                firms.GetAllEmployersByFirm("FoodTech").ToList().ForEach(e => Console.WriteLine(e.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении сотрудников фирмы FoodTech: {ex.Message}");
            }
            LINQ.ConsoleCl.ClearConsole();
            Console.WriteLine("\nСотрудники фирмы IT Solutions с зарплатой больше 60000:");
            try
            {
                firms.GetEmployersByFirmAndSalary("IT Solutions", 60000).ToList().ForEach(e => Console.WriteLine(e.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении сотрудников фирмы IT Solutions с зарплатой больше 60000: {ex.Message}");
            }
            LINQ.ConsoleCl.ClearConsole();
            Console.WriteLine("\nСотрудники всех фирм с должностью 'Manager':");
            try
            {
                firms.GetEmployersByPosition("Manager").ToList().ForEach(e => Console.WriteLine(e.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении сотрудников с должностью 'Manager': {ex.Message}");
            }
            LINQ.ConsoleCl.ClearConsole();
            Console.WriteLine("\nСотрудники, у которых телефон начинается с 23:");
            try
            {
                firms.GetEmployersByPhonePrefix("23").ToList().ForEach(e => Console.WriteLine(e.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении сотрудников с телефоном, начинающимся на 23: {ex.Message}");
            }
            LINQ.ConsoleCl.ClearConsole();
            Console.WriteLine("\nСотрудники, у которых Email начинается с 'di':");
            try
            {
                firms.GetEmployersByEmailPrefix("di").ToList().ForEach(e => Console.WriteLine(e.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении сотрудников с Email, начинающимся на 'di': {ex.Message}");
            }
            LINQ.ConsoleCl.ClearConsole();
            Console.WriteLine("\nСотрудники, у которых имя Lionel:");
            try
            {
                firms.GetEmployersByName("Lionel").ToList().ForEach(e => Console.WriteLine(e.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении сотрудников с именем Lionel: {ex.Message}");
            }


        }
    }
}
