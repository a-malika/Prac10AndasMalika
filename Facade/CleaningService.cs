using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10
{
    public class CleaningService
    {
        private Queue<int> roomNumbers;
        public CleaningService()
        {
            roomNumbers = new Queue<int>();
        }
        public void AddRoomToCleaningSchedule(int roomNumber)
        {
            roomNumbers.Enqueue(roomNumber);
            Console.WriteLine($"Room {roomNumber} added to queue.");
        }
        public void CleanScheduleRoom()
        {
            int roomNumber = roomNumbers.Dequeue();
            Console.WriteLine($"Room {roomNumber} cleaned.");
        }
        public void CleanRoom(int roomNumber)
        {
            Console.WriteLine($"Room {roomNumber} cleaned.");
        }
    }
}
