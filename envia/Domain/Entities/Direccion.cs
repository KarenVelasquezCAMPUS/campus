using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Direccion : BaseEntity
    {
        public Continente Continente { get; set; }
        public int IdContinenteFk { get; set; }
        public Pais Pais { get; set; }
        public int IdPaisFk { get; set; }
        public Departamento Departamento { get; set; }
        public int IdDepartamentoFk { get; set; }
        public Provincia Provincia { get; set; }
        public int IdProvinciaFk { get; set; }
        public Ciudad Ciudad { get; set; }
        public int IdCiudadFk { get; set; }
        public Pueblo Pueblo { get; set; }
        public int IdPuebloFk { get; set; }
        public Vereda Vereda { get; set; }
        public int IdVeredaFk { get; set; }
        public Barrio Barrio { get; set; }
        public int IdBarrioFk { get; set; }
        public CodigoPostal CodigoPostal { get; set; }
        public int IdCodigoPostalFk { get; set; }
        public TipoVivienda TipoVivienda { get; set; }
        public int IdTipoViviendaFk { get; set; }
        public TipoDireccion TipoDireccion { get; set; }
        public int IdTipoDireccionFk { get; set; }
        public NumeroDireccion NumeroDireccion { get; set; }
        public int IdNumeroDireccionFk { get; set; }
        public string Descripcion { get; set; }
    }
}