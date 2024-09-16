using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PaqueteEnvio : BaseEntity
    {
        public PaqueteRegistro PaqueteRegistro { get; set; }
        public int IdPaqueteRegistroFk { get; set; }
        public DateOnly FechaEnvio { get; set; }
        public DateOnly FechaEntega { get; set; }
        public double CostoEnvio { get; set; }
        public EstadoPaquete EstadoPaquete { get; set; }
        public int IdEstadoPaqueteFk { get; set; }
    }
}