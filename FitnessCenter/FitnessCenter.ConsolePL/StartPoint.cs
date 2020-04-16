﻿using FitnessCenter.Common;
using FitnessCenter.Entities;
using System;

namespace FitnessCenter.ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {

            //var clinetLogic = DependenciesResolver.ClientLogic;
            var coachLogic = DependenciesResolver.CoachLogic;

            //coachLogic.Add(new Coach()
            //{
            //    FirstName = "Иван",
            //    LastName = "Иванов",
            //    MiddleName = "Петрович",
            //    Phone = 9172006302,
            //    //IdCoach = NULL
            //});

            //coachLogic.Add(new Coach()
            //{
            //    FirstName = "Андрей",
            //    LastName = "Попов",
            //    MiddleName = "Юрьевич",
            //    Phone = 9256987741,
            //});

            //coachLogic.Add(new Coach()
            //{
            //    FirstName = "Алексей",
            //    LastName = "Ионов",
            //    MiddleName = "Серьгеевич",
            //    Phone = 9172456566,
            //});

            //coachLogic.Add(new Coach()
            //{
            //    FirstName = "Олег",
            //    LastName = "Игнатьев",
            //    MiddleName = "Игоревич",
            //    Phone = 9201495878,
            //});



            // var  a = coachLogic.Delete(9172006302);
            // Console.WriteLine($"{a.Id}|{a.FirstName}|{a.LastName}|{a.MiddleName}|{a.Phone}");

            //a = clinetLogic.Delete(11111);


            //var ClientAll = clinetLogic.GetAll();
            //var all = coachLogic.GetAll();

            //foreach (var item in all)
            //{
            //    Console.WriteLine($"{item.Id}|{item.FirstName}|{item.LastName}|{item.MiddleName}|{item.Phone}");
            //}
            //Console.WriteLine();

           // var a = coachLogic.GetByPhone(9172456566);

            //foreach (var item in a)
            //{
            //    Console.WriteLine($"{item.Id}|{item.FirstName}|{item.LastName}|{item.MiddleName}|{item.Phone}");
            //}

            //Console.WriteLine($"{a.Id}|{a.FirstName}|{a.LastName}|{a.MiddleName}|{a.Phone}");
            //Console.WriteLine();

            var halllogic = DependenciesResolver.HallLogic;

            //halllogic.Add(new Hall()
            //{
            //    NameHall = "Blue"
            //});

            //halllogic.Add(new Hall()
            //{
            //    NameHall = "Red",
            //    Description = @"Крайней негативный зал"
            //});

            //halllogic.Add(new Hall()
            //{
            //    NameHall = "White",
            //    Description = @"Белый зал"
            //});

            //halllogic.Add(new Hall()
            //{
            //    NameHall = "Purpure",
            //    Description = @"kek",
            //});

            //var list = halllogic.GetAll();
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"{item.Id}|{item.NameHall}|{item.Description}|");
            //    Console.WriteLine();
            //}

            var item = halllogic.GetByName("213123123");

            Console.WriteLine($"{item.Id}|{item.NameHall}|{item.Description}|");
        }
    }
}