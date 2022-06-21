using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Bookings
    {

        public Bookings(DateTime start, DateTime end, int pitchid)
        {
            this.Start = start;
            this.End = end;
            this.pitchid = pitchid;
        }
        public Bookings()
        {

        }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int pitchid { get; set; }
    }
}
