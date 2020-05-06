using System;
using System.Diagnostics.CodeAnalysis;
using FoldingAtHome;

namespace FoldingAtHome.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var team = Team.Get(264470).Result;

            Console.WriteLine("TEAM INFORMATION");
            Console.WriteLine(team);

            foreach (var teamDonors in team.Donors)
                Console.WriteLine("-{0}", teamDonors);

            Console.WriteLine("");
            Console.WriteLine("DONOR INFORMATION");

            var donor = Donor.Get("adgroc").Result;

            Console.WriteLine("name: {0}", donor.Name);
            Console.WriteLine("work units: {0}", donor.WorkUnits);
            Console.WriteLine("credit: {0}", donor.Credit);
        }
    }
}
