using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razorpages.Models;

namespace Razorpages.Pages.forms
{
    public class CustompizzaorderModel : PageModel
    {
        [BindProperty]
        public Pizzas Pizza { get; set; }
        public float Pizzaprice { get; set; }   
        public void OnGet()
        {
        }
        public IActionResult OnPost() 
        {
            Pizzaprice = Pizza.BasePrice;
            if (Pizza.TomatoSauce) Pizzaprice += 1;
            if (Pizza.Tuna) Pizzaprice += 1;
            if (Pizza.Cheese) Pizzaprice += 1;
            if (Pizza.Ham) Pizzaprice += 1;
            if (Pizza.Pineapple) Pizzaprice += 10;
            if (Pizza.peperoni) Pizzaprice += 1;
            if (Pizza.Meat) Pizzaprice += 1;
            if (Pizza.Mushroom) Pizzaprice += 1;

            return RedirectToPage("/checkout/checkout", new {Pizza.PizzaName, Pizzaprice});
        }

    }
}
