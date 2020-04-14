using FitnessCenter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.DAL.Interface
{
    public interface IClientDao
    {
        int Add(Client item);

        Client GetById(int id);

        IEnumerable<Client> GetAll();

        Client Delete(int subnumber);
    }
}
 