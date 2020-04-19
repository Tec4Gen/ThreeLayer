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

                try
                {
                    var reader = command.ExecuteNonQuery();
                }
                catch (SqlException)
                {

                    return messages.ToString();
                }



                Console.WriteLine();

                return messages.ToString();


            }
        }

        public Lesson Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Lesson lesson = new Lesson();

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
                    lesson.Id = (int)reader["IDLessons"];
                    lesson.IdClinet = (int)reader["IDClient"];
                    lesson.IdHall = (int)reader["IDHall"];
                    lesson.Time = (DateTime)reader["ClassTime"];
                }
                else
                {
                    return null;
                }
                return lesson;
            }
        }
        //if(reader.Read())
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
        //if(reader.Read())
        public IEnumerable<Lesson> GetAllLessonByIdPhoneCoach(int idclient)
        {
            throw new NotImplementedException();

        }

        //if(reader.Read())
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
        //if(reader.Read())
        public IEnumerable<Lesson> GetAllLessonByNameHall(int idhall)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Lesson> lessons = new List<Lesson>();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "dbo.Sp_GetAllLessonsByIdHall";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterIdHall = new SqlParameter()
                {
                    DbType = DbType.Int32,
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

        //if(reader.Read())
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
    }
}
