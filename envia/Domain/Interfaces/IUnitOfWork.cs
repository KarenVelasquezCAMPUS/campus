namespace Domain.Interfaces;
    public interface  IUnitOfWork
    {
        IRol Roles { get; }
        IBarrio Barrios { get; }
        ICiudad Ciudades { get; }
        ICodigoPostal CodigoPostales { get; }
        IContinente Continentes { get; }
        IDepartamento Departamentos { get; }
        IDireccion Direcciones { get; }
        IEmail Emails { get; }
        IEstadoPaquete EstadoPaquetes { get; }
        IHistorialEnvios HistorialEnvioss { get; }
        IKilometro Kilometros { get; }
        INumeroCasa NumeroCasas { get; }
        INumeroDireccion NumeroDirecciones { get; }
        IPais Paises { get; }
        IPaquete Paquetes { get; }
        IPaqueteEnvio PaqueteEnvios { get; }
        IPaqueteRegistro PaqueteRegistros { get; }
        IPersona Personas { get; }
        IPiso Pisos { get; }
        IProvincia Provincias { get; }
        IPueblo Pueblos { get; }
        ITelefono Telefonos { get; }
        ITipoDireccion TipoDirecciones { get; }
        ITipoDocumento TipoDocumentos { get; }
        ITipoVivienda TipoViviendas { get; }
        IVereda Veredas { get; }
        Task<int> SaveAsync();
    }