namespace Exercicio6.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double customsFee)
            :base(name, price)
        {
            CustomsFee = customsFee;
        }
        public override string PriceTag()
        {
            return $"{Name} $ {TotalPrice().ToString("F2")} (Customs fee: ${CustomsFee.ToString("F2")})";
        }
        public double TotalPrice()
        {
            return CustomsFee + Price;
        }
    }
}
