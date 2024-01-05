using CadastroDeProdutosUtilizandoHeranca.Entities;

namespace CadastroDeProdutosUtilizandoHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Product> listProducts = new List<Product>();

            Console.Write("Enter the number of products: ");
            int numProduts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numProduts; i++)
            {

                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine().ToUpper());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if(type == 'C')
                {
                    listProducts.Add(new Product(name, price));
                }
                else if (type == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime dateTime = DateTime.Parse(Console.ReadLine());

                    listProducts.Add(new UsedProduct(name, price, dateTime));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine());

                    listProducts.Add(new ImportedProduct(name, price, customs));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (Product product in listProducts)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}