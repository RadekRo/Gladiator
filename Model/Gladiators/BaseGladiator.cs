using System;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;

namespace Gladiator.Model.Gladiators
{
    public abstract class BaseGladiator
    {
        public string Type { get; }
        public string Name { get; }
        public int Level { get; private set; }
        public double CurrentHealth { get; set; } 

        public int BaseHP { get; set; } // Health Points
        public int BaseSP { get; set; } // Skill Points
        public int BaseDEX { get; set; } // Dexterity

        protected abstract double HPMultiplier { get; } 
        protected abstract double SPMultiplier { get; }
        protected abstract double DEXMultiplier { get; }

        public double HP
        {
            get
            {
                return BaseHP * HPMultiplier * Level; 
            }
        }
        public double SP
        {
            get
            {
                return BaseSP * SPMultiplier * Level;
            }
        }
        public double DEX
        {
            get
            {
                return BaseDEX * DEXMultiplier * Level;
            }
        }

        public BaseGladiator(string type, string name)
        {
            Type = type;
            Name = name;
        }

        public string FullName
        {
            get
            {
                return $"{Name} the {Type}";
            }
        }

        public void LevelUp()
        {
            Level++;
        }
    }
}