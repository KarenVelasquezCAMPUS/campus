using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class ApiPushUpEnviaBackendContext : DbContext
    {
        public ApiPushUpEnviaBackendContext(DbContextOptions<ApiPushUpEnviaBackendContext> options) : base(options)
        {
        }

        public DbSet<Barrio> Barrios { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<CodigoPostal> CodigoPostales { get; set; }
        public DbSet<Continente> Continentes { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<EstadoPaquete> EstadoPaquetes { get; set; }
        public DbSet<HistorialEnvios> HistorialEnvioss { get; set; }
        public DbSet<Kilometro> Kilometros { get; set; }
        public DbSet<NumeroCasa> NumeroCasas { get; set; }
        public DbSet<NumeroDireccion> NumeroDirecciones { get; set; }
        public DbSet<NumeroPuerta> NumeroPuertas { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Paquete> Paquetes { get; set; }
        public DbSet<PaqueteEnvio> PaqueteEnvios { get; set; }
        public DbSet<Piso> Pisos { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Pueblo> Pueblos { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        public DbSet<TipoDireccion> TipoDirecciones { get; set; }
        public DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public DbSet<TipoVivienda> TipoViviendas { get; set; }
        public DbSet<Vereda> Veredas { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Set<T>()
        {
            throw new NotImplementedException();
        }
    }
}