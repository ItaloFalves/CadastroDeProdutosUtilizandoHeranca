
namespace CadastroDeProdutosUtilizandoHeranca.Entities
{
    class ImportedProduct : Product
    {

        public double CustomFee { get; set; }

        public ImportedProduct() 
        {
        
        }

        public ImportedProduct(string name, double price, double customFee) : base (name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return base.Price + CustomFee;
        }

        public override string PriceTag()
        {
            return Name + " - $ " +
            TotalPrice() +
            ("(Customs fee: $ ") + CustomFee
            + ")";
          
        }

    }
}
