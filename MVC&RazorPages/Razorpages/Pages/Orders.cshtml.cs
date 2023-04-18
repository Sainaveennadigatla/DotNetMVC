using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razorpages.Data;
using Razorpages.Models;

namespace Razorpages.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrder> pizzaOrders =new List<PizzaOrder>();
        private readonly RazorDBcontext _context;

        public OrdersModel(RazorDBcontext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            pizzaOrders = _context.PizzaOrders.ToList();
        }
    }
}
