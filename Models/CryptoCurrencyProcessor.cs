using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class CryptoCurrencyProcessor : IPaymentProcessor
    {
        private double Coins { get; set; }
        private double CostCoins { get; set; }
        private string NameCoins { get; set; }

        public CryptoCurrencyProcessor(double coins, double costcoins, string namecoins)
        {
            Coins = coins;
            CostCoins = costcoins;
            NameCoins = namecoins;
        }

        public virtual bool ProcessPayment(decimal amount)
        {
            return true;
        }
        public virtual bool RefundPayment(decimal amount)
        {
            return true;
        }


    }
}
