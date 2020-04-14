﻿using FitnessCenter.Common;
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
            //    SubscriptionNumber = 56987,
            //    //IdCoach = NULL
            //});
            Client a;

            a = clinetLogic.Delete(11111);
            Console.WriteLine($"{a.Id}|{a.FirstName}|{a.LastName}|{a.MiddleName}|{a.SubscriptionNumber}|{a.IDCoach}");

            //var ClientAll = clinetLogic.GetAll();


            //foreach (var item in ClientAll)
            //{
            //    Console.WriteLine($"{item.Id}|{item.FirstName}|{item.LastName}|{item.MiddleName}|{item.SubscriptionNumber}|{item.IDCoach}");
            //}




        }
    }
}