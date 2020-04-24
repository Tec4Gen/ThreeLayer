using FitnessCenter.Common;
using FitnessCenter.Entities;
using System;

namespace FitnessCenter.ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LogicCoach

            /////////////////Логика тренеров///////////////////////
            var coachLogic = DependenciesResolver.CoachLogic;
            string callbackmessage;
            //*****************************************************
            //Функция Add
            var NotAdd = coachLogic.Add(new Coach()
            {
                FirstName = "Алексей",
                MiddleName = "Тарасов",
                LastName = "Викторович",
            });
            //Не добавиться, с базы придет что номер слишком короткий
            Console.WriteLine(NotAdd + Environment.NewLine);

            callbackmessage = coachLogic.Add(new Coach()
            {
                FirstName = "Андрей",
                LastName = "Попов",
                MiddleName = "Юрьевич",
                Phone = 9256987741,
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);

            callbackmessage = coachLogic.Add(new Coach()
            {
                FirstName = "Алексей",
                LastName = "Ионов",
                MiddleName = "Серьгеевич",
                Phone = 9172456566,
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);

            callbackmessage = coachLogic.Add(new Coach()
            {
                FirstName = "Олег",
                LastName = "Игнатьев",
                MiddleName = "Игоревич",
                Phone = 9201495878,
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);
            callbackmessage = coachLogic.Add(new Coach()
            {
                FirstName = "Егор",
                LastName = "Ионов",
                MiddleName = "Юрьевич",
                Phone = 9256545555,
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);
            //Добавили трнеров

            //Удалим тренера
            //***************************************************************************
            ///Функция Delete возвращает объект класса Coach с данными которые были удалены, 
            ///если удаления не было функция вернет Null
            var deleted = coachLogic.Delete(9256545555);

            if (deleted != null)
            {
                Console.WriteLine("Такого тренера нет");
            }
            else 
            {
                Console.WriteLine($"Удален: {deleted.Id}|." +
                                  $"{deleted.FirstName}|" +
                                  $"{deleted.LastName}|" +
                                  $"{deleted.MiddleName}|" +
                                  $"{deleted.Phone}");
            }
            //************************Показать всех*************************************   
            ///Получаем всех тренеров из БД, если нет никого вернеться        
            ///если ничего не вернулась будет пустая коллекция

            var allCoach = coachLogic.GetAll();

            foreach (var items in allCoach)
            {
                Console.WriteLine($"{items.Id}|{items.FirstName}|{items.LastName}|{items.MiddleName}|{items.Phone}");
            }
            /****************************************************************************  
            ****************************************************************************  
            ****************************************************************************/
            #endregion

            /////////////////Логика Клиентов///////////////////////
            #region LogicCleint
            ///Аналогично вставке тренера, подробнее описания в Dao
            ///Возвращает сообщения из базы в качестве результата 

            var clinetLogic = DependenciesResolver.ClientLogic;

            callbackmessage = clinetLogic.Add(new Client()
            {
                FirstName = "Андрей",
                LastName = "Иванов",
                MiddleName = "Иванович",
                IDCoach = 3,
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);

            callbackmessage = clinetLogic.Add(new Client()
            {
                FirstName = "Игорь",
                LastName = "Долгов",
                MiddleName = "Олегович",
                IDCoach = 4,
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);

            clinetLogic.Add(new Client()
            {
                FirstName = "Антон",
                LastName = "Худобин",
                MiddleName = "Игоревич",
                IDCoach = 2,
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);

            clinetLogic.Add(new Client()
            {
                FirstName = "Илья",
                LastName = "Хабибулин",
                MiddleName = "Петрович",
                IDCoach = 1,
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);

            clinetLogic.Add(new Client()
            {
                FirstName = "Виктор",
                LastName = "Андрейченко",
                MiddleName = "Ильинич",
                IDCoach = 2,
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);

            clinetLogic.Add(new Client()
            {
                FirstName = "Алексей",
                LastName = "Игнатьев",
                MiddleName = "Алексеевич",
                IDCoach = 4,
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);

            clinetLogic.Add(new Client()
            {
                FirstName = "Анастасия",
                LastName = "Люшина",
                MiddleName = "Игоревна",
                IDCoach = 3,
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);

            clinetLogic.Add(new Client()
            {
                FirstName = "Игорь",
                LastName = "Илюшкин",
                MiddleName = "Андреевич",
                IDCoach = 1,
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);

            clinetLogic.Add(new Client()
            {
                FirstName = "Антон",
                LastName = "Вилюшин",
                MiddleName = "Юрьевич",
                IDCoach = 2,
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);
            //Обновление вовзращает результат в виде сообщения
            callbackmessage = clinetLogic.Update(100019, 2);
            Console.WriteLine(callbackmessage + Environment.NewLine);

            //Список клиентов в БД, до удаления
            ///Функция возвращает пустой список если ничего нет в БД
            var allClient = clinetLogic.GetAll();

            foreach (var items in allClient)
            {
                Console.WriteLine($"{items.Id}|{items.FirstName}|{items.LastName}|{items.MiddleName}|{items.SubscriptionNumber}|{items.IDCoach}");
            }
            Console.WriteLine();
            /****************************************************************************  
            ****************************************************************************  
            ****************************************************************************/

            ///Функция Delete возвращает объект класса Coach с данными которые были удалены, 
            ///если удаления не было функция вернет Null
            var deletedClient = clinetLogic.Delete(100002);

            if (deletedClient != null)
            {
                Console.WriteLine("Такого клиента нет");
            }
            else
            {
                Console.WriteLine($"Удален: {deletedClient.Id}|" +
                                  $"{deletedClient.FirstName}|" +
                                  $"{deletedClient.LastName}|" +
                                  $"{deletedClient.MiddleName}|" +
                                  $"{deletedClient.SubscriptionNumber}|" +
                                  $"{deletedClient.IDCoach}");
            }
            Console.WriteLine();

            allClient = clinetLogic.GetAll();

            foreach (var items in allClient)
            {
                Console.WriteLine($"{items.Id}|{items.FirstName}|{items.LastName}|{items.MiddleName}|{items.SubscriptionNumber}|{items.IDCoach}");
            }
            Console.WriteLine();
            #endregion

            #region LogicHall
            var halllogic = DependenciesResolver.HallLogic;
            ///Функция add так же уже как и везде, возвращает резльутатом сообщение из БД подробнее в Dao

            callbackmessage = halllogic.Add(new Hall()
            {
                NameHall = "Green"
                //В базе предусмотрена значение по умолчанию для тех залов которые не имею описания при добавлении
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);

            callbackmessage = halllogic.Add(new Hall()
            {
                NameHall = "Blue",
                Description = @"GuluboiZal)"
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);

            callbackmessage = halllogic.Add(new Hall()
            {
                NameHall = "White",
                Description = @"Белый зал"
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);

            callbackmessage = halllogic.Add(new Hall()
            {
                NameHall = "Purple",
                Description = @"Не помню по моему фиолетовый",
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);

            //Тут вернет что такой зал уже есть
            callbackmessage = halllogic.Add(new Hall()
            {
                NameHall = "Green",
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);

            //Удалим
            var deletedhall = halllogic.Delete("Green");

            if (deletedhall != null)
            {
                Console.WriteLine("Такого зала нет");
            }
            else
            {
                Console.WriteLine($"Удален: {deletedhall.Id}|" +
                                  $"{deletedhall.NameHall}|" +
                                  $"{deletedhall.Description}|");
            }
            Console.WriteLine();
            //попробуем вставить еще раз зеленый зал
            callbackmessage = halllogic.Add(new Hall()
            {
                NameHall = "Green",
            });
            Console.WriteLine(callbackmessage + Environment.NewLine);

            //Посмотрим информацию о Blue зале
            var item = halllogic.GetByName("Blue");

            Console.WriteLine($"{item.Id}|{item.NameHall}|{item.Description}|");
            #endregion

            #region LessonLogic

            var Lessonsogic = DependenciesResolver.LessonsLogic;

            var Less = Lessonsogic.Add(new Lesson()
            {
                IdClinet = 4,
                IdHall = 2,
                Time = new DateTime(2020, 4, 22, 16, 35, 0),
            });
            Console.WriteLine(Less + Environment.NewLine);
            
            //Тут вставка не произойдет
            Less = Lessonsogic.Add(new Lesson()
            {
                IdClinet = 3,
                IdHall = 3,
                Time = new DateTime(2020, 4, 22, 16, 35, 0),
            });
            Console.WriteLine(Less + Environment.NewLine);

            //Скажет что такого тренера нет
            Less = Lessonsogic.Add(new Lesson()
            {
                IdClinet = 100,
                IdHall = 3,
                Time = new DateTime(2020, 5, 14, 14, 10, 0),
            });
            Console.WriteLine(Less + Environment.NewLine);


            Less = Lessonsogic.Add(new Lesson()
            {
                IdClinet = 14,
                IdHall = 6,
                Time = new DateTime(2020, 5, 14, 2, 35, 0),
            });
            Console.WriteLine(Less + Environment.NewLine);

            Less = Lessonsogic.Add(new Lesson()
            {
                IdClinet = 16,
                IdHall = 15,
                Time = new DateTime(2020, 5, 14, 2, 35, 0),
            });
            Console.WriteLine(Less + Environment.NewLine);

            //Получим занятие которое будет пересекаться с введенным временем
            var les = Lessonsogic.EmploymentHallByDateTime(new DateTime(2020, 5, 14, 15, 36, 0), 7);


            foreach (var items in les)
            {
                Console.WriteLine($"{items.Id}|{items.IdClinet}|{items.IdHall}|{items.Time}");
            }
            #endregion


           

            
            Console.ReadLine();
        }
    }
}