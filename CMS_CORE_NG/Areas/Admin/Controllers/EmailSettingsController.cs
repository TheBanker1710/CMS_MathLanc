using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS_CORE_NG.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmailSettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
