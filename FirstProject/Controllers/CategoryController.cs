using FirstProject.Context;
using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Controllers
{
    public class CategoryController : Controller
    {
        ContextClass db = new ContextClass();

        [HttpGet]
        public IActionResult Index()
        {
            var _Categories = db.Categories;
            return View(_Categories);
        }

        [HttpGet]
        public IActionResult ViewDetails(int id)
        {
            var _Category= db.Categories.Find(id);
            if (_Category == null)
            {
                return RedirectToAction("Index");
            }
            return View(_Category);
        }

        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }
        ///## <summary>

        //
        [HttpPost]
        public IActionResult Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
 

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            var oldCategory = db.Categories.FirstOrDefault(stu => stu.CategoryId == category.CategoryId);
            if (oldCategory == null)
            {
                return RedirectToAction("Index");
            }
            //ProductId, Title, Price, Description, Quantity, ImagePath. 
            oldCategory.Name = category.Name;
            oldCategory.Description = category.Description;   
            oldCategory.CategoryId =category.CategoryId;
           
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var categoryToDelete = db.Categories.FirstOrDefault(stu => stu.CategoryId == id);
            if (categoryToDelete == null)
            {
                return RedirectToAction("Index");
            }
            db.Categories.Remove(categoryToDelete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
    