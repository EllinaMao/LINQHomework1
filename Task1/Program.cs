namespace Task1
{
    internal class Program
    {/*
Для массива фирм реализуйте следующие запросы:

Получить информацию обо всех фирмах;
Получить фирмы, у которых в названии есть слово Food;
Получить фирмы, которые работают в области маркетинга;
Получить фирмы, которые работают в области маркетинга или IT;
Получить фирмы с количеством сотрудников, большем 100;
Получить фирмы с количеством сотрудников в диапазоне от 100 до 300;
Получить фирмы, которые находятся в Лондоне;
Получить фирмы, у которых фамилия директора White;
Получить фирмы, которые основаны больше двух лет назад;
Получить фирмы со дня основания, которых прошло 123 дня;
Получить фирмы, у которых фамилия директора Black и название фирмы содержит слово White.*/
        static void Main(string[] args)
        {
            
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            List<Firm> firms = new List<Firm>
                {
                    new Firm { Name = "FoodTech", FoundationDate = today.AddYears(-3), BusinessProfile = "Marketing", DirectorFullName = "John White", EmployeeCount = 150, Address = "London" },
                    new Firm { Name = "IT Solutions", FoundationDate = today.AddYears(-1), BusinessProfile = "IT", DirectorFullName = "Alice Black", EmployeeCount = 250, Address = "Manchester" },
                    new Firm { Name = "WhiteFood Inc.", FoundationDate = today.AddDays(-123), BusinessProfile = "Food", DirectorFullName = "Michael Black", EmployeeCount = 80, Address = "Bristol" },
                    new Firm { Name = "MarketPros", FoundationDate = today.AddYears(-5), BusinessProfile = "Marketing", DirectorFullName = "Sara White", EmployeeCount = 400, Address = "London" },
                    new Firm { Name = "AgroFood", FoundationDate = today.AddYears(-10), BusinessProfile = "Agriculture", DirectorFullName = "Tom Green", EmployeeCount = 120, Address = "London" }
                };
            IFoundLINQ foundLINQ = new IFoundLINQ();

            foundLINQ.GetAllFirmsInfo(firms).ToList().ForEach(f => Console.WriteLine(f.ToString()));
            Console.WriteLine("\nFirms with 'Food' in the name:");
            foundLINQ.GetByName(firms, "Food").ToList().ForEach(f => Console.WriteLine(f.ToString()));
            Console.WriteLine("\nFirms in Marketing:");
            foundLINQ.GetByBusinessProfile(firms, "Marketing").ToList().ForEach(f => Console.WriteLine(f.ToString()));
            Console.WriteLine("\nFirms in Marketing or IT:");
            foundLINQ.GetBusinessProfileByWhoParams(firms, "Marketing", "IT").ToList().ForEach(f => Console.WriteLine(f.ToString()));







        }
    }
}
