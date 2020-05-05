using System;
using FoldingAtHome;

namespace FoldingAtHome.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var team = Team.Get(264470).Result;

            Console.WriteLine(team);

            foreach (var donor in team.Donors)
                Console.WriteLine("-{0}", donor);
        }
    }
}
