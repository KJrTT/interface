

using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.ComponentModel.Design;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;
using System;
using System.Xml;
using ConsoleApp1.Models;


class Program
{
    static void Main()
    {
        Client client = new Client(5000,"Акакий", 1);

        while (true)
        {
            Console.WriteLine("Введите способ оплаты");
            Console.WriteLine("1 --> Обычной картой");
            Console.WriteLine("2 --> Кредитной картой");
            Console.WriteLine("3 --> Криптой");

            int choose = int.Parse(Console.ReadLine());

            if (choose == 1)
            {
                PayPalProcessor processor = new PayPalProcessor(1);

                Console.WriteLine("Введите сумму перевода");
                int summ = int.Parse(Console.ReadLine());
                PayPalProcessor payPalProcessor = new PayPalProcessor(1);
                if (client.Money >= summ)
                {
                    if (payPalProcessor.ProcessPayment(summ))
                    {
                        client.Money -= summ;
                        Console.WriteLine("Платеж успешно выполнен");
                    }
                }
                else
                {
                    Console.WriteLine("Недостаточно средств");
                    break;
                }
            }

            else if (choose == 2)
            {
                int summ = int.Parse(Console.ReadLine());
                CreditCardProcessor creditCardProcessor = new CreditCardProcessor();
                if (creditCardProcessor.ValidatePayment(summ))
                    {
                    if (creditCardProcessor.ProcessPayment(summ))
                    {
                        Console.WriteLine("Платеж успешно выполнен");
                    }
                }
                else
                {
                    Console.WriteLine("Платеж не прошел проверку");
                }
                break;
            }
            else if (choose == 3)
            {
                CryptoCurrencyProcessor currencyProcessor = new CryptoCurrencyProcessor(5.5, "Bit", 6.77);
            }
            else
            {
                Console.WriteLine("Введите корректное число");
            }

        }



    }
}

