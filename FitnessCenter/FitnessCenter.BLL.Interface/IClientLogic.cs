using FitnessCenter.Entities;
using System.Collections.Generic;

namespace FitnessCenter.BLL.Interface
{
    public interface IClientLogic
    {
        int Add(Client item);

        Client GetById(int id);

        IEnumerable<Client> GetAll();

        Client Delete(int subnumber);
    }
}
