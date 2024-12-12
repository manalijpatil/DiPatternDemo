using DiPatternDemo.Data;
using DiPatternDemo.Models;

namespace DiPatternDemo.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext db;
        public ProductRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public int AddProduct(Product product)
        {
            int result = 0;
            db.Products?.Add(product);
            result=db.SaveChanges();
            return result;
        }

        public int DeleteProduct(int id)
        {
            int result = 0;
            var p = db.Products.Where(x => x.ProductId == id).SingleOrDefault();
            if(p != null)
            {
                db.Products.Remove(p);
                result=db.SaveChanges();
            }
            return result;
        }

        public Product GetProductById(int id)
        {
            var res = (from p in db.Products
                      join c in db.Categories on p.CategoryId equals c.CategoryId
                      where p.ProductId == id
                      select new Product
                      {
                          ProductId = p.ProductId,
                          ProductName = p.ProductName,
                          Price = p.Price,
                          CategoryId=p.CategoryId,
                          CategoryName=p.CategoryName,
                          ImageUrl=p.ImageUrl
                      }).FirstOrDefault();
            return res;
        }

        public IEnumerable<Product> GetProducts()
        {
            var result = (from p in db.Products
                         join c in db.Categories on p.CategoryId equals c.CategoryId
                         select new Product
                         {
                             ProductId = p.ProductId,
                             ProductName = p.ProductName,
                             Price = p.Price,
                             CategoryId = c.CategoryId,
                             CategoryName = c.CategoryName,
                             ImageUrl = p.ImageUrl,
                         }).ToList();
            return result;
        }

        public int UpdateProduct(Product product)
        {
            int result = 0;
            var p = db.Products?.Where(x => x.ProductId == product.ProductId).SingleOrDefault();
            if (p != null)
            {
                //db.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                p.ProductName = product.ProductName;
                p.Price = product.Price;
                p.CategoryId = product.CategoryId;
                p.ImageUrl= product.ImageUrl;
                result = db.SaveChanges();
            }
            return result;
        }
    }
}
