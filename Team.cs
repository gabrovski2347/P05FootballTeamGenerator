using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05FootballTeamGenerator
{
    public class Team
    {
        private string name;

        public Team(string name)
        {
            Name = name;
            Players = new List<Player>();               
        }

        public string Name { get => this.name;
            private set {
                Validator.ValidateName(value);
                this.name = value;
            } }

        public List<Player> Players { get; set; }

        public int Rating
        {
            get
            {
                if (this.Players.Count == 0)
                {
                    return 0;
                }

                return (int)Math.Round(this.Players.Average(x => x.AverageSkill), 0);
            }
        }

        public void Add(Player player)
        {
            Players.Add(player);
        }

        public void Remove(string playerName)
        {
            var playerToRemove = Players.FirstOrDefault(x => x.Name == playerName);
            if (playerToRemove == null)
            {
                throw new ArgumentException($"Player {playerName} is not in {this.name} team.");
            }
            Players.Remove(playerToRemove);
        }
    }
}
