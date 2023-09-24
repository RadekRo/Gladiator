namespace Gladiator.Model.Gladiators
{
    public class Brutal : BaseGladiator
    {
        public Brutal(string type, string name) : base(type, name)
        {

        }

        protected override double HPMultiplier => throw new System.NotImplementedException();
        protected override double SPMultiplier => throw new System.NotImplementedException();
        protected override double DEXMultiplier => throw new System.NotImplementedException();
    }
}