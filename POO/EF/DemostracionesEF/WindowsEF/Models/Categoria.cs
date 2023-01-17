using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WindowsEF.Models
{
    [Table("Categoria")]//cambiar el nombre de la tabla
    public class Categoria
    {
        //usa la convensión EF para indicar que en SQL Server la columna Id sea clave principal y autonumerica
        // Id o CategoriaId
        public int Id { get; set; }

        [Column(TypeName ="varchar")]//tipo de datos en SQL Server
        [StringLength(50)]//long de la cadena
        [Required]//es obligatorio. No acepta nulos
        public string Nombre { get; set; }

        #region propiedades de navegación
        public List<Producto> Productos { get; set; } 
        #endregion
    }
}
