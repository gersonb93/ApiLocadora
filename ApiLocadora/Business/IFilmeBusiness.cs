using ApiLocadora.Model;
using System.Collections.Generic;

namespace ApiLocadora.Business
{
   public interface IFilmeBusiness
    {
        Filme Create(Filme filme);
        Filme FindByID(long id);
        List<Filme> FindAll();
        Filme Update(Filme filme);
        void Delete(long id);
    }

}
