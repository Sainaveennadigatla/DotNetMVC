using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razorpages.Models;

namespace Razorpages.Pages
{
    public class PizzaModel : PageModel
    {
        public List<Pizzas> fakepizzadb = new List<Pizzas>()
        {
              new Pizzas(){ImageTitle="Margerita",PizzaName="Margerita",BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=199},

              new Pizzas(){ImageTitle="Bolognese",PizzaName="Bolognese",BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=999},

              new Pizzas(){ImageTitle="Carbonara",PizzaName="Carbonara",BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=599},

          //    new PizzasModel(){ImageTitle="italian",PizzaName="italian",BasePrice=99,TomatoSauce=true,Cheese=true,FinalPrice=899},

          //    new PizzasModel(){ImageTitle="italian",PizzaName="italian",BasePrice=199,TomatoSauce=true,Cheese=true,FinalPrice=699},

              new Pizzas(){ImageTitle="Hawaiian",PizzaName="Hawaiian",BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=499},

              new Pizzas(){ImageTitle="MeatFeast",PizzaName="MeatFeast",BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=799},

              new Pizzas(){ImageTitle="Mushroom",PizzaName="Mushroom",BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=099},
 
              new Pizzas(){ImageTitle="Pepperoni",PizzaName="Pepperoni",BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=399},

              new Pizzas(){ImageTitle="Seafood",PizzaName="Seafood",BasePrice=99,TomatoSauce=true,Cheese=true,FinalPrice=1099},

             // new Pizzas(){ImageTitle="Paneer",PizzaName="Chicken",BasePrice=99,TomatoSauce=true,Cheese=true,FinalPrice=299},
        };
        public void OnGet()
        {
        }
    }
}
