using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Pitches
    {
        public Pitches(int id, int number)
        {
            this.Id = id;
            this.Number = number;
        }

        public int Id { get; set; }
        public int Number { get; set; }

    }
}
