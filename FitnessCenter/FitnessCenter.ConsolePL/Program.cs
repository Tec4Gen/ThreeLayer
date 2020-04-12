using FitnessCenter.Common;
using FitnessCenter.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {
            var clinetLogic = DependenciesResolver.ClientLogic;
            var a = clinetLogic.GetAll();
            foreach (var item in a)
            {
                Console.WriteLine($"{item.Id}|{item.Firstname}|{item.LastName}|{item.MiddleName}|{item.SubscriptionNumber}|{item.IDCoach}");
            }
        }
    }
}
