using FitnessCenter.BLL.Interface;
using FitnessCenter.DAL.Interface;
using FitnessCenter.Entities;
using System.Collections.Generic;

namespace FitnessCenter
{
    public class ClientLogic : IClientLogic
    {
        private IClientDao _clientdao;
        public ClientLogic(IClientDao clinetdao)
        {
            _clientdao = clinetdao;
        }

        public string Add(Client item)
        {
            return _clientdao.Add(item);
        }
        public Client Delete(int subnumber)
        {
            return _clientdao.Delete(subnumber);
        }

        public Client GetById(int id) 
        {
            return _clientdao.GetById(id);   
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientdao.GetAll();
        }

        public Client GetBySubNumber(int subnumber)
        {
            return _clientdao.GetBySubNumber(subnumber);
        }

        public IEnumerable<Client> GetByLastName(string lastname) 
        {
            return _clientdao.GetByLastName(lastname);
        }
    }
}
