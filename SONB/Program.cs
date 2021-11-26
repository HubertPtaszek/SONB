using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
namespace SONB
{
    class Program
    {
        static void Main(string[] args)
        {
/*            var list1 = new List<int> { 1, 2, 3 };
            var list2 = new List<int> { 2, 1, 3 };
            HashSet<List<int>> keysToDelete = new HashSet<List<int>>();
            keysToDelete.Add(list1.OrderBy(x => x).ToList());
            keysToDelete.Add(list2.OrderBy(x => x).ToList());
            var set = new HashSet<int>(list1);
            var equals = set.SetEquals(list2);*/
            Voting voting = new Voting();
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = voting.MainMenu();
            }
        }
       
    }
}
