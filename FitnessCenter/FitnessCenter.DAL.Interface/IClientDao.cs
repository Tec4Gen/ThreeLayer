using FitnessCenter.Entities;
using System.Collections.Generic;

namespace FitnessCenter.DAL.Interface
{
    public interface IClientDao
    {
        string Add(Client item);

        string Update(int subnumber, int idcoach);

        Client Delete(int subnumber);

        Client GetById(int id);

        Client GetBySubNumber(int id);

        IEnumerable<Client> GetByLastName(string lastname);

        IEnumerable<Client> GetAll();

    }
}
 