﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VucchiBags.Customers
{
    enum CustomerRating {  Blacklisted, Regular, Dodgey }

    [Serializable]
    class Customer : Entity
    {
        public CustomerRating Rating { get; set; }

        public string Forename { get; set; }

        public string Surname { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string PassportNumber { get; set; }

        public DateTime Birthdate { get; set; }

        public string FullName {
            get {
                return $"{Forename} {Surname}";
            }
        }
    }
}
