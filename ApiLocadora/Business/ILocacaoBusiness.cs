using ApiLocadora.Model;
using System.Collections.Generic;

namespace ApiLocadora.Business
{
   public interface ILocacaoBusiness
    {
        Locacao Create(Locacao locacao);
        Locacao FindByID(long id);
        List<Locacao> FindAll();
        Locacao Update(Locacao locacao);
        void Delete(long id);
    }
}
