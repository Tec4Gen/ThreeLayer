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

            Console.WriteLine(clinetLogic.GetAll());
        }
    }
}
