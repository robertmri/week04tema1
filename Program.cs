using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    class Program
    {
        static void Main(string[] args)
        {
            Rate rate = new Rate(100, "RON");
            rate.Currency = "EUR";
            rate.Amount = 99;
            Rate rate2 = new Rate(120, "EUR");

            Room room = new Room("Double", rate, 2, 0);
            room.Adult = 2;
            room.Children = 0;
            room.Name = "Double";
            room.Rate = rate;
            Room room2 = new Room("Double", rate2, 2, 1);
            Console.WriteLine(room.GetPriceForDays(2));

            List<Room> lista = new List<Room>();
            lista.Add(room);
            lista.Add(room2);

            Hotel hotel = new Hotel("Astoria", "Iasi", lista);
            //hotel.GetPriceForNumberOfRooms(3);
            List<Hotel> hList = new List<Hotel>();
            hList.Add(hotel);
            Hotels hotelManagaer = new Hotels(hList);
            hotelManagaer.FindRoom(150, "EUR");

        }
    }
}
