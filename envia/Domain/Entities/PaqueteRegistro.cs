using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PaqueteRegistro : BaseEntity
    {
        public Paquete Paquete { get; set; }
        public int IdPaqueteFk { get; set; }
        public DateOnly FechaRegistro { get; set; }
        public int NumeroGuia { get; set; }
        public Direccion Direccion { get; set; }
        public int IdDireccionFk { get; set; }
    }
}