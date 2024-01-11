using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*

  FastPace Cricket Academy has decided to create a solution to maintain information about the teams’ players for one day game

*/

namespace Player_and_Team_Requirements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // menu

            OneDayTeam oneDay = new OneDayTeam();
            string need;
            do
            {
                Console.WriteLine("Enter\n1:To Add Player\n2:To Remove Player by Id\n3.Get Player By Id\n4.Get Player by Name\n5.Get All Players:");
                int choice = int.Parse(Console.ReadLine());



                switch (choice)
                {
                    case 1:
                        Player p = new Player();
                        Console.Write("Enter Player Id   : ");
                        p.PlayerId = int.Parse(Console.ReadLine());
                        Console.Write("Enter Player Name : ");
                        p.PlayerName = Console.ReadLine();
                        Console.Write("Enter Player Age  : ");
                        p.PlayerAge = int.Parse(Console.ReadLine());
                        oneDay.Add(p);
                        break;

                    case 2:
                        Console.Write("Enter Player Id to Remove  : ");
                        int playerId = int.Parse(Console.ReadLine());
                        oneDay.Remove(playerId);
                        break;

                    case 3:
                        Console.Write("Enter Player Id : ");
                        int pId = int.Parse(Console.ReadLine());
                        Player found1 = oneDay.GetPlayerById(pId);
                        Console.WriteLine(found1.PlayerId + "    " + found1.PlayerName + "  " + found1.PlayerAge);
                        break;

                    case 4:
                        Console.Write("Enter Player Name : ");
                        string pName = Console.ReadLine();
                        Player found2 = oneDay.GetPlayerByName(pName);
                        Console.WriteLine(found2.PlayerId + "    " + found2.PlayerName + "  " + found2.PlayerAge);
                        break;

                    case 5:
                        List<Player> teamlist = oneDay.GetAllPlayers();
                        foreach (var item in teamlist)
                        {
                            Console.WriteLine(item.PlayerId + "    " + item.PlayerName + "  " + item.PlayerAge);
                        }
                        break;

                    default:
                        Console.WriteLine("Enter choice from 1 to 5");
                        break;

                }
                Console.WriteLine("===================================================");

                Console.Write("Do you want to continue( yes / no ) : ");
                need = Console.ReadLine();
                Console.WriteLine("===================================================");

            } while (need.Equals("yes"));

            Console.Read();
        }
    }

}