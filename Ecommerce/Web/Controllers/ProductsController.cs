using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewModels;

namespace Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        public ProductsController(ApplicationDbContext context)
        {
            _productService = new ProductService(context);
            _categoryService = new CategoryService(context);
        }

        public IActionResult Index(string searchTearm, int? categoryID, int? minPrice, int? maxPrice, int? sortBy)
        {

            FilterProductsVM vm = new()
            {
                Products = _productService.SearchProductsFilter(searchTearm, categoryID, minPrice, maxPrice, sortBy),
                Categories=_categoryService.GetCategories(),
                CategoryID=categoryID,
                SortBy=sortBy
        };
            return View(vm);
        }
        
        //public IActionResult FilterProduct(string searchTearm, int? categoryID, int? minPrice, int? maxPrice, int? sortBy)
        //{
        //    FilterProductsVM vm = new()
        //    {
        //        Products = _productService.SearchProductsFilter(searchTearm, categoryID, minPrice, maxPrice, sortBy),
        //        Categories = _categoryService.GetCategories(),
        //        CategoryID = categoryID,
        //        SortBy = sortBy,
        //        MinPrice=minPrice,
        //        MaxPrice=maxPrice
        //    };
        //    return PartialView("_filterProducts", vm);
        //}

        public IActionResult FindProductModal(int? productId)
        {
            var product=_productService.GetProductById(productId.Value);
            return PartialView("FindModal",product);
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            ProductDetailVm vm = new ProductDetailVm();
            vm.Product = _productService.GetProductById(id.Value);
            vm.SameCategories = _productService.ProductSameCategory(vm.Product.CategoryID);
            if (vm.Product == null) return NotFound();

            return View(vm);
        }
    }
}
