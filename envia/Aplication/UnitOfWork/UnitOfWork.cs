using Aplication.Repository;
using Application.Repository;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        
        private readonly ApiPushUpEnviaBackendContext _context;

        private VeredaRepository _veredas;
        private PuebloRepository _pueblos;
        private PaisRepository _paises;
        private EmailRepository _emails;
        private BarrioRepository _barrios;
        private EstadoPaqueteRepository _estadopaquetes;
        private PaqueteRepository _paquetes;
        private CiudadRepository _ciudades;
        private HistorialEnviosRepository _historialenvios;
        private PaqueteEnvioRepository _paqueteenvios;
        private TelefonoRepository _telefonos;
        private PaqueteRegistroRepository _paqueteregistros;
        private KilometroRepository _kilometros;
        private CodigoPostalRepository _codigopostales;
        private ContinenteRepository _continentes;
        private NumeroCasaRepository _numerocasas;
        private PersonaRepository _pesonas;
        private TipoDireccionRepository _tipodirecciones;
        private NumeroDireccionRepository _numerodireccion;
        private DepartamentoRepository _departamentos;
        private PisoRepository _pisos;
        private TipoDocumentoRepository _tipodocumentos;
        private TipoViviendaRepository _tipoviviendas;
        private ProvinciaRepository _provincias;
        private NumeroPuertaRepository _numeropuertas;
        private DireccionRepository _direcciones;
        private RolRepository _roles; 

        public UnitOfWork (ApiPushUpEnviaBackendContext context)
        {
            _context = context;
        }

        public IVereda Veredas
        {
            get
            {
                if (_veredas == null)
                {
                    _veredas = new VeredaRepository(_context);
                }
                return _veredas;
            }
        }

        public IRol Roles
        {
            get
            {
                if (_roles == null)
                {
                    _roles = new RolRepository(_context);
                }
                return _roles;
            }
        }

        public IPueblo Pueblos
        {
            get
            {
                if (_pueblos == null)
                {
                    _pueblos = new PuebloRepository(_context);
                }
                return _pueblos;
            }
        }

        public IPais Paises
        {
            get
            {
                if (_paises == null)
                {
                    _paises = new PaisRepository(_context);
                }
                return _paises;
            }
        }

        public IEmail Emails
        {
            get
            {
                if (_emails == null)
                {
                    _emails = new EmailRepository(_context);
                }
                return _emails;
            }
        }

        public IBarrio Barrios
        {
            get
            {
                if (_barrios == null)
                {
                    _barrios = new BarrioRepository(_context);
                }
                return _barrios;
            }
        }

        public IEstadoPaquete EstadoPaquetes
        {
            get
            {
                if (_estadopaquetes == null)
                {
                    _estadopaquetes = new EstadoPaqueteRepository(_context);
                }
                return _estadopaquetes;
            }
        }

        public IPaquete Paquetes
        {
            get
            {
                if (_paquetes == null)
                {
                    _paquetes = new PaqueteRepository(_context);
                }
                return _paquetes;
            }
        }

        public ICiudad Ciudades
        {
            get
            {
                if (_ciudades == null)
                {
                    _ciudades = new CiudadRepository(_context);
                }
                return _ciudades;
            }
        }

        public IHistorialEnvios HistorialEnvioss
        {
            get
            {
                if (_historialenvioss == null)
                {
                    _historialenvioss = new HistorialEnviosRepository(_context);
                }
                return _historialenvioss;
            }
        }

        public IPaqueteEnvio PaqueteEnvios
        {
            get
            {
                if (_paqueteenvios == null)
                {
                    _paqueteenvios = new PaqueteEnvioRepository(_context);
                }
                return _paqueteenvios;
            }
        }

        public ITelefono Telefonos
        {
            get
            {
                if (_telefonos == null)
                {
                    _telefonos = new TelefonoRepository(_context);
                }
                return _telefonos;
            }
        }

        public IPaqueteRegistro PaqueteRegistros
        {
            get
            {
                if (_paqueteregistros == null)
                {
                    _paqueteregistros = new PaqueteRegistroRepository(_context);
                }
                return _paqueteregistros;
            }
        }

        public IKilometro Kilometros
        {
            get
            {
                if (_kilometros == null)
                {
                    _kilometros = new KilometroRepository(_context);
                }
                return _kilometros;
            }
        }

        public ICodigoPostal CodigoPostales
        {
            get
            {
                if (_codigopostales == null)
                {
                    _codigopostales = new CodigoPostalRepository(_context);
                }
                return _codigopostales;
            }
        }

        public IContinente Continentes
        {
            get
            {
                if (_continentes == null)
                {
                    _continentes = new ContinenteRepository(_context);
                }
                return _continentes;
            }
        }

        public INumeroCasa NumeroCasas
        {
            get
            {
                if (_numerocasas == null)
                {
                    _numerocasas = new NumeroCasaRepository(_context);
                }
                return _numerocasas;
            }
        }

        public IPersona Personas
        {
            get
            {
                if (_personas == null)
                {
                    _personas = new PersonaRepository(_context);
                }
                return _personas;
            }
        }

        public ITipoDireccion TipoDirecciones
        {
            get
            {
                if (_tipodirecciones == null)
                {
                    _tipodirecciones = new TipoDireccionRepository(_context);
                }
                return _tipodirecciones;
            }
        }

        public INumeroDireccion NumeroDirecciones
        {
            get
            {
                if (_numerodirecciones == null)
                {
                    _numerodirecciones = new NumeroDireccionRepository(_context);
                }
                return _numerodirecciones;
            }
        }

        public IDepartamento Departamentos
        {
            get
            {
                if (_departamentos == null)
                {
                    _departamentos = new DepartamentoRepository(_context);
                }
                return _departamentos;
            }
        }

        public IPiso Pisos
        {
            get
            {
                if (_pisos == null)
                {
                    _pisos = new PisoRepository(_context);
                }
                return _pisos;
            }
        }

        public ITipoDocumento TipoDocumentos
        {
            get
            {
                if (_tipodocumentos == null)
                {
                    _tipodocumentos = new TipoDocumentoRepository(_context);
                }
                return _tipodocumentos;
            }
        }

        public ITipoVivienda TipoViviendas
        {
            get
            {
                if (_tipoviviendas == null)
                {
                    _tipoviviendas = new TipoViviendaRepository(_context);
                }
                return _tipoviviendas;
            }
        }


        public IProvincia Provincias
        {
            get
            {
                if (_provincias == null)
                {
                    _provincias = new ProvinciaRepository(_context);
                }
                return _provincias;
            }
        }

        public INumeroPuerta NumeroPuertas
        {
            get
            {
                if (_numeropuertas == null)
                {
                    _numeropuertas = new NumeroPuertaRepository(_context);
                }
                return _numeropuertas;
            }
        }

        public IDireccion Direcciones
        {
            get
            {
                if (_direcciones == null)
                {
                    _direcciones = new DireccionRepository(_context);
                }
                return _direcciones;
            }
        }


        public void Dispose()
        {
            _context.Dispose();
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
