using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGVE.UI
{
    class Client
    {
        public string ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string DOB { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return "ID: " + ID + "\n" +
           "First Name: " + firstName + "\n" +
           "Last Name: " + lastName + "\n" +
           "Phone Number: " + phoneNumber + "\n" +
           "Address: " + address + "\n" +
           "Date Of Birth: " + DOB + "\n" +
           "Email: " + email + "\n";
        }
    }
}
