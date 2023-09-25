using Gladiator.Model;
using Gladiator.Model.Gladiators;
using Gladiator.View;
using System.ComponentModel.DataAnnotations;

namespace Gladiator
{
    public static class Program
    {
        public static void Main()
        {
            // Start the program here
            var cw = new ConsoleView();
            cw.Display("Gladiator's Fight!", true);
            cw.GetNumberBetween();
            var PlayerOne = GladiatorFactory.GenerateRandomGladiator();
            var PlayerTwo = GladiatorFactory.GenerateRandomGladiator();
            var PlayerThree = GladiatorFactory.GenerateRandomGladiator();
            cw.Display(PlayerOne.FullName, true);
            cw.Display(PlayerTwo.FullName, true);
            cw.Display(PlayerThree.FullName);

            
        }
    }
}