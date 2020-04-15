using FitnessCenter.Entities;
using System.Collections.Generic;

namespace FitnessCenter.DAL.Interface
{
    public interface IClientDao
    {
        int Add(Client item);

        Client Delete(int subnumber);

        Client GetById(int id);

        Client GetBySubNumber(int id);

        IEnumerable<Client> GetByLastName(string lastname);

        IEnumerable<Client> GetAll();

        


    }
}
 