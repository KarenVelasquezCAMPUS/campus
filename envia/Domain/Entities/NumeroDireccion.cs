using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class NumeroDireccion : BaseEntity
    {
        public int Numero { get; set; }
        public string Bis { get; set; }
        public TipoDireccion TipoDireccion { get; set; }
        public int IdTipoDireccionFk { get; set; }
    }
}