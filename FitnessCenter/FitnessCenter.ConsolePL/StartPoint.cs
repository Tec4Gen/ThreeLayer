using FitnessCenter.Common;
using FitnessCenter.Entities;
using System;

namespace FitnessCenter.ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {

            var coachLogic = DependenciesResolver.CoachLogic;

            //var b = coachLogic.Add(new Coach()
            //{
            //    FirstName = "Алексей",
            //    MiddleName = "Тарасов",
            //    LastName = "Викторович",
            //});
            //Console.WriteLine(b);
            //coachLogic.Add(new Coach()
            //{
            //    FirstName = "Андрей",
            //    LastName = "Попов",
            //    MiddleName = "Юрьевич",
            //    Phone = 9256987741,
            //});
            //Console.WriteLine();
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
            //coachLogic.Add(new Coach()
            //{
            //    FirstName = "Егор",
            //    LastName = "Ионов",
            //    MiddleName = "Юрьевич",
            //    Phone = 9256545555,
            //});


            // var c = coachLogic.GetAll();

            // foreach (var item in c)
            // {
            //     Console.WriteLine($"{item.Id}|{item.FirstName}|{item.LastName}|{item.MiddleName}|{item.Phone}");
            // }
            //#region AddClient
            var clinetLogic = DependenciesResolver.ClientLogic;

            //var a = clinetLogic.Add(new Client()
            //{
            //    FirstName = "Андрей",
            //    LastName = "Иванов",
            //    MiddleName = "Иванович",
            //    IDCoach = 3,
            //});
            //Console.WriteLine(a);

            //clinetLogic.Add(new Client()
            //{
            //    FirstName = "Игорь",
            //    LastName = "Долгов",
            //    MiddleName = "Олегович",
            //    IDCoach = 25,
            //});


            //clinetLogic.Add(new Client()
            //{
            //    FirstName = "Антон",
            //    LastName = "Худобин",
            //    MiddleName = "Игоревич",

            //    IDCoach = 24,

            //});


            //clinetLogic.Add(new Client()
            //{
            //    FirstName = "Илья",
            //    LastName = "Хабибулин",
            //    MiddleName = "Петрович",

            //    IDCoach = 23,
            //});

            //clinetLogic.Add(new Client()
            //{
            //    FirstName = "Виктор",
            //    LastName = "Андрейченко",
            //    MiddleName = "Ильинич",

            //    IDCoach = 23,
            //});

            //clinetLogic.Add(new Client()
            //{
            //    FirstName = "Алексей",
            //    LastName = "Игнатьев",
            //    MiddleName = "Алексеевич",

            //    IDCoach = 26,
            //});


            //clinetLogic.Add(new Client()
            //{
            //    FirstName = "Анастасия",
            //    LastName = "Люшина",
            //    MiddleName = "Игоревна",
            //    IDCoach = 27,
            //});

            //clinetLogic.Add(new Client()
            //{
            //    FirstName = "Игорь",
            //    LastName = "Илюшкин",
            //    MiddleName = "Андреевич",
            //    IDCoach = 23,
            //});


            //clinetLogic.Add(new Client()
            //{
            //    FirstName = "Антон",
            //    LastName = "Вилюшин",
            //    MiddleName = "Юрьевич",
            //    IDCoach = 25,
            //});






            ////#endregion



            //var halllogic = DependenciesResolver.HallLogic;

            //var c = halllogic.Add(new Hall()
            //{
            //    NameHall = "ТBlue"
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

            //var a = halllogic.Add(new Hall()
            //{
            //    NameHall = "Фreen",
            //});
            //// Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(a);

            //var item = halllogic.GetByName("213123123");

            //Console.WriteLine($"{item.Id}|{item.NameHall}|{item.Description}|");

            var Lessonsogic = DependenciesResolver.LessonsLogic;

            var Less = Lessonsogic.Add(new Lesson()
            {
                IdClinet = 8,
                IdHall = 2,
                Time = new DateTime(2020, 4, 22, 2, 35, 0),
            });
            Console.WriteLine(Less);
            ////////////////////////////////////////////
            //var less = Lessonsogic.Add(new Lesson()
            //{
            //    IdClinet = 100,
            //    IdHall = 2,
            //    Time = new DateTime(2020, 4, 20, 1, 35, 0),
            //});
            //Console.WriteLine(less);
            //Less = Lessonsogic.Add(new Lesson()
            //{
            //    IdClinet = 16,
            //    IdHall = 15,
            //    Time = new DateTime(2020, 5, 14, 2, 35, 0),
            //});

            //Less = Lessonsogic.Add(new Lesson()
            //{
            //    IdClinet = 16,
            //    IdHall = 15,
            //    Time = new DateTime(2020, 5, 14, 2, 35, 0),
            //});

            //Less = Lessonsogic.Add(new Lesson()
            //{
            //    IdClinet = 16,
            //    IdHall = 15,
            //    Time = new DateTime(2020, 5, 14, 2, 35, 0),
            //});

            //var les = Lessonsogic.GetAllLessonByNameHall("Red");


            //foreach (var item in les)
            //{
            //    Console.WriteLine($"{item.Id}|{item.IdClinet}|{item.IdHall}|{item.Time}");
            //}
            Console.ReadLine();
        }
    }
}