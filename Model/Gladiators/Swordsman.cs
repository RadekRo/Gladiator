namespace Gladiator.Model.Gladiators
{
    public class Swordsman : BaseGladiator
    {
        public Swordsman(string type, string name) : base(type, name)
        {

        }

        protected override double HPMultiplier =>
            StatisticMultiplierExtensions.GetMultiplierValue(StatisticMultiplier.Medium);
        protected override double SPMultiplier =>
            StatisticMultiplierExtensions.GetMultiplierValue(StatisticMultiplier.Medium);
        protected override double DEXMultiplier =>
            StatisticMultiplierExtensions.GetMultiplierValue(StatisticMultiplier.Medium);
    }
}