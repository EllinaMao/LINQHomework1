using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public interface IFound
    {
        //Получить информацию обо всех фирмах;
        public IEnumerable<Firm> GetAllFirmsInfo(List<Firm> firms);

        //Получить фирмы, у которых в названии есть слово Food;
        public IEnumerable<Firm> GetByName(List<Firm> firms, string keyword);

        //Получить фирмы, которые работают в области маркетинга;
        public IEnumerable<Firm> GetByBusinessProfile(List<Firm> firms, string businessProfile);

        //Получить фирмы, которые работают в области маркетинга или IT;
        public IEnumerable<Firm> GetBusinessProfileByWhoParams(List<Firm> firms, string businessProfile1, string businessProfile2);

        //Получить фирмы с количеством сотрудников, большем 100;
        public IEnumerable<Firm> GetByEmployeeCount(List<Firm> firms, int minCount);

        //Получить фирмы с количеством сотрудников в диапазоне от 100 до 300;
        public IEnumerable<Firm> GetByEmployeeCountRange(List<Firm> firms, int minCount, int maxCount);

        //Получить фирмы, которые находятся в Лондоне;
        public IEnumerable<Firm> GetByAddress(List<Firm> firms, string address);

        //Получить фирмы, у которых фамилия директора White;
        public IEnumerable<Firm> GetByDirectorLastName(List<Firm> firms, string lastName);

        //Получить фирмы, у которых фамилия директора Black и название фирмы содержит слово White
        public IEnumerable<Firm> GetByDirectorLastNameAndFirmName(List<Firm> firms, string lastName, string keyword);

        //Получить фирмы, которые основаны больше двух лет назад;
        public IEnumerable<Firm> GetFirmsFoundedBy(List<Firm> firms, int year);

        //Получить фирмы со дня основания, которых прошло 123 дня;
        public IEnumerable<Firm> GetFirmsFoundedDaysAgo(List<Firm> firms, int days);
    }
}