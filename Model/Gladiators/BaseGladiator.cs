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

        public int BaseHP { get; set; }
        public int BaseSP { get; set; }
        public int BaseDEX { get; set; }

        protected abstract double HPMultiplier { get; } 
        protected abstract double SPMultiplier { get; }
        protected abstract double DEXMultiplier { get; }

        public BaseGladiator(string type, string name)
        {
            Type = type;
            Name = name;
            Level = 1;
        }

        public string FullName
        {
            get
            {
                return $"{Type} {Name}";
            }
        }

        public void LevelUp()
        {
            Level++;
        }
    }
}