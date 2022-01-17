using ApiLocadora.Model;
using ApiLocadora.Repository;
using System.Collections.Generic;

namespace ApiLocadora.Business.Implementations
{
    public class ClienteBusinessImplementation : IClienteBusiness
    {
        private readonly IRepository<Cliente> _repository;

        public ClienteBusinessImplementation(IRepository<Cliente> repository)
        {
            _repository = repository;
        }

        // Method responsible for returning all people,
        public List<Cliente> FindAll()
        {
            return _repository.FindAll();
        }

        // Method responsible for returning one Cliente by ID
        public Cliente FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        // Method responsible to crete one new Cliente
        public Cliente Create(Cliente cliente)
        {
            return _repository.Create(cliente);
        }

        // Method responsible for updating one Cliente
        public Cliente Update(Cliente cliente)
        {
            return _repository.Update(cliente);
        }

        // Method responsible for deleting a Cliente from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
