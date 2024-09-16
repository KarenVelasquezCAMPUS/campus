namespace Domain.Interfaces;
    public interface  IUnitOfWork
    {
        //ICargoRepository Cargos { get; }
        Task<int> SaveAsync();
    }

