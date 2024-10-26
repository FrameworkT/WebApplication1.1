using Microsoft.AspNetCore.Mvc;
using WebApplication1._1.Services;

namespace WebApplication1._1.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService ps;

        public ProductsController(IProductService ps)
        {
            this.ps = ps;
        }
        public IActionResult Index()
        {
            return View(ps.GetProducts());
        }
        public IActionResult Delete(int id) 
        {

            ps.DeleteData(id);

            return RedirectToAction("Index");
        }
    }
}
