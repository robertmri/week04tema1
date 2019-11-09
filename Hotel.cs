using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    class Hotel
    {
        internal Hotel(string name, string city, List<Room> list)
        {
            Name = name;
            City = city;
            RoomList = list;
        }
        internal string Name { get; set; }
        internal string City { get; set; }
        internal List<Room> RoomList { get; set; }
        internal string AllDetails
        {
            get
            {
                return $"Hotel Name: {Name}, City: {City}";
            }
        }
        internal void Print()
        {
            Console.WriteLine(AllDetails);
            foreach (var item in RoomList)
            {
                Console.WriteLine(item.AllDetails);
            }
        }
        internal void GetPriceForNumberOfRooms(int numberOfRooms)
        {
            if (RoomList.Count < numberOfRooms)
            {
                Console.WriteLine($"Your order can not be fulfilled. There are only {RoomList.Count} rooms available.");
                return;
            }
            decimal sum = 0;
            for (int i = 0; i < numberOfRooms; i++)
            {
                sum = sum + RoomList[i].Rate.Amount;
            }
            Console.WriteLine($"The total amount for the requested rooms is: {sum}. ");
        }
        internal void FindRoom(decimal amount, string curr)
        {
            Console.WriteLine($"Hotel: {this.Name}");
            int counter = 0;
            for (int i = 0; i < RoomList.Count; i++)
            {
                if (RoomList[i].Rate.Amount < amount && RoomList[i].Rate.Currency == curr)
                {
                    Console.WriteLine(RoomList[i].AllDetails);
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Sorry, no suitable rooms");
            }
        }
    }
}
