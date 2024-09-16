using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Insumo : BaseEntity
    {
        public string Nombre { get; set; }
        public double ValorUnit { get; set; }
        public double StockMin { get; set; }
        public double StockMax { get; set; }
        public ICollection<InsumoPrenda> InsumoPrendas { get; set; }
        public ICollection<InsumoProveedor> InsumoProveedores { get; set; }
    }
}