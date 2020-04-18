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
    public class LessonsLogic : ILessonsLogic
    {
        private ILessonsDao _lessonsDao;
        public LessonsLogic(ILessonsDao lessonsDao) 
        {
            _lessonsDao = lessonsDao;
        }

        public string Add(Lessons item)
        {
            return _lessonsDao.Add(item);
        }
    }
}
