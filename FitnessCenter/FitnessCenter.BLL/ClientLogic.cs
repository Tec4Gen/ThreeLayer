using FitnessCenter.BLL.Interface;
using FitnessCenter.DAL.Interface;
using FitnessCenter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter
{
    public class ClientLogic : IClientLogic
    {
        private IClientDao _clinetdao;
        public ClientLogic(IClientDao clinetdao)
        {
            _clinetdao = clinetdao;
        }

        public int Add(Client item)
        {
            return _clinetdao.Add(item);
        }

        public IEnumerable<Client> GetAll()
        {
            return _clinetdao.GetAll();
        }

        public Client GetById(int id)
        {
            return _clinetdao.GetById(id);
        }
    }
}
