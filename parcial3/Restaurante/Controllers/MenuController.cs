using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurante.Data;
using Restaurante.Models;

namespace Restaurante.Controllers;

public class MenuController : Controller
{
   
    private readonly ILogger<MenuController> _logger;
     private readonly ApplicationDbContext _context;
    public MenuController(ILogger<MenuController> logger,ApplicationDbContext context )
    {
        _logger = logger;
        _context=context;

    }
    public  ActionResult Index()
    {
        return View("Menu.cshtml");
    
    }
    public ActionResult Menu()
    {
        return View();

    }


}
