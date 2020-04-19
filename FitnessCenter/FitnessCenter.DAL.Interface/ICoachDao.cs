using FitnessCenter.Entities;
using System;
using System.Collections.Generic;

namespace FitnessCenter.DAL.Interface
{
    public interface ICoachDao
    {
        string Add(Coach item);

        Coach Delete(long phone);

        Coach GetById(int id);

        Coach GetByPhone(long phone);

        IEnumerable<Coach> GetByLastName(string lastname);

        IEnumerable<Coach> GetAll();
        
    }
}
