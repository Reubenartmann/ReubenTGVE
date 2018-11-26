using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGVE.UI
{
    class Tour
    {
        public string ID { get; set; }
        public string tourStartTime { get; set; }
        public string tourEndTime { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string area { get; set; }
        public string location { get; set; }

        public override string ToString()
        {
            return "ID: " + ID + "\n" +
           "Name: " + name + "\n" +
           "Start Time: " + tourStartTime + "\n" +
           "End Time: " + tourEndTime + "\n" +
           "Description: " + description + "\n" +
           "Area: " + area + "\n" +
           "Location: " + location + "\n";
        }
    }
}
