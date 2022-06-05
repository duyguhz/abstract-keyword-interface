using System;
namespace abstrackeyword
{
    public class Market : IStore
    {
        public Product[] products;

        public int ProductLimit { get; set; }

        public double TotalIncome;

        public void AddProduct(Product product)
        {
            
        }
        public void SellProduct(string no)
        {

        }
        
    }
}
