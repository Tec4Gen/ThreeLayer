using FitnessCenter.BLL.Interface;
using FitnessCenter.DAL;
using FitnessCenter.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.Common
{
    public static class DependenciesResolver
    {
        public static IClientDao ClientDao { get; set; } = new ClientDao();
        public static IClientLogic ClientLogic { get; set; } = new ClientLogic(ClientDao);
    }
}
