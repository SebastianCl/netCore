namespace WebApplication1.Controllers
{
    using System;
    using Microsoft.AspNetCore.Mvc;
    
    public class DateController : Controller
    {
        [ResponseCache(Duration = 600)]
        public IActionResult Index()
        {
            return Content(DateTime.Now.ToShortTimeString());
        }

    }
}