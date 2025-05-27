using System;

namespace ConsoleApp2.Models
{
    public class CarRentalReservation : Reservation
    {
        public string CarType { get; set; }
        public string InsuranceOptions { get; set; }

        public override decimal CalculatePrice()
        {
            Console.WriteLine($"Расчет стоимости бронирования аренды автомобиля {ReservationID}");
            return 0; 
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Тип: {CarType}");
            Console.WriteLine($"Варианты страхования: {InsuranceOptions}");
        }
    }
} 