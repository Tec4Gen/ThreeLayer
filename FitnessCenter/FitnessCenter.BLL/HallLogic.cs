using FitnessCenter.BLL.Interface;
using FitnessCenter.DAL.Interface;
using FitnessCenter.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FitnessCenter
{
    public class HallLogic : IHallLogic
    {
        private IHallDao _halldao;

        public HallLogic(IHallDao halldao) 
        {
            _halldao = halldao;
        }

        public string Add(Hall item)
        {
            return _halldao.Add(item);
        }

        public Hall Delete(string namehall)
        {
            return _halldao.Delete(namehall);
        }

        public IEnumerable<Hall> GetAll()
        {
            return _halldao.GetAll();
        }

        public Hall GetById(int id)
        {
            return _halldao.GetById(id);
        }

        public Hall GetByName(string namehall)
        {
            return _halldao.GetByName(namehall);
        }
    }
}
