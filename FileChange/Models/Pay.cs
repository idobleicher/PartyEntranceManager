using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileChange.Models
{
    public class Pay : User
    {
        public double Total { get; set; }

        public Pay(User user)
        {
            this.name = user.name;
            this.salary = user.salary;
            this.bottle= user.bottle;
            this.precent = user.precent;
            this.people = user.people;
            this.Total = salary * people + bottle * precent;
        }
    }
}