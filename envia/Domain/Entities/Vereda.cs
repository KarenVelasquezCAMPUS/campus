using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Vereda : BaseEntity
    {
        public string Nombre { get; set; }
        public Departamento Departamento { get; set; }
        public int IdDepartamentoFk { get; set; }
    }
}