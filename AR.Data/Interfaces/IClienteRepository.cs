using AR.Domain;

namespace AR.Data.Interfaces
{
    public interface IClienteRepository
    {
        IQueryable<Cliente> GetAll();
        Task Add(Cliente entity);
    }
}
