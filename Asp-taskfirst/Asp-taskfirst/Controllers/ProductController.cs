using Asp_taskfirst.Models;
using Asp_taskfirst.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Asp_taskfirst.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var datas = GetAll();

            List<ProductVM> products = new List<ProductVM>();

            foreach (var item in datas)
            {
                products.Add(new ProductVM { Name = item.Name,Price=item.Price,Description=item.Description,Count=item.Count });
            }
            return View(products);
        }


        private List<Product> GetAll()
        {
            return new List<Product>()
            {
                new Product { Id = 1,Name="Samsung",Price=2000,Description="Phone",Count=20},
                new Product { Id = 2,Name="Iphone",Price=3000,Description="Phone",Count =22},
                 new Product { Id = 3,Name="LG",Price=3500,Description="Tv",Count =92}
            };
        }
    }
}
