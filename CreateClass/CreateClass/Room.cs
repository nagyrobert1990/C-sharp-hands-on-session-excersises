using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    public class Room
    {
        public int roomNumber;

        public Room(int roomNumber)
        {
            this.roomNumber = roomNumber;
        }

        public override string ToString()
        {
            return $"{roomNumber}";
        }
    }
}
