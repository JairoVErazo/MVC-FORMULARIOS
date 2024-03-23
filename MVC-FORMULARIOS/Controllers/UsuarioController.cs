using Microsoft.AspNetCore.Mvc;
using MVC_FORMULARIOS.Models;

namespace MVC_FORMULARIOS.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly MvcContext _context;

        public UsuarioController( MvcContext context)
        {
            _context = context;
        }


        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Usuario usuario)
        {

            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(usuario);

        }

    }
}
