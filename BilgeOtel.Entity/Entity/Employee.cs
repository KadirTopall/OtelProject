using BilgeOtel.Entity.Base;
using BilgeOtel.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeOtel.Entity.Entity
{
    public class Employee : BaseEntity
    {
        public Employee()
        {
            WorkHours = 8;
        }
        public AppUser User { get; set; }
        public AppUserRole AppUserRole { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Department Department { get; set; }
        public int WorkHours { get; set; }
        public int ExtraHours { get; set; }
        public double ExtraHourSalary { get; set; }
        public double SalaryPerHour { get; set; }
        public int DayCounter { get; set; }
        public DateTime Day { get; set; }
        public double Salary { get; set; }
        public Shift Shift { get; set; }

    }
}
