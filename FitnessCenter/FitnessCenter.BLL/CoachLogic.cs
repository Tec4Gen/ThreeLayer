using FitnessCenter.BLL.Interface;
using FitnessCenter.DAL.Interface;
using FitnessCenter.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessCenter
{
    public class CoachLogic : ICoachLogic
    {
        private ICoachDao _coachDao;
        public CoachLogic(ICoachDao coachdao) 
        {
            _coachDao = coachdao;
        }
        public int Add(Coach item)
        {
            return _coachDao.Add(item);
        }

        public Coach Delete(long phone)
        {
            return _coachDao.Delete(phone);
        }

        public IEnumerable<Coach> GetAll()
        {
            return _coachDao.GetAll();
        }

        public int GetById(int id)
        {
            return _coachDao.GetById(id);
        }

        public IEnumerable<Coach> GetByLastName(string lastname)
        {
            return _coachDao.GetByLastName(lastname);
        }

        public Coach GetByPhone(long phone)
        {
            return _coachDao.GetByPhone(phone);
        }
    }
}
