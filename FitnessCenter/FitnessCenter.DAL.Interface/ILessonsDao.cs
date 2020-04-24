using FitnessCenter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.DAL.Interface
{
    public interface ILessonsDao
    {
        string Add(Lesson item);

        Lesson Delete(int id);

        IEnumerable<Lesson> GetById(int id);

        IEnumerable<Lesson> GetAll();

        IEnumerable<Lesson> GetAllLessonByNameHall(string idhall);

        IEnumerable<Lesson> GetAllLessonBySubNumClient(int idclient);

        IEnumerable<Lesson> GetAllLessonByPhoneCoach(long phone);

        IEnumerable<Lesson> EmploymentAllHallByDate(DateTime date);

        IEnumerable<Lesson> EmploymentAllHallByDateTime(DateTime datetime);

        IEnumerable<Lesson> EmploymentHallByDate(DateTime date, int hallid);

        IEnumerable<Lesson> EmploymentHallByDateTime(DateTime datetime, int hallid);


    }
}
