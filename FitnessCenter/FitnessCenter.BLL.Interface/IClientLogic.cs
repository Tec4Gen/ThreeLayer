using FitnessCenter.Entities;
using System.Collections.Generic;

namespace FitnessCenter.BLL.Interface
{
    public interface IClientLogic
    {
        string Add(Client item);

        Client Delete(int subnumber);

        Client GetById(int id);

        Client GetBySubNumber(int subnumber);

        IEnumerable<Client> GetByLastName(string lastname);

        IEnumerable<Client> GetAll();

    }
}
