using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Domain.Entities
{
    public class Pueblo : BaseEntity
    {
        public string Nombre { get; set; }
        public Departamento Departamento { get; set; }
        public int IdDepartamentoFk { get; set; }
    }
}