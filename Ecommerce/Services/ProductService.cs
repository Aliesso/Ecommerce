using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductService
    {
        private ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Product> GetProducts()
        {
            return _context.Products.Include("ProductPictures.Picture").ToList();
        }

        public List<Product> SearchProductsFilter(string searchTearm, int? categoryID,int? minPrice,int? maxPrice, int? sortBy)
        {
            var products = _context.Products.AsQueryable();
            if (!string.IsNullOrWhiteSpace(searchTearm))
            {
                products = products.Where(x => x.Name.Contains(searchTearm));
            }
            if (categoryID.HasValue)
            {
                products = products.Where(x => x.CategoryID == categoryID);
            }


            if (minPrice.HasValue && maxPrice.HasValue)
            {
                products = products.Where(x => x.Price >= minPrice && x.Price <= maxPrice);
            }
            if (sortBy.HasValue)
            {
                switch (sortBy)
                {
                    case 1:
                        products = products.OrderByDescending(x => x.Price);
                        break;
                    case 2:
                        products = products.OrderBy(x => x.Price);
                        break;
                    case 3:
                        products = products.OrderBy(x => x.ID);
                        break;
                    default:
                        products = products.OrderByDescending(x => x.ID);
                        break;
                }
            }

            return products.Include("ProductPictures.Picture").ToList();

        }

        public List<Product> GetProductByIds(List<int> ids)
        {
            return _context.Products.Where(p => ids.Contains(p.ID)).ToList();
        }
       public Product GetProductById(int id)
        {
            return _context.Products.Include("ProductPictures.Picture").FirstOrDefault(x => x.ID == id);
        }
        public List<Product> GetFeaturedProduct()
        {
            return _context.Products.Include("ProductPictures.Picture").Where(x => x.IsFeatured).ToList();
        }
        public List<Product> ProductSameCategory(int id)
        {
            return _context.Products.Include("ProductPictures.Picture").Where(x => x.CategoryID==id).ToList();
        }
    }
}
