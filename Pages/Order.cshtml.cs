using System;
using System.Threading.Tasks;
using learning_dotnet.Data;
using learning_dotnet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace learning_dotnet.Pages
{
    public class OrderModel : PageModel
    {
        private BakeryContext db;
        public OrderModel(BakeryContext db) => this.db = db;
        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }
        public Product Product { get; set;}
        public async Task OnGetAsync() =>  Product = await db.Products.FindAsync(Id);
    }
}