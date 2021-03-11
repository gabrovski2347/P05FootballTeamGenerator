using System;
using System.Collections.Generic;
using System.Text;

namespace P05FootballTeamGenerator
{
    public class Validator
    {
        public static void ValidateName(string name)
        {
            if (name == null || name == " " || name == "")
            {
                throw new ArgumentException("A name should not be empty.");
            }
        }

        public static void ValidateStat(int stat, string statName) 
        {
            //"[Stat name] should be between 0 and 100."
            if (stat > 100 || stat < 0)
            {
                throw new ArgumentException($"{statName} should be between 0 and 100.");
            }
        }
    }
}
