using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;   
namespace Task1
{
    public interface IFirm
    {
        public string Name { get; set; }
        public DateOnly FoundationDate { get; set; }
        public string BusinessProfile { get; set; }
        public string DirectorFullName { get; set; }
        public List<Employers> Employers { get; set; }
        public int EmployeeCount { get; set; }
        public string Address { get; set; }

    }
}
