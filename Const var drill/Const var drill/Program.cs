using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_var_drill
{
    class Program
    {
        public static void Main(string[] args)
        {
            const string Game = "Overwatch";
            var developmentYear = 2016;
            Player player1 = new Player(1324, "Roadhog");
            Player player2 = new Player("Junkrat");
            Console.WriteLine("Welcome to " + Game + "\nA team based first person shooter developed in " + developmentYear + ". These are your teammates. \n" + player1.name + " & " + player2.name + "\nGood luck!");
            Console.ReadLine();
        }
    }
}
