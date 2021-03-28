using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class FeaturedProductsViewComponent:ViewComponent
    {
        private readonly ProductService _productService;

        public FeaturedProductsViewComponent(ApplicationDbContext context)
        {
            _productService = new ProductService(context);
        }
        public ViewViewComponentResult Invoke()
        {
            return View(_productService.GetFeaturedProduct());
        }
    }
}
