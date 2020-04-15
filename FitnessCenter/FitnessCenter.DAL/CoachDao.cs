using FitnessCenter.DAL.Interface;
using FitnessCenter.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FitnessCenter.DAL
{
    public class CoachDao : ICoachDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["FitnessCenter"].ConnectionString;
        public int Add(Coach item)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString)) 
            {

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_InsertCoach";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterId = new SqlParameter() 
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = item.Id,
                    Direction = ParameterDirection.Output,
                };
                command.Parameters.Add(ParameterId);

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

                command.ExecuteNonQuery();

                return (int)ParameterId.Value;
            }
        }

        public Coach Delete(long phone)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Coach Coach = new Coach();

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
                        Phone = (long) reader["Phone"],
                    });
                }

                return Coach;
            }
                




        }

        public int GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Coach> GetByLastName(string lastname)
        {
            throw new NotImplementedException();
        }

        public Coach GetByPhone(long phone)
        {
            throw new NotImplementedException();
        }
    }
}
