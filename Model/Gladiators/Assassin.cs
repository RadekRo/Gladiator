namespace Gladiator.Model.Gladiators
{
    public class Assassin : BaseGladiator
    {
        public Assassin(string type, string name) : base(type, name)
        {
            
        }
        protected override double HPMultiplier =>
            StatisticMultiplierExtensions.GetMultiplierValue(StatisticMultiplier.Low);
        protected override double SPMultiplier =>
            StatisticMultiplierExtensions.GetMultiplierValue(StatisticMultiplier.High);
        protected override double DEXMultiplier =>
            StatisticMultiplierExtensions.GetMultiplierValue(StatisticMultiplier.High);
    }
}