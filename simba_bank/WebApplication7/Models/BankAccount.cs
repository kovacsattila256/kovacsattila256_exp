﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Models
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public string AnimalType { get; set; }
        public string Currency { get; set; }

        public BankAccount()
        {
            Currency = "Zebra";
        }
    }
}
