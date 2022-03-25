using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Mohammad Al-Qaisy

namespace Task_9
{
    class Person
    {
        protected string name, email;
        protected long phone_number;

        public Person(string name, string email, long phone_number)
        {
            this.name = name;
            this.email = email;
            this.phone_number = phone_number;
        }

        public virtual string Print()
        {
            return "Name: " + name + " ,\n" + "Email: " + email + " ,\n" + "Number: " + phone_number.ToString();
        }
    }
}
