using ApiLocadora.Repository;
using ApiLocadora.Model;
using System.Collections.Generic;

namespace ApiLocadora.Business.Implementations
{
    public class LocacaoBusinessImplementation : ILocacaoBusiness
    {
        private readonly IRepository<Locacao> _repository;

        public LocacaoBusinessImplementation(IRepository<Locacao> repository)
        {
            _repository = repository;
        }

        // Method responsible for returning all people,
        public List<Locacao> FindAll()
        {
            return _repository.FindAll();
        }

        // Method responsible for returning one Filme by ID
        public Locacao FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        // Method responsible to crete one new Filme
        public Locacao Create(Locacao locacao)
        {
            return _repository.Create(locacao);
        }

        // Method responsible for updating one Filme
        public Locacao Update(Locacao locacao)
        {
            return _repository.Update(locacao);
        }

        // Method responsible for deleting a Filme from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
