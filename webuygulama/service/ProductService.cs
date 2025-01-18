using webuygulama.context;
using webuygulama.entity;
using webuygulama.Models;

namespace webuygulama.service
{
    public class ProductService : IProductService
    {
        NorthwindContext _context;
        public ProductService(NorthwindContext context)
        {
            _context = context;
        }
        public List<ProductModel> getProducts()
        {
            List<Product> products = _context.Products.ToList();
            List<ProductModel> productsModel = new List<ProductModel>();
            foreach (var product in products)
            {
                productsModel.Add(new ProductModel
                {
                    ad = product.ProductName,
                    Id = product.ProductId
                });
            }
            return productsModel;
        }
    }
}
