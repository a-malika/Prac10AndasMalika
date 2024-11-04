using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10
{
    public class RoomBookingSystem
    {
        private bool[] rooms;
        public RoomBookingSystem(int roomCount)
        {
            rooms = new bool[roomCount];
            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i] = true;
            }
        }
        public void Booking(int roomNumber)
        {
            if (CheckingAvailability(roomNumber))
            {
                rooms[roomNumber] = false;
                Console.WriteLine($"Room {roomNumber} reserved.");
            }
            else
            {
                Console.WriteLine($"Room {roomNumber} cannot be reserved.");
            }
        }
        public bool CheckingAvailability(int roomNumber)
        {
            if (roomNumber < 0 || roomNumber >= rooms.Length || rooms[roomNumber] == false) return false;
            else return true;
        }
        public void CancelingReservation(int roomNumber)
        {
            if (CheckingAvailability(roomNumber))
            {
                Console.WriteLine("Room reservation cannot be canceled. Room is already available.");
            }
            else if (roomNumber < 0 || roomNumber >= rooms.Length)
            {
                Console.WriteLine("Room reservation cannot be canceled. Hotel does not have this room.");
            }
            else
            {
                rooms[roomNumber] = true;
                Console.WriteLine("Room reservation canceled.");
            }
        }
    }
}
