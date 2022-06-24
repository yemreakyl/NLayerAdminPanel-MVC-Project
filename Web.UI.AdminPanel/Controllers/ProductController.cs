using BLL.Dtos;
using BLL.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.UI.AdminPanel.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View(ProductWorker.GetProducts());
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: Urun/Edit/5
        public ActionResult CreateOrEdit(int? id)
        {
            //Html tarafında dropdown (select) etiketini doldurmak için yazılır.
            ViewBag.SubCategories = ProductWorker.GetSubCategories();
            if (id != null)
            {
                return View(ProductWorker.GetProductDetails((int)id));
            }
            else
            {
                return View();
            }
        }
        // POST: Urun/Edit/5
        [HttpPost]
        public ActionResult CreateOrEdit(int? id, ProductDetail model)
        {

            if (id == null)
            {
                ProductWorker.AddProduct(model);
            }
            else
            {
                ProductWorker.UpdateProduct(model);
            }

            return RedirectToAction("Index");
        }

  

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            ProductWorker.ProductDeleteOrUndo(id);
            return RedirectToAction("Index");
        }

     
        public ActionResult Activate(int ıd)
        {
            ProductWorker.ChangeItemActivate(ıd);
            return RedirectToAction("Index");
        }
    }
}
