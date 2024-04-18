using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Room
    {
        static int _id;

        public int Id { get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;
        public Room(string name,decimal price,int personcapasity)
        {
            int id = _id++;
            Name = name;
            Price = price;
            PersonCapacity = personcapasity;
        }
        public string ShowInfo()
        {
            return $"Room ID: {Id}, Name: {Name}, Price: {Price}, PersonCapacity: {PersonCapacity}, IsAvailable: {IsAvailable}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
