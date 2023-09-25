using System.Runtime.CompilerServices;

namespace Gladiator.Model.Gladiators
{
    public class Archer : BaseGladiator
    {
        public Archer(string type, string name) : base(type, name)
        {
            
        }
        protected override double HPMultiplier =>
            StatisticMultiplierExtensions.GetMultiplierValue(StatisticMultiplier.Medium);
        protected override double SPMultiplier =>
            StatisticMultiplierExtensions.GetMultiplierValue(StatisticMultiplier.Medium);
        protected override double DEXMultiplier =>
            StatisticMultiplierExtensions.GetMultiplierValue(StatisticMultiplier.High);
    }
}