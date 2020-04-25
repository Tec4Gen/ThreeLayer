using FitnessCenter.DAL.Interface;
using FitnessCenter.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace FitnessCenter.DAL
{
    public class LessonsDao : ILessonsDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["FitnessCenter"].ConnectionString;
        /*В целом логика такая же, но получание информации о занятиях клиента, залла, тренера, идут через этот класс, занятие тренера проще получать через клиента
        т.к в базе нет прямого доступа тренера к занятию, оно идет только через клиента. То есть если у клиента, есть занятие,
        то он не может провести в одно и тоже время занятие, т.к проверяеться свободен ли тренер. В логике базы, стоит проверка занятости клиента, но по сути оно отработает 
        Только в случае когда клиент будет заниматься в зале без тренера, но это не предсумотренно.
        Если бы я реализовывал проверку занятости зала в классе halldao то надо было бы доп поля, аналогично для клиента, по этому это больше не учет в проектировании базы
            */
        public string Add(Lesson item)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Lesson lessons = new Lesson();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "dbo.Sp_InsertLessons";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterIdClient = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@IdClient",
                    Value = item.IdClinet,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterIdClient);

                SqlParameter ParameterIdHall = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@IDHall",
                    Value = item.IdHall,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterIdHall);

                SqlParameter ParameterTime = new SqlParameter()
                {
                    DbType = DbType.DateTime,
                    ParameterName = "@Time",
                    Value = item.Time,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterTime);

                connection.Open();

                var messages = new StringBuilder();

                connection.InfoMessage += new SqlInfoMessageEventHandler((sender, args) =>
                {
                    messages.AppendLine(args.Message);
                });


                var reader = command.ExecuteNonQuery();

                return messages.ToString();
            }
        }

        public Lesson Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Lesson lesson;

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_DeleteLesson";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterId = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@IDLesson",
                    Value = id,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterId);

                connection.Open();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    lesson = new Lesson()
                    {
                        Id = (int)reader["IDLessons"],
                        IdClinet = (int)reader["IDClient"],
                        IdHall = (int)reader["IDHall"],
                        Time = (DateTime)reader["ClassTime"]
                    };
                }
                else
                {
                    return null;
                }
                return lesson;
            }
        }

        public IEnumerable<Lesson> GetAll() 
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Lesson> lessons = new List<Lesson>();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "dbo.Sp_GetAllLessons";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lessons.Add(new Lesson()
                    {
                        Id = (int)reader["IDLessons"],
                        IdClinet = (int)reader["IDClient"],
                        IdHall = (int)reader["IDHall"],
                        Time = (DateTime)reader["ClassTime"],
                    });
                }

                return lessons;
            }
        }
        //Получение занатия тренера, клиента, и зала 
        public IEnumerable<Lesson> GetAllLessonByPhoneCoach(long phone)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Lesson> lessons = new List<Lesson>();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "dbo.Sp_GetAllLessonsByPhoneCoach";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterPhone = new SqlParameter() 
                {
                    DbType = DbType.Int64,
                    ParameterName = "@Phone",
                    Value = phone,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterPhone);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lessons.Add(new Lesson()
                    {
                        Id = (int)reader["IDLessons"],
                        IdClinet = (int)reader["IDClient"],
                        IdHall = (int)reader["IDHall"],
                        Time = (DateTime)reader["ClassTime"],
                    });
                }
                return lessons;
            }
        }

        public IEnumerable<Lesson> GetAllLessonBySubNumClient(int idclient)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Lesson> lessons = new List<Lesson>();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "dbo.Sp_GetAllLessonsBySubNumClient";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterIdClient = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@SubNumClient",
                    Value = idclient,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterIdClient);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lessons.Add(new Lesson()
                    {
                        Id = (int)reader["IDLessons"],
                        IdClinet = (int)reader["IDClient"],
                        IdHall = (int)reader["IDHall"],
                        Time = (DateTime)reader["ClassTime"],
                    });
                }

                return lessons;
            }
        }

        public IEnumerable<Lesson> GetAllLessonByNameHall(string idhall)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Lesson> lessons = new List<Lesson>();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "dbo.Sp_GetAllLessonsByNameHall";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterIdHall = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@NameHall",
                    Value = idhall,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterIdHall);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lessons.Add(new Lesson()
                    {
                        Id = (int)reader["IDLessons"],
                        IdClinet = (int)reader["IDClient"],
                        IdHall = (int)reader["IDHall"],
                        Time = (DateTime)reader["ClassTime"],
                    });
                }
                return lessons;
            }
        }

        public IEnumerable<Lesson> GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Lesson> lessons = new List<Lesson>();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "dbo.Sp_GetAllLessonsById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterId = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@IDLesson",
                    Value = id,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterId);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lessons.Add(new Lesson()
                    {
                        Id = (int)reader["IDLessons"],
                        IdClinet = (int)reader["IDClient"],
                        IdHall = (int)reader["IDHall"],
                        Time = (DateTime)reader["ClassTime"],
                    });
                }
                return lessons;
            }
        }
        //Занятости всех залов по времени  
        public IEnumerable<Lesson> EmploymentAllHallByDate(DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Lesson> lessons = new List<Lesson>();

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_EmploymentAllHallByDate";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterDate = new SqlParameter()
                {
                    DbType = DbType.DateTime2,
                    ParameterName = "@Date",
                    Value = date,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterDate);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lessons.Add(new Lesson()
                    {
                        Id = (int)reader["IDLessons"],
                        IdClinet = (int)reader["IDClient"],
                        IdHall = (int)reader["IDHall"],
                        Time = (DateTime)reader["ClassTime"]
                    });
                }

                return lessons;
            }
        }

        public IEnumerable<Lesson> EmploymentAllHallByDateTime(DateTime datetime)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Lesson> lessons = new List<Lesson>();

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_EmploymentAllHallByDateTime";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterDate = new SqlParameter()
                {
                    DbType = DbType.DateTime2,
                    ParameterName = "@Date",
                    Value = datetime,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterDate);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lessons.Add(new Lesson()
                    {
                        Id = (int)reader["IDLessons"],
                        IdClinet = (int)reader["IDClient"],
                        IdHall = (int)reader["IDHall"],
                        Time = (DateTime)reader["ClassTime"]
                    });
                }

                return lessons;
            }
        }
        //Определенного зала
        public IEnumerable<Lesson> EmploymentHallByDate(DateTime time, int hallid)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Lesson> lessons = new List<Lesson>();

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_EmploymentHallByDate";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterDate = new SqlParameter()
                {
                    DbType = DbType.DateTime2,
                    ParameterName = "@Date",
                    Value = time,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterDate);

                SqlParameter ParameterHallName = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@HallId",
                    Value = hallid,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterHallName);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lessons.Add(new Lesson()
                    {
                        Id = (int)reader["IDLessons"],
                        IdClinet = (int)reader["IDClient"],
                        IdHall = (int)reader["IDHall"],
                        Time = (DateTime)reader["ClassTime"]
                    });
                }

                return lessons;
            }
        }

        public Lesson EmploymentHallByDateTime(DateTime datetime, int hallid)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Lesson lessons;

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_EmploymentHallByDateTime";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterDate = new SqlParameter()
                {
                    DbType = DbType.DateTime2,
                    ParameterName = "@Date",
                    Value = datetime,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterDate);

                SqlParameter ParameterHallName = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@HallId",
                    Value = hallid,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterHallName);

                connection.Open();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    lessons = new Lesson()
                    {
                        Id = (int)reader["IDLessons"],
                        IdClinet = (int)reader["IDClient"],
                        IdHall = (int)reader["IDHall"],
                        Time = (DateTime)reader["ClassTime"]
                    };
                }
                else
                {
                    return null;
                }

                return lessons;
            }
        }
    }
}
