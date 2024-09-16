using Application.Repository;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        
        private readonly ApiPushUpQuiomarContext _context;

        //private CargoRepository _cargos;

     public UnitOfWork (ApiPushUpQuiomarContext context)
        {
            _context = context;
        }

        // Controll de nulos para los repositorios

        /* public ICargo Cargos
        {
            get
            {
                if (_cargos == null)
                {
                    _cargos = new CargoRepository(_context);
                }
                return _cargos;
            }
        } */

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
