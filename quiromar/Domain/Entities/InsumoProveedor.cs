using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class InsumoProveedor
    {
        public Insumo Insumo { get; set; }
        public int IdInsumoFk { get; set; }
        public Proveedor Proveedor { get; set; }
        public int IdProveedorFk { get; set; }
    }
}