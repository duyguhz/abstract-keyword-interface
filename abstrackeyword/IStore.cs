using System;
namespace abstrackeyword
{
    public interface IStore
    {
       Product[] products { get; }
       int ProductLimit { get; set; }
       double TotalIncome { get; }

        void AddProduct(Product product);
        void SellProduct(string no);


    }
}
