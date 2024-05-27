using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Data;
using ProyectoFinal.Models;

namespace ProyectoFinal.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ProyectoFinalDbContext _context;

        public ProductoController(ProyectoFinalDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult CrearProducto() 
        {
            return View();
        }

        //Metodo post
        [HttpPost]
        public async Task<IActionResult> CrearProducto(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        //Eliminar
        
        public IActionResult EliminarProducto() 
        
        { return View(); }

       
        //Modificar

        public IActionResult ModificarProducto(Producto producto)
        { return View(); }

        //Consultar
        [HttpGet]
        public async Task<IActionResult> ConsultarProducto(int? id)
        {
            if (id == null || _context.Producto == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .FirstOrDefaultAsync(m => m.id == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }
    }
}
