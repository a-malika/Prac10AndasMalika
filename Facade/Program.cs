using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HotelFacade hotel = new(new RoomBookingSystem(40), new RestaurantSystem(20), new EventManagmentSystem(5), new CleaningService());
            hotel.TableReservationWithTaxi(12);
            hotel.EventWithBookingAndEquipment(5, "Computers");
            hotel.BokingRoomWithFoodAndCleaning(14, "Sushi");
            hotel.TableReservationWithTaxi(1);
        }
        
    }
}
