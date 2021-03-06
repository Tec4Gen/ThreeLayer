﻿using FitnessCenter.BLL.Interface;
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

        public string Add(Lesson item)
        {
            return _lessonsDao.Add(item);
        }

        public Lesson Delete(int id)
        {
            return _lessonsDao.Delete(id);
        }

        public IEnumerable<Lesson> EmploymentAllHallByDate(DateTime date)
        {
            return _lessonsDao.EmploymentAllHallByDate(date);
        }

        public IEnumerable<Lesson> EmploymentAllHallByDateTime(DateTime datetime)
        {
            return _lessonsDao.EmploymentAllHallByDateTime(datetime);
        }

        public IEnumerable<Lesson> EmploymentHallByDate(DateTime time,int hallid)
        {
            return _lessonsDao.EmploymentHallByDate(time,hallid);
        }

        public Lesson EmploymentHallByDateTime(DateTime datetime, int hallid)
        {
            return _lessonsDao.EmploymentHallByDateTime(datetime, hallid);
        }

        public IEnumerable<Lesson> GetAll()
        {
            return _lessonsDao.GetAll();
        }

        public IEnumerable<Lesson> GetAllLessonByNameHall(string namehall)
        {
            return _lessonsDao.GetAllLessonByNameHall(namehall);
        }

        public IEnumerable<Lesson> GetAllLessonByPhoneCoach(long phone)
        {
            return _lessonsDao.GetAllLessonByPhoneCoach(phone);
        }

        public IEnumerable<Lesson> GetAllLessonBySubNumClient(int idclient)
        {
            return _lessonsDao.GetAllLessonBySubNumClient(idclient);
        }

        public Lesson GetById(int id)
        {
            return _lessonsDao.GetById(id);
        }
    }
}
