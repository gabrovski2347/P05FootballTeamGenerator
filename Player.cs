using System;

namespace P05FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Player(string name,
            int endurance,
            int sprint,
            int dribble,
            int passing,
            int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
            AverageSkill = Math.Ceiling((Endurance + Sprint + Dribble + Passing + Shooting) / 5.0);
        }

        public string Name { get => this.name; private set {
                Validator.ValidateName(value);
                this.name = value;
            } }

        public int Endurance
        {
            get => this.endurance;
            private set
            {
                Validator.ValidateStat(value, "Endurance");
                this.endurance = value;
            }
        }

        public int Sprint
        {
            get => this.sprint;
            private set
            {
                Validator.ValidateStat(value, "Sprint");
                this.sprint = value;
            }
        }

        public int Dribble
        {
            get => this.dribble;
            private set
            {
                Validator.ValidateStat(value, "Dribble");
                this.dribble = value;
            }
        }
        
        public int Passing
        {
            get => this.passing;
            private set
            {
                Validator.ValidateStat(value, "Passing");
                this.passing = value;
            }
        }
        
        public int Shooting
        {
            get => this.shooting;
            private set
            {
                Validator.ValidateStat(value, "Shooting");
                this.shooting = value;
            }
        }

        public double AverageSkill;
    }
}