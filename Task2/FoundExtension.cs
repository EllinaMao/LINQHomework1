using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
namespace Task2
{
    internal static class FoundExtension 
    {
        public static IEnumerable<Firm> GetAllFirmsInfo(this List<Firm> firms)
        {
            if (firms == null) { throw new ArgumentNullException(nameof(firms)); }
            return firms.Where(firm => firm != null).Select(firm => firm);
        }

        public static IEnumerable<Firm> GetBusinessProfileByWhoParams(this List<Firm> firms, string businessProfile1, string businessProfile2)
        {
            if (firms == null) { throw new ArgumentNullException(nameof(firms)); }
            if (businessProfile1 == null) { throw new ArgumentNullException(nameof(businessProfile1)); }
            if (businessProfile2 == null) { throw new ArgumentNullException(nameof(businessProfile2)); }
            return firms.Where(firm => firm != null &&
                (firm.BusinessProfile.Contains(businessProfile1, StringComparison.OrdinalIgnoreCase) ||
                 firm.BusinessProfile.Contains(businessProfile2, StringComparison.OrdinalIgnoreCase)));
        }

        public static IEnumerable<Firm> GetByAddress(this List<Firm> firms, string address)
        {
            if (firms == null) { throw new ArgumentNullException(nameof(firms)); }
            if (address == null) { throw new ArgumentNullException(nameof(address)); }
            return firms.Where(firm => firm != null && firm.Address.Equals(address, StringComparison.OrdinalIgnoreCase));
        }

        public static IEnumerable<Firm> GetByBusinessProfile(this List<Firm> firms, string businessProfile)
        {
            if (firms == null) { throw new ArgumentNullException(nameof(firms)); }
            if (businessProfile == null) { throw new ArgumentNullException(nameof(businessProfile)); }
            return firms.Where(firm => firm != null &&
                (firm.BusinessProfile.Contains(businessProfile, StringComparison.OrdinalIgnoreCase)));
        }

        public static IEnumerable<Firm> GetByDirectorLastName(this List<Firm> firms, string lastName)
        {
            if (firms == null) { throw new ArgumentNullException(nameof(firms)); }
            if (lastName == null) { throw new ArgumentNullException(nameof(lastName)); }
            return firms.Where(firm => firm != null &&
                firm.DirectorFullName.Split(' ').Last().Equals(lastName, StringComparison.OrdinalIgnoreCase));
        }

        public static IEnumerable<Firm> GetByDirectorLastNameAndFirmName(this List<Firm> firms, string lastName, string keyword)
        {
            if (firms == null) { throw new ArgumentNullException(nameof(firms)); }
            if (lastName == null) { throw new ArgumentNullException(nameof(lastName)); }
            if (keyword == null) { throw new ArgumentNullException(nameof(keyword)); }
            return firms.Where(firm => firm != null &&
                firm.DirectorFullName.Split(' ').Last().Equals(lastName, StringComparison.OrdinalIgnoreCase) &&
                firm.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase));
        }

        public static IEnumerable<Firm> GetByEmployeeCount(this List<Firm> firms, int minCount)
        {
            if (firms == null) { throw new ArgumentNullException(nameof(firms)); }
            return firms.Where(firm => firm != null && firm.EmployeeCount > minCount);
        }

        public static IEnumerable<Firm> GetByEmployeeCountRange(this List<Firm> firms, int minCount, int maxCount)
        {
            if (firms == null) { throw new ArgumentNullException(nameof(firms)); }
            return firms.Where(firm => firm != null && firm.EmployeeCount >= minCount && firm.EmployeeCount <= maxCount);
        }

        public static IEnumerable<Firm> GetByName(this List<Firm> firms, string keyword)
        {
            if (firms == null) { throw new ArgumentNullException(nameof(firms)); }
            if (keyword == null) { throw new ArgumentNullException(nameof(keyword)); }
            return firms.Where(firm => firm != null && firm.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase));
        }

        public static IEnumerable<Firm> GetFirmsFoundedBy(this List<Firm> firms, int year)
        {
            if (firms == null) { throw new ArgumentNullException(nameof(firms)); }
            var yearsAgo = DateOnly.FromDateTime(DateTime.Now).AddYears(-year);
            return firms.Where(firm => firm != null && firm.FoundationDate < yearsAgo);
        }

        public static IEnumerable<Firm> GetFirmsFoundedDaysAgo(this List<Firm> firms, int days)
        {
            if (firms == null) { throw new ArgumentNullException(nameof(firms)); }
            var daysAgo = DateOnly.FromDateTime(DateTime.Now).AddDays(-days);
            return firms.Where(firm => firm != null && firm.FoundationDate == daysAgo);
        }
    }
}
