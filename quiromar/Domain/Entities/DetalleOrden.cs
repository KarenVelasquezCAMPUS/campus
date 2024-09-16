using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class DetalleOrden : BaseEntity
    {
        public Orden Orden { get; set; }
        public int IdOrdenFk { get; set; }
        public Prenda Prenda { get; set; }
        public int IdPrendaFk { get; set; }
        public int CantidadProducir { get; set; }
        public Couleur Couleur { get; set; }
        public int IdCouleurFk { get; set; }
        public int CantidadProducida { get; set; }
        public Estado Estado { get; set; }
        public int IdEstadoFk { get; set; }
    }
}