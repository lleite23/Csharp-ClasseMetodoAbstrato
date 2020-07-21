using System.Globalization;

namespace Aula_Heranca_Polimorfismo_ExercicioPratico.Entities
{
    class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee)
            :base(name,price)
        {
            this.customsFee = customsFee;
        }

        public override string priceTag()
        {
            return $"{Name} $ {totalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {customsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }

        public double totalPrice()
        {
            return Price + customsFee;
        }
    }
}
