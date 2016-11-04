using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Entity;
using System.Web.Mvc;
using RazorPDF;
using PrintumCommerce.Models;
using PrintumCommerce.ClassHelper;
namespace PrintumCommerce.Controllers
{
    public class HomeController : Controller
    {

        private DBPrintumContext db = new DBPrintumContext();
      
        public ActionResult PDF()
        {
            PdfResult a;
            var users = db.Users.Include(u => u.City).Include(u => u.Company).Include(u => u.DepartmentModel);
            try
            {
                 a= new PdfResult(users.ToList(), "PDF");

                return a;
               //return View(users.ToList());
            }
            catch (Exception e)
            {
                return null;
                ModelState.AddModelError(string.Empty, "Error pdf");

            }
      
            ///return View();

        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



    }
}