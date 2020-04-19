using FitnessCenter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.BLL.Interface
{
    public interface IHallLogic
    {
        string Add(Hall item);

        Hall Delete(string namehall);

        Hall GetById(int id);

        Hall GetByName(string namehall);

        IEnumerable<Hall> GetAll();
    }
}
