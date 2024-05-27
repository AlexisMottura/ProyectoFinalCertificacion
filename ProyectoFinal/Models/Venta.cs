using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Venta
    {
        [Key]
        public int nroVenta { get; set; }

        public DateTime fecha { get; set; }
        public Cliente? cliente { get; set; }

        public Producto? producto { get; set; }
        
        public int cantidad { get; set; }

        public double MontoVenta()
        { return cantidad * producto.precio; }
    }
}
