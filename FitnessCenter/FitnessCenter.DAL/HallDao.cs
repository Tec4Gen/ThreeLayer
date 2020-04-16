﻿using FitnessCenter.DAL.Interface;
using FitnessCenter.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.DAL
{
    public class HallDao : IHallDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["FitnessCenter"].ConnectionString;
        public int Add(Hall item)
        {
            using (SqlConnection connection =  new SqlConnection(_connectionString))
            {
                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_InsertHall";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterId = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = item.Id,
                    Direction = ParameterDirection.Output,
                };
                command.Parameters.Add(ParameterId);

                SqlParameter ParameterNameHall = new SqlParameter() 
                {
                    DbType = DbType.String,
                    ParameterName = "@NameHall",
                    Value = item.NameHall,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterNameHall);

                SqlParameter ParameterDescription = new SqlParameter() 
                {
                    DbType = DbType.String,
                    ParameterName = "@Description",
                    Value = item.Description,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterDescription);

                connection.Open();

                command.ExecuteNonQuery();

                return (int)ParameterId.Value;

            }
        }

        public Hall Delete(string namehall)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Hall Hall = new Hall();

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_DeleteHall";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterNameHall = new SqlParameter() 
                {
                    DbType = DbType.String,
                    ParameterName = "@NameHall",
                    Value = namehall,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterNameHall);

                connection.Open();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Hall.Id = (int)reader["ID"];
                    Hall.NameHall = reader["NameHall"] as string;
                    Hall.Description = reader["NameHall"] as string;
                }
                else 
                {
                    return null;
                }
                return Hall;
            }
        }

        public IEnumerable<Hall> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Hall> Hall = new List<Hall>();

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_GetHalls";
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read()) 
                {
                    Hall.Add(new Hall() 
                    {
                        Id = (int)reader["ID"],
                        NameHall = reader["Namehall"] as string,
                        Description = reader["Description"] as string,
                    });
                }

                return Hall;
            }
        }

        public Hall GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Hall Hall = new Hall();

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_GetByIdHall";
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
                    Hall.Id = (int)reader["ID"];
                    Hall.NameHall = reader["NameHall"] as string;
                    Hall.Description = reader["Description"] as string;
                }
                else 
                {
                    return null;
                }

                return Hall;
            }
        }

        public Hall GetByName(string namehall)
        {
            using(SqlConnection connection = new SqlConnection(_connectionString))
            {
                Hall Hall = new Hall();

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_GetByNameHall";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterNameHall = new SqlParameter() 
                { 
                    DbType = DbType.String,
                    ParameterName = "@NameHall",
                    Value = namehall,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(ParameterNameHall);

                connection.Open();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Hall.Id = (int)reader["ID"];
                    Hall.NameHall = reader["NameHall"] as string;
                    Hall.Description = reader["Description"] as string;
                }
                else 
                {
                    return null;
                }

                return Hall;
            }
        }
    }
}