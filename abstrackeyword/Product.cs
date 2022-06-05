using System;
namespace abstrackeyword
{
    public class Product:IStore
    {
        private Product[] _products;
        public string Name;
        public double Price;
        public int Count;



        public Product[] products { get => _products; }

        public int ProductLimit { get ; set ; }
        private double _totalIncome;

        public double TotalIncome => _totalIncome;

        public string Length { get;  set; }




        public void AddProduct(Product product)
        {
            if (ProductLimit>_products.Length)
            {
                Array.Resize(ref _products, 1);
            }
        }


        public void SellProduct(string no)
        {
            for (int i = 0; i < _products.Length; i++)
            {
                if (no == _products[i].Length && Count!=0)
                {
                    _totalIncome++;
                    Count--;

                }
            }
            

            
        }
    }
}
