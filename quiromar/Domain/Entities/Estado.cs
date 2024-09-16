using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Estado : BaseEntity
    {
        public string Descripcion { get; set; }
        public TipoEstado TipoEstado { get; set; }
        public int IdTipoEstadoFk { get; set; }
        public ICollection<Estado> Estados { get; set; }
        public ICollection<Orden> Ordenes { get; set; }
        public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
    }
}