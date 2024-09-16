using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class NumeroCasa : BaseEntity
    {
        public int Numero { get; set; }
        public NumeroDireccion NumeroDireccion { get; set; }
        public int IdNumeroDireccionFk { get; set; }
    }
}