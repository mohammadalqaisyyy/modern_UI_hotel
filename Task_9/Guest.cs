using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Mohammad Al-Qaisy

namespace Task_9
{
    class Guest : Person
    {
        protected string payment_method;

        public Guest(string name, string email, long phone_number, string payment_method) : base(name, email, phone_number)
        {
            this.payment_method=payment_method;
        }

        public override string Print()
        {
            return base.Print() + "Payment method: " + this.payment_method;
        }
    }
}
