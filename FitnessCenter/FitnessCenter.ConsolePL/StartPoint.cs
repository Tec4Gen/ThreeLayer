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

            var b = coachLogic.Add(new Coach()
            {
                FirstName = "Алексей",
                MiddleName = "Тарасов",
                LastName = "Викторович",
                Phone = 545555555222,
            });

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
            //coachLogic.Add(new Coach()
            //{
            //    FirstName = "Егор",
            //    LastName = "Ионов",
            //    MiddleName = "Юрьевич",
            //    Phone = 9256545555,
            //});

            //#region AddClient
           // var clinetLogic = DependenciesResolver.ClientLogic;

           //var a = clinetLogic.Add(new Client()
           // {
           //     FirstName = "Андрей",
           //     LastName = "Иванов",
           //     MiddleName = "Иванович",
           //     IDCoach = 1,
           // });


            //    clinetLogic.Add(new Client()
            //    {
            //        FirstName = "Игорь",
            //        LastName = "Долгов",
            //        MiddleName = "Олегович",
            //        SubscriptionNumber = 54789,
            //        IDCoach = 25,
            //    });


            //    clinetLogic.Add(new Client()
            //    {
            //        FirstName = "Антон",
            //        LastName = "Худобин",
            //        MiddleName = "Игоревич",
            //        SubscriptionNumber = 1111,
            //        IDCoach = 24,

            //    });


            //    clinetLogic.Add(new Client()
            //    {
            //        FirstName = "Илья",
            //        LastName = "Хабибулин",
            //        MiddleName = "Петрович",
            //        SubscriptionNumber = 555,
            //        IDCoach = 23,
            //    });

            //clinetLogic.Add(new Client()
            //{
            //    FirstName = "Виктор",
            //    LastName = "Андрейченко",
            //    MiddleName = "Ильинич",
            //    SubscriptionNumber = 4789,
            //    IDCoach = 23,
            //});

            //clinetLogic.Add(new Client()
            //{
            //    FirstName = "Алексей",
            //    LastName = "Игнатьев",
            //    MiddleName = "Алексеевич",
            //    SubscriptionNumber = 65879,
            //    IDCoach = 26,
            //});


            //clinetLogic.Add(new Client()
            //{
            //    FirstName = "Анастасия",
            //    LastName = "Люшина",
            //    MiddleName = "Игоревна",
            //    SubscriptionNumber = 14789,
            //    IDCoach = 27,
            //});

            //clinetLogic.Add(new Client()
            //{
            //    FirstName = "Игорь",
            //    LastName = "Илюшкин",
            //    MiddleName = "Андреевич",
            //    SubscriptionNumber = 5433,
            //    IDCoach = 23,
            //});


            //clinetLogic.Add(new Client()
            //{
            //    FirstName = "Антон",
            //    LastName = "Вилюшин",
            //    MiddleName = "Юрьевич",
            //    SubscriptionNumber = 7894,
            //    IDCoach = 25,
            //});






            ////#endregion



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

            //var a = halllogic.Add(new Hall()
            //{
            //    NameHall = "Фreen",
            //});
            Console.WriteLine(b);
            Console.WriteLine();
            //Console.WriteLine(a);

            //var item = halllogic.GetByName("213123123");

            //Console.WriteLine($"{item.Id}|{item.NameHall}|{item.Description}|");

            var Lessonsogic = DependenciesResolver.LessonsLogic;

            //var a = Lessonsogic.Add(new Lessons() 
            //{
            //    IdClinet = 16,
            //    IdHall = 15,
            //    Time = new DateTime(2020, 5, 14, 2, 35,0),
            //});

            //Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}