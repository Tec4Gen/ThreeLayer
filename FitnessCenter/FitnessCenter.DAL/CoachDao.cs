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
    public class CoachDao : ICoachDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["FitnessCenter"].ConnectionString;


        /*Работает по тому же принципу что и ClientDao*/
        public string Add(Coach item)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_InsertCoach";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterFirstName = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@FirstName",
                    Value = item.FirstName,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterFirstName);

                SqlParameter ParameterLastName = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@LastName",
                    Value = item.LastName,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterLastName);

                SqlParameter ParameterMiddleName = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@MiddleName",
                    Value = item.MiddleName,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterMiddleName);

                SqlParameter ParameterPhone = new SqlParameter()
                {
                    DbType = DbType.Int64,
                    ParameterName = "@Number",
                    Value = item.Phone,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterPhone);

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

        public Coach Delete(long phone)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Coach coach;

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "Sp_DeleteCoach";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterPhone = new SqlParameter()
                {
                    DbType = DbType.Int64,
                    ParameterName = "@Number",
                    Value = phone,
                    Direction = ParameterDirection.Input,
                };

                command.Parameters.Add(ParameterPhone);

                connection.Open();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    coach = new Coach()
                    {
                        Id = (int)reader["ID"],
                        FirstName = reader["FirstName"] as string,
                        LastName = reader["LastName"] as string,
                        MiddleName = reader["MiddleName"] as string,
                        Phone = (long)reader["Phone"],
                    };
                }
                else
                {
                    return null;
                }

                return coach;

            }
        }

        public IEnumerable<Coach> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Coach> Coach = new List<Coach>();

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_GetCoachs";
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Coach.Add(new Coach()
                    {
                        Id = (int)reader["ID"],
                        FirstName = reader["FirstName"] as string,
                        LastName = reader["LastName"] as string,
                        MiddleName = reader["MiddleName"] as string,
                        Phone = (long)reader["Phone"],
                    });
                }

                return Coach;
            }
        }

        public Coach GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Coach Coach = new Coach();

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_GetByIdCoach";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterId = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = id,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterId);

                connection.Open();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Coach.Id = (int)reader["ID"];
                    Coach.FirstName = reader["FirstName"] as string;
                    Coach.LastName = reader["LastName"] as string;
                    Coach.MiddleName = reader["MiddleName"] as string;
                    Coach.Phone = (long)reader["Phone"];
                }
                else
                {
                    return null;
                }

                return Coach;
            }

        }

        public IEnumerable<Coach> GetByLastName(string lastname)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString)) 
            {
                List<Coach> Coach = new List<Coach>();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "dbo.Sp_GetByLastNameCoach";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterLastName = new SqlParameter() 
                {
                    DbType = DbType.String,
                    ParameterName = "@LastName",
                    Value = lastname,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterLastName);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read()) 
                {
                    Coach.Add(new Coach()
                    {
                        Id = (int)reader["ID"],
                        FirstName = reader["FirstName"] as string,
                        LastName = reader["LastName"] as string,
                        MiddleName = reader["MiddleName"] as string,
                        Phone = (long)reader["Phone"],
                    }); 
                }

                return Coach;
            }
        }

        public Coach GetByPhone(long phone)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString)) 
            {
                Coach coach;

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_GetByPhoneCoach";
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

                if (reader.Read())
                {
                    coach = new Coach()
                    {
                        Id = (int)reader["ID"],
                        FirstName = reader["FirstName"] as string,
                        LastName = reader["LastName"] as string,
                        MiddleName = reader["MiddleName"] as string,
                        Phone = (long)reader["Phone"],
                    };
                }
                else 
                {
                    return null;
                }

                return coach;
            }
        }
    }
}
