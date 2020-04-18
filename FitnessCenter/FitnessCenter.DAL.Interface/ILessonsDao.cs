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
        string Add(Lessons item);
    }
}
