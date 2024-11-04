using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10
{
    public class EventManagmentSystem
    {
        private bool[] conferenceRooms;
        public EventManagmentSystem(int roomCount)
        {
            conferenceRooms = new bool[roomCount];
            for (int i = 0; i < conferenceRooms.Length; i++)
            {
                conferenceRooms[i] = true;
            }
        }
        public void Booking(int roomNumber)
        {
            if (CheckingAvailability(roomNumber))
            {
                conferenceRooms[roomNumber] = false;
                Console.WriteLine($"Conference room {roomNumber} reserved.");
            }
            else
            {
                Console.WriteLine($"Conference room {roomNumber} cannot be reserved.");
            }
        }
        public bool CheckingAvailability(int roomNumber)
        {
            if (roomNumber < 0 || roomNumber >= conferenceRooms.Length || conferenceRooms[roomNumber] == false) return false;
            else return true;
        }
        public void CancelingReservation(int roomNumber)
        {
            if (CheckingAvailability(roomNumber))
            {
                Console.WriteLine("Room reservation cannot be canceled. Conference room is already available.");
            }
            else if (roomNumber < 0 || roomNumber >= conferenceRooms.Length)
            {
                Console.WriteLine("Room reservation cannot be canceled. Hotel does not have this conference room.");
            }
            else
            {
                conferenceRooms[roomNumber] = true;
                Console.WriteLine("Conference room reservation canceled.");
            }
        }
        public void OrderEquipment(string equipment)
        {
            Console.WriteLine($"{equipment} was ordered");
        }
    }
}
