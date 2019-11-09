using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL
{
    class Hotels
    {
        internal Hotels(List<Hotel> list)
        {
            HotelList = list;
        }
        internal List<Hotel> HotelList { get; set; }

        internal void FindRoom(decimal amount, string curr)
        {
            Console.Write("Rooms in your range are: ");
            for (int i = 0; i < HotelList.Count; i++)
            {
                HotelList[i].FindRoom(amount, curr);

            }
        }
    }
}
