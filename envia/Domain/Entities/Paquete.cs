using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Paquete : BaseEntity
    {
        public string Nombre { get; set; }
        public string Contenido { get; set; }
        public string Descripcion { get; set; }
        public double Peso { get; set; }
        public Persona Persona { get; set; }
        public int IdPersonaFk { get; set; }
    }
}