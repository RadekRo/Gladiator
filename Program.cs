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
            Brutal gladiatorOne = new("Brutal", "Radek");
            gladiatorOne.BaseHP = 10;   
            cw.Display(gladiatorOne.FullName + gladiatorOne.BaseHP);
        }
    }
}