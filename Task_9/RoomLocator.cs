using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Mohammad Al-Qaisy

namespace Task_9
{
    class RoomLocator
    {
        HotelEmployee userE;
        Guest userG;
        Room room;
        DateTime inDate = new DateTime(), outDate = new DateTime();

        public RoomLocator(string name, string email, long phone_number, int salary, int number, bool busy, DateTime inDate)
        {
            this.userE = new HotelEmployee(name, email, phone_number, salary);
            this.room = new Room(number, busy);
            this.inDate = inDate;
            this.userG = null;
        }
        public RoomLocator(string name, string email, long phone_number, string payment_method, int number, bool busy, DateTime inDate)
        {
            this.userG = new Guest(name, email, phone_number, payment_method);
            this.room = new Room(number, busy);
            this.inDate = inDate;
            this.userE = null;
        }

        double Payment()
        {
            TimeSpan interval = outDate - inDate;
            if (userE == null)
            {
                if (interval.TotalDays <= 5)
                    return 20;
                return 20 + (interval.TotalDays - 5) * 10;
            }
            else
            {
                if (interval.TotalDays > 30)
                    userE.Salary -= (userE.Salary / 100) * 10;
                if (interval.TotalDays <= 2)
                    return 5;
                return 5 + (interval.TotalDays - 2) * 3;
            }
        }
    }
}
