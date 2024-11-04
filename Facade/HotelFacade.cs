using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10
{
    public class HotelFacade
    {
        private RoomBookingSystem roomBookingSystem;
        private RestaurantSystem restaurantSystem;
        private EventManagmentSystem eventManagmentSystem;
        private CleaningService cleaningService;
        public HotelFacade(RoomBookingSystem roomBookingSystem, RestaurantSystem restaurantSystem, EventManagmentSystem eventManagmentSystem, CleaningService cleaningService)
        {
            this.roomBookingSystem = roomBookingSystem;
            this.restaurantSystem = restaurantSystem;
            this.eventManagmentSystem = eventManagmentSystem;
            this.cleaningService = cleaningService;
        }
        public void BokingRoomWithFoodAndCleaning(int roomNumber, string food)
        {
            bool canBeBooked = roomBookingSystem.CheckingAvailability(roomNumber);
            roomBookingSystem.Booking(roomNumber);
            if (canBeBooked)
            {
                cleaningService.CleanRoom(roomNumber);
                restaurantSystem.OrderFood(food);
            }
            Console.WriteLine();
        }
        public void EventWithBookingAndEquipment(int roomNumber, string equipment)
        {
            bool canBeBooked = roomBookingSystem.CheckingAvailability(roomNumber);
            roomBookingSystem.Booking(roomNumber);
            if (canBeBooked)
            {
                eventManagmentSystem.OrderEquipment(equipment);
            }
            Console.WriteLine();
        }
        public void TableReservationWithTaxi(int tableNumber)
        {
            bool canBeBooked = restaurantSystem.CheckingAvailability(tableNumber);
            restaurantSystem.Booking(tableNumber);
            if (canBeBooked)
            {
                restaurantSystem.OrderTaxi();
            }
            Console.WriteLine();
        }
    }
}
