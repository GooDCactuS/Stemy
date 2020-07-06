using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Project.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Project.Controllers
{
    public class HomeController : Controller
    {
        IWebHostEnvironment _appEnvironment;

        public HomeController(IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserPictureModel model)
        {
            var file = HttpContext.Request.Form.Files[0];
            model.FilePath = "/Images/" + HttpContext.Request.Form.Files[0].FileName;
            byte[] pic = null;
            using (var binaryReader = new BinaryReader(file.OpenReadStream()))
            {
                pic = binaryReader.ReadBytes((int) file.Length);
            }

            model.Picture = pic;
            return View("UserPicture", model);
        }
    }
}