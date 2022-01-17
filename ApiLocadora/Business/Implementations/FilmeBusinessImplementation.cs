using ApiLocadora.Model;
using ApiLocadora.Repository;
using System.Collections.Generic;

namespace ApiLocadora.Business.Implementations
{
    public class FilmeBusinessImplementation : IFilmeBusiness
    {
        private readonly IRepository<Filme> _repository;

        public FilmeBusinessImplementation(IRepository<Filme> repository)
        {
            _repository = repository;
        }

        // Method responsible for returning all people,
        public List<Filme> FindAll()
        {
            return _repository.FindAll();
        }

        // Method responsible for returning one Filme by ID
        public Filme FindByID(long id)
        {
            return _repository.FindByID(id);
        }

        // Method responsible to crete one new Filme
        public Filme Create(Filme filme)
        {
            return _repository.Create(filme);
        }

        // Method responsible for updating one Filme
        public Filme Update(Filme filme)
        {
            return _repository.Update(filme);
        }

        // Method responsible for deleting a Filme from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
