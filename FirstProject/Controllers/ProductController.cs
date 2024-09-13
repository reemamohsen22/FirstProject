using FirstProject.Context;
using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Controllers
{
    public class ProductController : Controller
    {
        ContextClass db = new ContextClass();

        [HttpGet]
        public IActionResult Index()
        {
            // View Model
            var allProducts = db.Products.Include(stu => stu.Category);
            return View(allProducts);
        }

        [HttpGet]
        public IActionResult ViewDetails(int id)
        {
            var product = db.Products.Include(stu => stu.Category).FirstOrDefault(stu => stu.ProductId == id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag._Categories = new SelectList(db.Categories.ToList(), "CategoryId", "Name" ,"Description");
            return View();
        }


        [HttpPost]
        public IActionResult Create(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var oldProduct = db.Products.Include(e => e.Category).FirstOrDefault(stu => stu.ProductId == id);
            if (oldProduct == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Categories = new SelectList(db.Categories, "CategoryId", "Name", "Description");
            return View(oldProduct);
        }


        [HttpPost]
        public IActionResult Edit(Product product)
        {
            var oldProduct = db.Products.FirstOrDefault(stu => stu.ProductId == product.ProductId);
            if (oldProduct == null)
            {
                return RedirectToAction("Index");
            }
            //ProductId, Title, Price, Description, Quantity, ImagePath. 
            oldProduct.Title = product.Title;
            oldProduct.Price = product.Price;
            oldProduct.Description = product.Description;
            oldProduct.Quantity = product.Quantity;
            oldProduct.ProductId = product.ProductId;
            oldProduct.ProductId = product.ProductId;
            oldProduct.ImagePath = product.ImagePath;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var productToDelete = db.Products.FirstOrDefault(stu => stu.ProductId == id);
            if (productToDelete == null)
            {
                return RedirectToAction("Index");
            }
            db.Products.Remove(productToDelete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
