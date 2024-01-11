using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Player_and_Team_Requirements
{
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public OneDayTeam() //ctor to set capacity
        {
            oneDayTeam.Capacity = 11;

        }

        public void Add(Player player)
        {
            if (oneDayTeam.Count == 11)
            {
                Console.WriteLine("ONEDAY TEAM IS FULL");
            }
            else
            {
                oneDayTeam.Add(player);
                Console.WriteLine("Player is added successfully");

            }

        }

        public void Remove(int playerId)
        {
            Player found = oneDayTeam.Find(player => player.PlayerId.Equals(playerId));

            if (found != null)
            {
                oneDayTeam.Remove(found);
                Console.WriteLine("Player is removed successfully");
            }
            else
            {
                Console.WriteLine("Player not found in onedayteam");
            }

        }

        public Player GetPlayerById(int playerId)
        {

            Player found = oneDayTeam.Find(player => player.PlayerId.Equals(playerId));

            //Console.WriteLine(found.PlayerId + "    " + found.PlayerName + "  " + found.PlayerAge);
            if (found != null)
            {
                return found;
            }
            else
            {
                Console.WriteLine("Player not found in onedayteam");
                return default;
            }

        }


        public Player GetPlayerByName(string playerName)
        {
            Player found = oneDayTeam.Find(player => player.PlayerName.Equals(playerName));

            if (found != null)
                return found;
            else
            {
                Console.WriteLine("Player not found in onedayteam");
                return default;
            }
        }


        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }


    }
}