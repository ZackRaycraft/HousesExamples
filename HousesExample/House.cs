using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousesExample
{
    class House
    {
        //Add four fields to your class
        private string color;
        private int rooms;
        private int size;
        private int doors;

        //Add methods to your class
        public void Paint(string color)
        {
            this.color = color;
        }

        public string CurrentColor()
        {
            return color;
        }
    }
}
