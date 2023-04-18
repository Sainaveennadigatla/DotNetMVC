using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razorpages.Data;
using Razorpages.Models;

namespace Razorpages.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class checkoutModel : PageModel
    {
        
        public string PizzaName { get; set; }
        public float Pizzaprice { get; set; }
        public string ImageTitle { get; set; }


        private readonly RazorDBcontext _context;
        public checkoutModel(RazorDBcontext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }
            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = Pizzaprice;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();

        }
    }
}
