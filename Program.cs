using System;
using System.Collections.Generic;

namespace P05FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                string[] tokkens = input.Split(';');
                string command = tokkens[0];
                try
                {
                    switch (command)
                    {
                        case "Team":
                            string teamName = tokkens[1];
                            teams.Add(teamName, new Team(teamName));
                            break;

                        case "Add":
                            teamName = tokkens[1];
                            string playerName = tokkens[2];
                            int endurance = int.Parse(tokkens[3]);
                            int sprint = int.Parse(tokkens[4]);
                            int dribble = int.Parse(tokkens[5]);
                            int passing = int.Parse(tokkens[6]);
                            int shooting = int.Parse(tokkens[7]);

                            if (teams.ContainsKey(teamName))
                            {
                                teams[teamName]
                                .Add(new Player
                                    (playerName,
                                    endurance,
                                    sprint,
                                    dribble,
                                    passing,
                                    shooting));
                            }
                            else
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                            }
                            
                            break;

                        case "Remove":
                            teamName = tokkens[1];
                            playerName = tokkens[2];
                            teams[teamName].Remove(playerName);
                            break;

                        case "Rating":
                            teamName = tokkens[1];
                            if (teams.ContainsKey(teamName))
                            {
                                Console.WriteLine($"{teamName} - {teams[teamName].Rating}");
                            }
                            else
                            {
                                Console.WriteLine($"Team {teamName} does not exist.");
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                
            }
        }
    }
}
