using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_Productos.Models
{
    public class Productos
    {
        [Key]
        [Required(ErrorMessage ="Este campo no puede quedar vac&iacuteo, ingrese el id del producto")]
        [Range(1, 10000, ErrorMessage ="Este campo debe ser mayor que 0")]
        public int ProductoId { get; set; }
        [Required(ErrorMessage ="Este campo no puede quedar vac&iacuteo, ingrese la descripcion del producto")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage ="Este campo no puede quedar vac&iacuteo, ingrese la existencia del producto")]
        public int Existencia { get; set; }
        [Required(ErrorMessage ="Este campo no puede quedar vac&iacuteo, ingrese el costo del producto")]
        public float Costo { get; set; }
        public float ValorInventario { get; set; }
    }
}
