using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice10
{
    public class RestaurantSystem
    {
        private bool[] tables;
        public RestaurantSystem(int tableCount)
        {
            tables = new bool[tableCount];
            for (int i = 0; i < tables.Length; i++)
            {
                tables[i] = true;
            }
        }
        public void Booking(int tableNumber)
        {
            if (CheckingAvailability(tableNumber))
            {
                tables[tableNumber] = false;
                Console.WriteLine($"Table {tableNumber} reserved.");
            }
            else
            {
                Console.WriteLine($"Table {tableNumber} cannot be reserved.");
            }
        }
        public bool CheckingAvailability(int tableNumber)
        {
            if (tableNumber < 0 || tableNumber >= tables.Length || tables[tableNumber] == false) return false;
            else return true;
        }
        public void CancelingReservation(int tableNumber)
        {
            if (CheckingAvailability(tableNumber))
            {
                Console.WriteLine("Table reservation cannot be canceled. Table is already available.");
            }
            else if (tableNumber < 0 || tableNumber >= tables.Length)
            {
                Console.WriteLine("Table reservation cannot be canceled. Restaurant does not have this table.");
            }
            else
            {
                tables[tableNumber] = true;
                Console.WriteLine("Table reservation canceled.");
            }
        }
        public void OrderFood(string food)
        {
            Console.WriteLine($"{food} was ordered.");
        }
        public void OrderTaxi()
        {
            Console.WriteLine("Taxi was ordered.");
        }
    }
}
