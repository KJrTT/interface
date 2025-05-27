using System;
using ConsoleApp2.Models;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookingSystem = new BookingSystem();

            var hotelReservation = new HotelReservation
            {
                ReservationID = "Отель 1",
                CustomerName = "John Doe",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(5),
                RoomType = "Deluxe",
                MealPlan = "Полный пансион"
            };

            var flightReservation = new FlightReservation
            {
                ReservationID = "Самолт 1",
                CustomerName = "John Doe",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(1),
                DepartureAirport = "JFK",
                ArrivalAirport = "Лос-Анджелес"
            };

            var carReservation = new CarRentalReservation
            {
                ReservationID = "Машина 1",
                CustomerName = "John Doe",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(3),
                CarType = "SUV",
                InsuranceOptions = "Полное покрытие"
            };

            Console.WriteLine("Подробности бронирования отеля:");
            hotelReservation.DisplayDetails();
            Console.WriteLine("Подробности бронирования рейса:");
            flightReservation.DisplayDetails();
            Console.WriteLine("Подробности бронирования аренды автомобиля:");
            carReservation.DisplayDetails();

            Console.WriteLine("Операции системы бронирования:");
            bookingSystem.CreateReservation("Отель");
            bookingSystem.CancelReservation("Отель 1");
            bookingSystem.GetTotalBookingValue();
        }
    }
}
