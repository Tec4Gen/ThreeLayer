using FitnessCenter.Entities;
using System;
using System.Collections.Generic;

namespace FitnessCenter.BLL.Interface
{
    public interface ICoachLogic
    {
        int Add(Coach item);

        Coach Delete(long phone);

        int GetById(int id);

        Coach GetByPhone(long phone);

        IEnumerable<Coach> GetByLastName(string lastname);

        IEnumerable<Coach> GetAll();

    }
}
