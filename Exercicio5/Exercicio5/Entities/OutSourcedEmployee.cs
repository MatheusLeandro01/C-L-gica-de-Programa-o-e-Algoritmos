namespace Exercicio5.Entities
{
    class OutSourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutSourcedEmployee() { }

        public OutSourcedEmployee(string name, int hours, double valueperhour, double additionalCharge)
            : base(name, hours, valueperhour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;            
        }

    }
}
