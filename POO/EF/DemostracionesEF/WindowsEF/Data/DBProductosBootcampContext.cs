using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;
using WindowsEF.Models;
namespace WindowsEF.Data
{
    public class DBProductosBootcampContext: DbContext
    {
        //Constructor
        public DBProductosBootcampContext() : base("KeyDB") { }

        //Propiedades DBSET
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
    }
}
