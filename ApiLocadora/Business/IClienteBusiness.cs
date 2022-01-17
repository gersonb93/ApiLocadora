using ApiLocadora.Model;
using System.Collections.Generic;

namespace ApiLocadora.Business
{
    public interface IClienteBusiness
    {
        Cliente Create(Cliente cliente);
        Cliente FindByID(long id);
        List<Cliente> FindAll();
        Cliente Update(Cliente cliente);
        void Delete(long id);
    }
}
