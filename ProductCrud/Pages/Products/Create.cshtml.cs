using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductCrud.Data;
using ProductCrud.Models;

namespace ProductCrud.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly ProductCrudContext _db;
        public Product Product { get; set; }

        public CreateModel(ProductCrudContext db)
        {
            _db = db;
        }
        

        public void OnGet()
        {
        }

        public void OnPost(Product product)
        {
            _db.Product.Add(product);
            _db.SaveChanges();

            Response.Redirect("/");
        }
    }
}
