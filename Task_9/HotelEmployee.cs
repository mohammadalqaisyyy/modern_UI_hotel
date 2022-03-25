using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Mohammad Al-Qaisy

namespace Task_9
{
    class HotelEmployee : Person
    {
        int salary;

        public HotelEmployee(string name, string email, long phone_number, int salary) : base(name, email, phone_number)
        {
            this.salary = salary;
        }

        public override string Print()
        {
            return base.Print() + "Salary: " + this.salary;
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
