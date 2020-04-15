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

            //clinetLogic.Add(new Client()
            //{
            //    FirstName = "Иван",
            //    LastName = "Иванов",
            //    MiddleName = "Петрович",
            //    SubscriptionNumber = 569871,
            //    //IdCoach = NULL
            //});

            //Client a;

            var a = clinetLogic.Delete(1111);
            //Console.WriteLine($"{a.Id}|{a.FirstName}|{a.LastName}|{a.MiddleName}|{a.SubscriptionNumber}|{a.IDCoach}");

            //a = clinetLogic.Delete(11111);


            //var ClientAll = clinetLogic.GetAll();


            //foreach (var item in a)
            //{
            //    Console.WriteLine($"{item.Id}|{item.FirstName}|{item.LastName}|{item.MiddleName}|{item.SubscriptionNumber}|{item.IDCoach}");
            //}




        }
    }
}