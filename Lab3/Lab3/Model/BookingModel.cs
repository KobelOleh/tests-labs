using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    public class Bookingdates
    {
        public string checkin { get; set; }
        public string checkout { get; set; }
    }

    public class Booking
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int totalprice { get; set; }
        public bool depositpaid { get; set; }
        public Bookingdates bookingdates { get; set; }
        public string additionalneeds { get; set; }
    }
    public class Auth
    {
        public string username { get; set; }
        public string password { get; set; }
    }
    public class AuthToken
    {
        public string token { get; set; }
    }
    public class RandomFox
    {
        public string image { get; set; }
        public string link { get; set; }
    }
}
