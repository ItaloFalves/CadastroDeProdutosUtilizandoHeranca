
namespace CadastroDeProdutosUtilizandoHeranca.Entities
{
     class UsedProduct : Product
    {

        public DateTime ManuFactureDate { get; set; }

        public UsedProduct() 
        {
        
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            ManuFactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $ "
                + Price.ToString("F2")
                + " (Manufacture date: "
                + ManuFactureDate.ToString("dd/MM/yyyy")
                + ")";
        }

    }
}
