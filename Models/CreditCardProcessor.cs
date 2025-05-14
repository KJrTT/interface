using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class CreditCardProcessor : IPaymentProcessor, IPaymentValidator
    {
        private double Balance { get; set; }

        public bool ProcessPayment(decimal amount)
        {
            return true;
        }
        public bool RefundPayment(decimal amount)
        {
            return true;
        }

        public bool ValidatePayment(decimal amount) 
        {
            return true;
        }
    }
}
