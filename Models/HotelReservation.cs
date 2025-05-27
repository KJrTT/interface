using System;

namespace ConsoleApp2.Models
{
    public class HotelReservation : Reservation
    {
        public string RoomType { get; set; }
        public string MealPlan { get; set; }

        public override decimal CalculatePrice()
        {
            Console.WriteLine($"Расчет стоимости бронирования отеля {ReservationID}");
            return 0; 
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Тип: {RoomType}");
            Console.WriteLine($"План питания: {MealPlan}");
        }
    }
} 