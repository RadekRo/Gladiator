using Gladiator.Model.Gladiators;
using Gladiator.Utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Gladiator.Model
{
    public class GladiatorFactory
    {
        public static BaseGladiator GenerateRandomGladiator()
        {
            int randomNumber = RandomGenerator.GetRandomNumber(1, 5);

            Type selectedType = GladiatorFactory.GetGladiatorType(randomNumber);
            BaseGladiator newGladiator = (BaseGladiator)Activator.CreateInstance(selectedType, selectedType.Name, "Radek");
            return newGladiator;
        }

        private static Type GetGladiatorType(int number)
        {
            switch(number)
            {
                case 1:
                case 2:
                    return typeof(Swordsman);
                case 3:
                    return typeof(Archer);
                case 4:
                    return typeof(Assassin);
                case 5:
                    return typeof(Brutal);
                default:
                    return null;
            }
        }
    }
}
