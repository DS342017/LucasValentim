using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            return View();
        }
        public ActionResult Adicionar()
        {
            return View();
        }
        public ActionResult Editar()
        {
            return View();
        }
        public ActionResult Deletar()
        {
            return View();
        }

    }
}
