using System.Collections.Generic;
using System.Linq;
using BlazingShop.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazingShop.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _dbContext;
        public ProductService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Product GetProduct(int id)
        {
            return _dbContext.Products.Include(p => p.Category).FirstOrDefault(c => c.Id == id);
        }

        public List<Product> GetProducts()
        {
            return _dbContext.Products.Include(p => p.Category).ToList();
        }

        // In linking the Category to a certain Product, we will use this method. Note! We can use the Product Service too if desired
        // but it will add another DI setting.
        public List<Category> GetCategoryList()
        {
            return _dbContext.Categories.ToList();
        }

        public bool CreateProduct(Product objProduct)
        {
            _dbContext.Products.Add(objProduct);
            return _dbContext.SaveChanges() > 0;
        }

        public bool UpdateProduct(Product objProduct)
        {
            var dbProduct = _dbContext.Products.FirstOrDefault(c => c.Id == objProduct.Id);
            if (dbProduct != null)
            {
                dbProduct.Name = objProduct.Name ?? dbProduct.Name;
                dbProduct.Price = objProduct.Price;
                dbProduct.Image = objProduct.Image ?? dbProduct.Image;    
                dbProduct.ShadeColor = objProduct.ShadeColor ?? dbProduct.ShadeColor;    

                _dbContext.Products.Update(dbProduct);
                return _dbContext.SaveChanges() >= 0;
            }
            return false;
        }

        public bool DeleteProduct(Product objProduct)
        {
            var dbProduct = _dbContext.Products.FirstOrDefault(c => c.Id == objProduct.Id);
            if (dbProduct != null)
            {
                _dbContext.Products.Remove(dbProduct);
                return _dbContext.SaveChanges() > 0;
            }
            return false;
        }


    }
}