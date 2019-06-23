using Store.Services.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Services.Controllers
{
    public class HomeController : Controller
    {
        private readonly StoreDbContext _context;

        public HomeController()
        {
            _context = new StoreDbContext();
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [HttpGet]
        public JsonResult GetAllProducts()
        {
            var temp = _context.Product.ToList();
            return Json(temp,JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetProductById(int Id)
        {
            var temp = _context.Product.Find(Id);
            return Json(temp, JsonRequestBehavior.AllowGet);
        }

        public JsonResult RegisterNewProduct(int CategoryId,int BrandId,string ModelName,string Description)
        {
            _context.Product.Add(new Models.Product()
            {
                BrandId = BrandId,
                CategoryId = CategoryId,
                Description = Description,
                ModelName = ModelName
            });
            _context.SaveChanges();
            return Json("محصول با موفقیت ثبت شد", JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAllCountry()
        {
            var temp = _context.Country.ToList();
            return Json(temp, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAllCategory()
        {
            var temp = _context.category.ToList();
            return Json(temp, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAllCompany()
        {
            var temp = _context.Company.ToList();
            return Json(temp, JsonRequestBehavior.AllowGet);
        }

    }
}
