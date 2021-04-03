﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankAccount
    {
        private decimal amount = 0;
        
        public BankAccount(decimal amount)
        {
            Amount = amount;
        }


        public decimal Amount
        {
            get { return amount; }
            
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Amount must be positive!");
                }

                amount = value;
            }
        }

        public void Deposit(decimal amount)
        {
            Amount += amount; 
        }
    }
}
