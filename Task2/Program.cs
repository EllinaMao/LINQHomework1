using System.ComponentModel.DataAnnotations;
using Task1;
namespace Task2
{/*Задание 2
Реализуйте запросы из первого задания с использованием синтаксиса методов расширений.
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);


            List<Firm> firms = new List<Firm>
                {
                    new Firm { Name = "FoodTech", FoundationDate = today.AddYears(-3), BusinessProfile = "Marketing", DirectorFullName = "John White", EmployeeCount = 150, Address = "London" },
                    new Firm { Name = "IT Solutions", FoundationDate = today.AddYears(-1), BusinessProfile = "IT", DirectorFullName = "Alice Black", EmployeeCount = 80, Address = "Manchester" },
                    new Firm { Name = "WhiteFood Inc.", FoundationDate = today.AddDays(-123), BusinessProfile = "Food", DirectorFullName = "Michael Black", EmployeeCount = 220, Address = "Bristol" },
                    new Firm { Name = "MarketPros", FoundationDate = today.AddYears(-5), BusinessProfile = "Marketing", DirectorFullName = "Sara White", EmployeeCount = 300, Address = "London" },
                    new Firm { Name = "AgroFood", FoundationDate = today.AddYears(-10), BusinessProfile = "Agriculture", DirectorFullName = "Tom Green", EmployeeCount = 120, Address = "London" }
                };
            try
            {
                firms.GetAllFirmsInfo().ToList().ForEach(f => Console.WriteLine(f.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении информации обо всех фирмах: {ex.Message}");
            }
            LINQ.ConsoleCl.ClearConsole();
            Console.WriteLine("\nФирмы, в названии которых есть 'Food':");
            try
            {
                firms.GetByName("Food").ToList().ForEach(f => Console.WriteLine(f.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении фирм по названию: {ex.Message}");
            }
            LINQ.ConsoleCl.ClearConsole();

            Console.WriteLine("\nФирмы, работающие в области маркетинга:");
            try
            {
                firms.GetByBusinessProfile("Marketing").ToList().ForEach(f => Console.WriteLine(f.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении фирм по профилю: {ex.Message}");
            }
            LINQ.ConsoleCl.ClearConsole();

            Console.WriteLine("\nФирмы, работающие в области маркетинга или IT:");
            try
            {
                firms.GetBusinessProfileByWhoParams("Marketing", "IT").ToList().ForEach(f => Console.WriteLine(f.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении фирм по нескольким профилям: {ex.Message}");
            }
            LINQ.ConsoleCl.ClearConsole();

            Console.WriteLine("\nФирмы с количеством сотрудников больше 100:");
            try
            {
                firms.GetByEmployeeCount(100).ToList().ForEach(f => Console.WriteLine(f.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении фирм по количеству сотрудников: {ex.Message}");
            }
            LINQ.ConsoleCl.ClearConsole();

            Console.WriteLine("\nФирмы с количеством сотрудников от 100 до 300:");
            try
            {
                firms.GetByEmployeeCountRange(100, 300).ToList().ForEach(f => Console.WriteLine(f.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении фирм по диапазону сотрудников: {ex.Message}");
            }
            LINQ.ConsoleCl.ClearConsole();

            Console.WriteLine("\nФирмы, находящиеся в Лондоне:");
            try
            {
                firms.GetByAddress("London").ToList().ForEach(f => Console.WriteLine(f.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении фирм по адресу: {ex.Message}");
            }
            LINQ.ConsoleCl.ClearConsole();

            Console.WriteLine("\nФирмы, у которых фамилия директора 'White':");
            try
            {
                firms.GetByDirectorLastName("White").ToList().ForEach(f => Console.WriteLine(f.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении фирм по фамилии директора: {ex.Message}");
            }
            LINQ.ConsoleCl.ClearConsole();

            Console.WriteLine("\nФирмы, основанные более 2 лет назад:");
            try
            {   
                firms.GetFirmsFoundedBy(2).ToList().ForEach(f => Console.WriteLine(f.ToString()));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении фирм по сроку основания: {ex.Message}");
            }
            LINQ.ConsoleCl.ClearConsole();

            Console.WriteLine("\nФирмы, основанные 123 дня назад:");
            try
            {
                firms.GetFirmsFoundedDaysAgo(123).ToList().ForEach(f => Console.WriteLine(f.ToString()));
            }       
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении фирм по дням основания: {ex.Message}");
            }
        }
    }
}
