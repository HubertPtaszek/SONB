using System;
using System.Threading;
using System.Threading.Tasks;

namespace SONB
{
    class Program
    {
        static void Main(string[] args)
        {
            Voting voting = new Voting();
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = voting.MainMenu();
            }
        }
       
    }
}
