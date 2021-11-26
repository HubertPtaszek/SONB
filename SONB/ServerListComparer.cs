using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
namespace SONB
{
    public class ServerListComparer : IEqualityComparer<ServerList<Server>>
    {
        public bool Equals(ServerList<Server> x, ServerList<Server> y)
        {
            return x.Equals(y);
        }

        public int GetHashCode(ServerList<Server> obj)
        {
            return obj.GetHashCode();
        }
    }
}
