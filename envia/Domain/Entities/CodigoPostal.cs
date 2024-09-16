using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CodigoPostal : BaseEntity
    {
        public string Nombre { get; set; }
        public Ciudad Ciudad { get; set; }
        public int IdCiudadFk { get; set; }
        public Pueblo Pueblo { get; set; }
        public int IdPuebloFk { get; set; }
    }
}