using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProductCrud.Data;
using ProductCrud.Models;

namespace ProductCrud.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly ProductCrudContext _db;

        public IEnumerable<Product>? Product { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }


        public IndexModel(ProductCrudContext db)
        {
            _db = db;
        }     

        public void OnGet()
        {
            IQueryable<Product> products = _db.Product;

            if (!string.IsNullOrEmpty(SearchString))
            {
                products = products.Where(p => p.Name.Contains(SearchString));
            }

            Product = products.ToList();
        }
    }
}
