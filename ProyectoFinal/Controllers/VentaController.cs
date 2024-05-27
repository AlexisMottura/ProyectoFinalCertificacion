using Microsoft.AspNetCore.Mvc;
using ProyectoFinal.Data;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    public class VentaController : Controller
    {
        private readonly ProyectoFinalDbContext _context;

        public VentaController(ProyectoFinalDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NuevaVenta()
        {
            return View();
        }

        //Metodo post
        [HttpPost]
        public async Task<IActionResult> NuevaVenta(Venta venta)
        {
            if (ModelState.IsValid)
            { 
                
                    _context.Venta.Add(venta);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                
                
               
            }
            return View(venta);
        }
    }
}
