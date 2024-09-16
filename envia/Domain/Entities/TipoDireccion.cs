using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TipoDireccion : BaseEntity
    {
        public string Nombre { get; set; }
        public TipoVivienda TipoVivienda { get; set; }
        public int IdTipoViviendaFk { get; set; }
    }
}