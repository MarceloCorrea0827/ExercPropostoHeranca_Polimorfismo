using System.Globalization;

namespace ExercPropHerPolim.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " (Customs fee: $" + CustomFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
