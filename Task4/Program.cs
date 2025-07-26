namespace Task4
{
    internal class Program
    {/*
Задание 4
Для массива целых реализуйте пользовательскую сортировку. Сортировка должна работать по сумме цифр числа (по возрастанию и убыванию). Например, если сортировка производится по убыванию, нужно вернуть числа с максимальной суммой в порядке убывания суммы. Например, если массив содержит 121, 75, 81, после сортировки по убыванию мы получим 75, 81, 121.

Такой результат, потому что (7+5 = 12, 8+1 = 9, 1+2+1 = 4).*/
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 121, 75, 81 };

            var sortedAscending = numbers.ToArray().SortBy(Сalculate.GetDigitSum);
            Console.WriteLine("Сортировка по возрастанию суммы цифр:");
            Console.WriteLine(string.Join(", ", sortedAscending));

            var sortedDescending = numbers.ToArray().SortBy(Сalculate.GetDigitSum, false);
            Console.WriteLine("Сортировка по убыванию суммы цифр:");
            Console.WriteLine(string.Join(", ", sortedDescending));
        }
    }
}
