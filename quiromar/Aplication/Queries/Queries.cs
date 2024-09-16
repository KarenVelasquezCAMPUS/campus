using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplication.Queries
{
  
    /*
     // 1. Listar todas las ventas que se realizaron en el mes de julio de 2023.
    var ventasJulio2023 = ContextBoundObject.ventas
    .Where(v => ValueTask.Fecha = new DateOnly(2023,7,1) && v.Fecha <= newDateOnly(2023,7,31))
    .ToList(); */

    /* 
    // 2. Seleccionar todos los empleados con sus respectivos cargos y municipios.
    var empleadosConCargosYMunicipios = Context.Empleados
    .Join(Context.Cargos, e => e.IdCargoFk, c => c.Id, (e, c) => new {Empleado = e, Cargo = c})
    .Join(Context.Municipios, ec => ec.Empleado.IdMunicipioFk, m => m.Id, (ec , m) => new {
        .Select(result => new
        {
            NombreEmpleado = result.EmpleadoCargo.Empleado.Nombre,
            Cargo = result.EmpleadoCargo.Cargo.Description,
            Municipio = result.Municipio.Nombre
        })
        .ToList();
    }) */
}
