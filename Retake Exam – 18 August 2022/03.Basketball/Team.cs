using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;

namespace Basketball
{
    public class Team
    {
        public Team(string name, int openPositions, char group)
        {
            Players = new List<Player>();
            Name = name;
            OpenPositions = openPositions;
            Group = group;
        }
        private List<Player> players;
        private string name;
        private int openPositions;
        private char group;
        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int OpenPositions
        {
            get { return openPositions; }
            set { openPositions = value; }
        }
        public char Group
        {
            get { return group; }
            set { group = value; }
        }
        public int Count { get { return players.Count; } }
        public string AddPlayer(Player player)
        {
            if (OpenPositions > 0)
            {
                if (player.Name == null || player.Name == string.Empty
                    || player.Position == null || player.Position == string.Empty)
                {
                    return "Invalid player's information.";
                }
                else if (player.Rating < 80)
                {
                    return "Invalid player's rating.";
                }
                else
                {
                    OpenPositions--;
                    Players.Add(player);
                    return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";
                }

            }
            else
            {
                return "There are no more open positions.";
            }
        }

        public bool RemovePlayer(string name)
        {
            var playerToRemove = Players.FirstOrDefault(x => x.Name == name);

            if (playerToRemove != null)
            {
                Players.Remove(playerToRemove);
                OpenPositions++;
                return true;
            }
            return false;
        }
        public int RemovePlayerByPosition(string position)
        {
            int countRemoved = 0;
            foreach (var player in Players)
            {
                if (player.Position == position)
                {
                    countRemoved++;
                }
            }
            Players.RemoveAll(x => x.Position == position);
            OpenPositions += countRemoved;
            return countRemoved;
        }

        public Player RetirePlayer(string name)
        {
            var retiredPlayer = players.FirstOrDefault(x => x.Name == name);
            if (retiredPlayer!=null)
            {
                retiredPlayer.Retired = true;
            }   
            return retiredPlayer;
        }

        public List<Player> AwardPlayers(int games)
        {
            var awardedPlayers = new List<Player>();
            foreach (var player in Players)
            {
                if (player.Games >games)
                {
                    awardedPlayers.Add(player);
                }
            }
            return awardedPlayers;
        }
        public string Report()
        {
            var sb = new StringBuilder();
            foreach (var item in Players)
            {
                if (item.Retired==false)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString().Trim();
        }




    }
}
