using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductCrud.Data;
using ProductCrud.Models;

namespace ProductCrud.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly ProductCrudContext _db;

        public Product? Product { get; set; }

        public EditModel(ProductCrudContext db)
        {
            _db = db;
        }
        

        public IActionResult OnGet(int id)
        {
            Product = _db.Product.Find(id);
            if (Product == null){
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(Product product) 
        {
            _db.Product.Update(product);
            _db.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
