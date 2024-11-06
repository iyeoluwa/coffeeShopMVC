using coffeeShopMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace coffeeShopMVC.Controllers;

public class ProductController : Controller
{
    private readonly CoffeeShopContext _context;

    public ProductController(CoffeeShopContext context)
    {
        _context = context;// this line allows me to inject the dependency through the container that is available in dotnet c#. it makes writing code a lot easier for me.
    }
    
    //now it is time to access the store.
    public IActionResult Index()
    {
        var coffees = _context.Products.ToList();// this line of code converts all the coffees to lists to make it easier to manipulate.
        return View(coffees);
    }

    public IActionResult Details(int id)
    {
        var coffee = _context.Products.FirstOrDefault(c => c.Id == id);  // Fetch a single coffee by ID to show the full item in the single item page 
        if (coffee == null)
        {
            return NotFound();
        }
        return View(coffee);
    }
}