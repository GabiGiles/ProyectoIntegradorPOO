using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WindowsEF.Models
{
 
    [Table("Producto")]
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }


        [Column(TypeName = "varchar")]//tipo de datos en SQL Server
        [StringLength(50)]//long de la cadena
        [Required]//es obligatorio. No acepta nulos
        public string Nombre { get; set; }

        [Column(TypeName = "money")]
        public decimal Precio { get; set; }


        [Column(TypeName = "char")]//tipo de datos en SQL Server
        [StringLength(1)]//long de la cadena
        public string LineaProducto { get; set; }

        public int CatId { get; set; }

        #region propiedades de navegación
        [ForeignKey("CatId")]
        public Categoria Categoria { get; set; }
        #endregion
    }
}
