using System.Diagnostics;
using demomvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace demomvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Demo()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Demo(string FullName, string Address)
    {
        string strResult = "Hello " + FullName + "-" + Address;
    ViewBag.thongBao = strResult;
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModels { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
