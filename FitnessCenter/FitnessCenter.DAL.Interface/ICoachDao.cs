using FitnessCenter.Entities;

namespace FitnessCenter.DAL.Interface
{
    interface ICoachDao
    {
        int Add(Client item);

        Coach Delete(ulong phone);

        int GetById(int id);

        Coach GetByPhone(ulong phone);
    }
}
