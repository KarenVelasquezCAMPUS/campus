using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class HistorialEnvios : BaseEntity
    {
        public DateOnly FechaEnvio { get; set; }
        public DateOnly FechaEntrega { get; set; }
        public PaqueteEnvio PaqueteEnvio { get; set; }
        public int IdPaqueteEnvioFk { get; set; }
        public string Descripcion { get; set; }
    }
}