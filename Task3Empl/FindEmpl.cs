using System;
using System.Collections.Generic;
using System.Linq;
using Task1;

namespace Task3
{
    public static class FindEmpl
    {
        public static IEnumerable<Employers> AllEmployers(this IEnumerable<Firm> firms)
        {
            if (firms == null) throw new ArgumentNullException(nameof(firms));

            return firms.SelectMany(f => f.Employers ?? Enumerable.Empty<Employers>());
        }

        public static IEnumerable<Employers> GetAllEmployersByFirm(this IEnumerable<Firm> firms, string firmName)
        {
            if (firms == null) throw new ArgumentNullException(nameof(firms));
            if (string.IsNullOrWhiteSpace(firmName)) throw new ArgumentNullException(nameof(firmName));

            return firms
                .Where(f => f.Name.Equals(firmName, StringComparison.OrdinalIgnoreCase))
                .SelectMany(f => f.Employers ?? Enumerable.Empty<Employers>());
        }

        public static IEnumerable<Employers> GetEmployersByFirmAndSalary(this IEnumerable<Firm> firms, string firmName, decimal threshold)
        {
            if (firms == null) throw new ArgumentNullException(nameof(firms));
            if (string.IsNullOrWhiteSpace(firmName)) throw new ArgumentNullException(nameof(firmName));

            return firms
                .Where(f => f.Name.Equals(firmName, StringComparison.OrdinalIgnoreCase))
                .SelectMany(f => f.Employers ?? Enumerable.Empty<Employers>())
                .Where(e => e.Salary > threshold);
        }

        public static IEnumerable<Employers> GetEmployersByPosition(this IEnumerable<Firm> firms, string position)
        {
            if (firms == null) throw new ArgumentNullException(nameof(firms));
            if (string.IsNullOrWhiteSpace(position)) throw new ArgumentNullException(nameof(position));

            return firms
                .SelectMany(f => f.Employers ?? Enumerable.Empty<Employers>())
                .Where(e => e.Position.Equals(position, StringComparison.OrdinalIgnoreCase));
        }

        public static IEnumerable<Employers> GetEmployersByPhonePrefix(this IEnumerable<Firm> firms, string prefix)
        {
            if (firms == null) throw new ArgumentNullException(nameof(firms));
            if (string.IsNullOrWhiteSpace(prefix)) throw new ArgumentNullException(nameof(prefix));

            return firms
                .SelectMany(f => f.Employers ?? Enumerable.Empty<Employers>())
                .Where(e => e.ContactPhone.StartsWith(prefix));
        }

        public static IEnumerable<Employers> GetEmployersByEmailPrefix(this IEnumerable<Firm> firms, string prefix)
        {
            if (firms == null) throw new ArgumentNullException(nameof(firms));
            if (string.IsNullOrWhiteSpace(prefix)) throw new ArgumentNullException(nameof(prefix));

            return firms
                .SelectMany(f => f.Employers ?? Enumerable.Empty<Employers>())
                .Where(e => e.Email.StartsWith(prefix, StringComparison.OrdinalIgnoreCase));
        }

        public static IEnumerable<Employers> GetEmployersByName(this IEnumerable<Firm> firms, string firstName)
        {
            if (firms == null) throw new ArgumentNullException(nameof(firms));
            if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentNullException(nameof(firstName));

            return firms
                .SelectMany(f => f.Employers ?? Enumerable.Empty<Employers>())
                .Where(e =>
                {
                    var parts = e.FullName.Split(' ');
                    return parts.Length >= 1 && parts[0].Equals(firstName, StringComparison.OrdinalIgnoreCase);
                });
        }

    }
}
