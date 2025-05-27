using System;
using System.Collections.Generic;

namespace ConsoleApp2.Models
{
    public class BookingSystem
    {
        private List<Reservation> _reservations = new List<Reservation>();

        public Reservation CreateReservation(string reservationType)
        {
            Console.WriteLine($"Создание нового  {reservationType} бронирования ");
            return null;
        }

        public void CancelReservation(string reservationID)
        {
            Console.WriteLine($"Отмена бронирования {reservationID}");
        }

        public decimal GetTotalBookingValue()
        {
            Console.WriteLine("Расчет общей стоимости бронирования");
            return 0; 
        }
    }
} 