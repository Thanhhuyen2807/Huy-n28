using System.Diagnostics;
<<<<<<< HEAD
using Microsoft.AspNetCore.Mvc;
using demomvc.Models;
using System.Net.Sockets;
=======
using demomvc.Models;
using Microsoft.AspNetCore.Mvc;
>>>>>>> parent of fc2878c (commit note)

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
<<<<<<< HEAD
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
=======
        return View(new ErrorViewModels { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
>>>>>>> parent of fc2878c (commit note)
    }
}
