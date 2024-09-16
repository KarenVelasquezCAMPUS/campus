using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Departamento : BaseEntity
    {
        public string Nombre { get; set; }
        public Pais Pais { get; set; }
        public int IdPaisFk { get; set; }
        public ICollection<Municipio> Municipios { get; set; }
    }
}