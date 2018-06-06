using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyEcomerce.Models;

namespace MyEcomerce.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {


            return View();
        }



        public IActionResult Criar()
        {
            
            return View();
        }


        public ActionResult Salvar(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario));
            }

            return RedirectToAction(nameof(Index));
        }
    }
}