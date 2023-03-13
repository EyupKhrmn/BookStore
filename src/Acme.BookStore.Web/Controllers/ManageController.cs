using Microsoft.AspNetCore.Mvc;

namespace Acme.BookStore.Web.Controllers;

public class ManageController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}