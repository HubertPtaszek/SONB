using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
namespace SONB
{
    public class Server
    {
        public string Name { get; set; }
        public DateTime? Time { get; set; }
        public int Weight { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Server server &&
                   Name == server.Name &&
                   Time == server.Time &&
                   Weight == server.Weight;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Time, Weight);
        }
    }
}
