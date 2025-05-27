using System;

namespace ConsoleApp2.Models
{
    public class FlightReservation : Reservation
    {
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }

        public override decimal CalculatePrice()
        {
            Console.WriteLine($"Расчет стоимости бронирования авиабилетов {ReservationID}");
            return 0;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Аэропорт вылета: {DepartureAirport}");
            Console.WriteLine($"Аэропорт прибытия: {ArrivalAirport}");
        }
    }
} 