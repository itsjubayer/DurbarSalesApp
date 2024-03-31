using DurbarSalesApp.Shared;

namespace DurbarSalesApp.Server
{
    public class ProductService
    {
        private List<Product> _products;
        public ProductService()
        {
            _products= new List<Product>();
        }
        public List<Product> GetProducts() 
        { 
            return _products;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public void DeleteProduct(string productCode)
        {
            _products.RemoveAll(a=>a.ProductCode == productCode);
        }
    }
}
