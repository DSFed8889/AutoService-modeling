using AutoService.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Classes
{
    internal class Service
    {
        public string servName;
        public int manufactureID;
        public int servTime;
        public int servTimeDiv;
        public int price;
        public Service(string servName, int manufactureID, int servTime, int servTimeDiv, int price)
        {
            this.servName = servName;
            this.manufactureID = manufactureID;
            this.servTime = servTime;
            this.servTimeDiv = servTimeDiv;
            this.price = price;
        }
    }
}
