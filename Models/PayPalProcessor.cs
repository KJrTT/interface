using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class PayPalProcessor : IPaymentProcessor
    {

        private int Id { get; }

        public PayPalProcessor(int id)
        {
            Id = id;
        }
        public bool ProcessPayment(decimal amount)
        {
            return true;
        }
        public bool RefundPayment(decimal amount) 
        {
            return true;
        }
    }
}
