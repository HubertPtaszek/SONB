using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
namespace SONB
{
    public class ServerList<T> : List<T> , IEnumerable<T>
    {
        public ServerList()
        {
        }
        public ServerList(List<T> list)
        {
            foreach(T item in list)
            {
                this.Add(item);
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            ServerList<T> list = obj as ServerList<T>;
            if (list == null)
                return false;

            if (list.Count != this.Count)
                return false;

            bool same = true;
            this.ForEach(thisItem =>
            {
                if (same)
                {
                    same = (null != list.FirstOrDefault(item => item.Equals(thisItem)));
                }
            });

            return same;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 1;
                foreach (var foo in this)
                {
                    hash = hash + (foo as Server).GetHashCode() / 2;
                }
                return hash;
            }
        }
    }
}
