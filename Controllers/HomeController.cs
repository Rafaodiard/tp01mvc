using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp01.Models;

namespace tp01.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    Grupo grupo = new Grupo();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.grupo = grupo.devolverIntegrantes();
        return View();
    }

    public IActionResult SelectIntegrante(int dni)
    {
        ViewBag.grupo = grupo.devolverIntegrante(dni);
        return View("infoIntegrante");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
