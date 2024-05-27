using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Data;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ProyectoFinalDbContext _context;

        public ClienteController(ProyectoFinalDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        //Crear

        public IActionResult CrearCliente() { return View(); }

        //Metodo post
        [HttpPost]
        public async Task<IActionResult> CrearCliente(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }
       
    }
}
