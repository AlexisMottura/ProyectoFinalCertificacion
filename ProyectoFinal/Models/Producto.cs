using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
   
    public class Producto
    {

        [Key]
        public int id { get; set; }
       
        public string? descripcion { get; set; }

        public int stock { get; set; }

        public string? marca { get; set; }

        public double precio { get; set; }

        public Proveedor? proveedor { get; set; }


    }
}
