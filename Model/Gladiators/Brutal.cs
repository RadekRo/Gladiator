using System;

namespace Gladiator.Model.Gladiators
{
    public class Brutal : BaseGladiator
    {
        public Brutal(string type, string name) : base(type, name)
        {

        }

        protected override double HPMultiplier => 
            StatisticMultiplierExtensions.GetMultiplierValue(StatisticMultiplier.High);
        protected override double SPMultiplier =>
            StatisticMultiplierExtensions.GetMultiplierValue(StatisticMultiplier.High);
        protected override double DEXMultiplier => 
            StatisticMultiplierExtensions.GetMultiplierValue(StatisticMultiplier.Low);
    }
}