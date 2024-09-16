using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TipoVivienda : BaseEntity
    {
        public string Nombre { get; set; }
        public Barrio Barrio { get; set; }
        public int IdBarrioFk { get; set; }
    }
}