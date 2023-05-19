using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductCrud.Data;
using ProductCrud.Models;

namespace ProductCrud.Pages.Products
{
    public class DeleteModel : PageModel
    {
        private readonly ProductCrudContext _db;

        public DeleteModel(ProductCrudContext db)
        {
            _db = db;
        }
        public Product? Product { get; set; }

        public IActionResult OnGet(int id)
        {
            Product = _db.Product.Find(id);
            if (Product == null)
            {
                return NotFound();
            }

            _db.Product.Remove(Product);
            _db.SaveChanges();
            
            return RedirectToPage("Index");
        }
    }
}
