using System;

namespace ConsoleApp2.Models
{
    public abstract class Reservation
    {
        public string ReservationID { get; set; }
        public string CustomerName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public abstract decimal CalculatePrice();

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"ID бронирования: {ReservationID}");
            Console.WriteLine($"Имя клиента: {CustomerName}");
            Console.WriteLine($"Дата начала: {StartDate.ToShortDateString()}");
            Console.WriteLine($"Дата окончания: {EndDate.ToShortDateString()}");
        }
    }
} 