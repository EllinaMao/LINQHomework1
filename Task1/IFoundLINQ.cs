using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FoundLINQ : IFound
    {
        //Получить информацию обо всех фирмах;
        public IEnumerable<Firm> GetAllFirmsInfo(List<Firm> firms)
        {
            if (firms == null)
            {
                throw new ArgumentNullException(nameof(firms));
            }
            var res = from firm in firms
                      select firm;
            return res;
        }
        //Получить фирмы, у которых в названии есть слово Food;
        public IEnumerable<Firm> GetByName(List<Firm> firms, string keyword)
        {
            if (firms == null)
            {
                throw new ArgumentNullException(nameof(firms));
            }
            if (keyword == null)
            {
                throw new ArgumentNullException(nameof(keyword));
            }
            var res = from firm in firms
                      where firm.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                      select firm;
            return res;
        }
        //Получить фирмы, которые работают в области маркетинга;
        public IEnumerable<Firm> GetByBusinessProfile(List<Firm> firms, string businessProfile)
        {
            if (firms == null)
            {
                throw new ArgumentNullException(nameof(firms));
            }
            if (businessProfile == null)
            {
                throw new ArgumentNullException(nameof(businessProfile));
            }
            var res = from firm in firms
                      where firm.BusinessProfile.Contains(businessProfile, StringComparison.OrdinalIgnoreCase)
                      select firm;
            return res;
        }
        //Получить фирмы, которые работают в области маркетинга или IT;
        public IEnumerable<Firm> GetBusinessProfileByWhoParams(List<Firm> firms, string businessProfile1, string businessProfile2)
        {
            if (firms == null)
            {
                throw new ArgumentNullException(nameof(firms));
            }
            if (businessProfile1 == null)
            {
                throw new ArgumentNullException(nameof(businessProfile1));
            }
            if (businessProfile2 == null)
            {
                throw new ArgumentNullException(nameof(businessProfile2));
            }
            var res = from firm in firms
                      where firm.BusinessProfile.Contains(businessProfile1, StringComparison.OrdinalIgnoreCase) ||
                            firm.BusinessProfile.Contains(businessProfile2, StringComparison.OrdinalIgnoreCase)
                      select firm;
            return res;
        }
        //Получить фирмы с количеством сотрудников, большем 100;
        public IEnumerable<Firm> GetByEmployeeCount(List<Firm> firms, int minCount)
        {
            if (firms == null)
            {
                throw new ArgumentNullException(nameof(firms));
            }
            var res = from firm in firms
                      where firm.EmployeeCount > minCount
                      select firm;
            return res;
        }
        //Получить фирмы с количеством сотрудников в диапазоне от 100 до 300;
        public IEnumerable<Firm> GetByEmployeeCountRange(List<Firm> firms, int minCount, int maxCount)
        {
            if (firms == null)
            {
                throw new ArgumentNullException(nameof(firms));
            }
            var res = from firm in firms
                      where firm.EmployeeCount >= minCount && firm.EmployeeCount <= maxCount
                      select firm;
            return res;
        }
        //Получить фирмы, которые находятся в Лондоне;
        public IEnumerable<Firm> GetByAddress(List<Firm> firms, string address)
        {
            if (firms == null)
            {
                throw new ArgumentNullException(nameof(firms));
            }
            if (address == null)
            {
                throw new ArgumentNullException(nameof(address));
            }
            var res = from firm in firms
                      where firm.Address.Contains(address, StringComparison.OrdinalIgnoreCase)
                      select firm;
            return res;
        }
        //Получить фирмы, у которых фамилия директора White;
        public IEnumerable<Firm> GetByDirectorLastName(List<Firm> firms, string lastName)
        {
            if (firms == null)
            {
                throw new ArgumentNullException(nameof(firms));
            }
            if (lastName == null)
            {
                throw new ArgumentNullException(nameof(lastName));
            }
            var res = from firm in firms
                      where firm.DirectorFullName.Split(' ').Last().Equals(lastName, StringComparison.OrdinalIgnoreCase)
                      select firm;
            return res;
        }
        //Получить фирмы, у которых фамилия директора Black и название фирмы содержит слово White
        public IEnumerable<Firm> GetByDirectorLastNameAndFirmName(List<Firm> firms, string lastName, string keyword)
        {
            if (firms == null)
            {
                throw new ArgumentNullException(nameof(firms));
            }
            if (lastName == null)
            {
                throw new ArgumentNullException(nameof(lastName));
            }
            if (keyword == null)
            {
                throw new ArgumentNullException(nameof(keyword));
            }
            var res = from firm in firms
                      where firm.DirectorFullName.Split(' ').Last().Equals(lastName, StringComparison.OrdinalIgnoreCase)
                      where firm.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase)
                      select firm;
            return res;
        }
        //Получить фирмы, которые основаны больше двух лет назад;
        public IEnumerable<Firm> GetFirmsFoundedBy(List<Firm> firms, int year)
        {
            if (firms == null)
            {
                throw new ArgumentNullException(nameof(firms));
            }
            var yearsAgo = DateOnly.FromDateTime(DateTime.Now).AddYears(-year);
            var res = from firm in firms
                      where firm.FoundationDate < yearsAgo
                      select firm;
            return res;
        }
        //Получить фирмы со дня основания, которых прошло 123 дня;
        public IEnumerable<Firm> GetFirmsFoundedDaysAgo(List<Firm> firms, int days)
        {
            if (firms == null)
            {
                throw new ArgumentNullException(nameof(firms));
            }
            var daysAgo = DateOnly.FromDateTime(DateTime.Now).AddDays(-days);
            var res = from firm in firms
                      where firm.FoundationDate == daysAgo
                      select firm;
            return res;
        }
    }
}
