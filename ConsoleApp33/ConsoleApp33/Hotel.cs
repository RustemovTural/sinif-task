using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Hotel
    {
        public string Name { get; set; }
        public object Id { get; internal set; }

        private List<Room> rooms = new List<Room>();
        public Hotel(string name)
        {
            Name = name;

        }
        public void AddRoom(Room room)
        {
            rooms.Add(room);
        }
        public void MakeReservation(int? roomId, int customerCount)
        {
            if (roomId == null)
            {
                throw new NullReferenceException("otqa bos deyil");
            }

            Room room = rooms.Find(r => r.Id == roomId);
            if (room == null)
            {
                throw new Exception("rezerv olunub");
            }

            if (!room.IsAvailable)
            {
                throw new NotAvailableException();
            }

            if (customerCount > room.PersonCapacity)
            {
                throw new Exception("bilmedim ne deyim");
            }

            room.IsAvailable = false;
        }

        internal IEnumerable<object> GetAllRooms()
        {
            throw new NotImplementedException();
        }
    }
}
