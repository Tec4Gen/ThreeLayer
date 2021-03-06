﻿using FitnessCenter.DAL.Interface;
using FitnessCenter.Entities;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace FitnessCenter.DAL
{
    public class ClientDao : IClientDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["FitnessCenter"].ConnectionString; 

        public string Add(Client item)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.Sp_InsertClient";

                SqlParameter ParameterFirstName = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@FirstName",
                    Value = item.FirstName,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(ParameterFirstName);

                SqlParameter ParameterLastName = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@LastName",
                    Value = item.LastName,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(ParameterLastName);

                SqlParameter ParameterMiddleName = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@MiddleName",
                    Value = item.MiddleName,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(ParameterMiddleName);

                SqlParameter ParameterSubscriptionNumber = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@SubscriptionNumber",
                    Value = item.SubscriptionNumber,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(ParameterSubscriptionNumber);


                SqlParameter ParameterIdCoach = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@IDCoach",
                    Value = item.IDCoach,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(ParameterIdCoach);

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
       
        public string Update(int subnumber, int? idcoach)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.Sp_UpdateCoachByClient";

                SqlParameter ParameterSubscriptionNumber = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@SubscriptionNumber",
                    Value = subnumber,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(ParameterSubscriptionNumber);


                SqlParameter ParameterIdCoach = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@IDCoach",
                    Value = idcoach,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(ParameterIdCoach);

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

        /*
        Функция Delete возвращает тип Delete если пользователь удалился то вернет информацию о удаленном тренере, если нет то вернеться null

        Почему так, потому что эксперименты, я так же мог возвращать резльтатом строку, но просто разные варианты.
        */
        public Client Delete(int subnumber)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Client client;

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_DeleteClient";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter ParameterSubscriptionNumber = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@SubscriptionNumber",
                    Value = subnumber,
                    Direction = ParameterDirection.Input,
                };

                command.Parameters.Add(ParameterSubscriptionNumber);

                connection.Open();

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    client = new Client()
                    {
                        Id = (int)reader["ID"],
                        FirstName = reader["FirstName"] as string,
                        LastName = reader["LastName"] as string,
                        MiddleName = reader["MiddleName"] as string,
                        SubscriptionNumber = (int)reader["SubscriptionNumber"],
                        IDCoach = reader["IDCoach"] as int?,
                    };
                }
                else
                {
                    return null;
                }

                return client;
            }
        }

        public Client GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Client client;

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_GetByIdClient";
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlParameter IdParameter = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = id,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(IdParameter);

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    client = new Client()
                    {
                        Id = (int)reader["ID"],
                        FirstName = reader["FirstName"] as string,
                        LastName = reader["LastName"] as string,
                        MiddleName = reader["MiddleName"] as string,
                        SubscriptionNumber = (int)reader["SubscriptionNumber"],
                        IDCoach = reader["IDCoach"] as int?,
                    };
                }
                else
                {
                    return null;
                }

                return client;
            }
        }

        public Client GetBySubNumber(int subnumber)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Client client;

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "dbo.Sp_GetBySubNumberClient";
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();

                SqlParameter IdParameter = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@SubscriptionNumber",
                    Value = subnumber,
                    Direction = ParameterDirection.Input,
                };
                command.Parameters.Add(IdParameter);

                var reader = command.ExecuteReader();

                if (reader.Read())
                {
                    client = new Client()
                    {
                        Id = (int)reader["ID"],
                        FirstName = reader["FirstName"] as string,
                        LastName = reader["LastName"] as string,
                        MiddleName = reader["MiddleName"] as string,
                        SubscriptionNumber = (int)reader["SubscriptionNumber"],
                        IDCoach = reader["IDCoach"] as int?,
                    };
                }
                else
                {
                    return null;
                }

                return client;
            }
        }

        public IEnumerable<Client> GetByLastName(string lastname)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                List<Client> Client = new List<Client>();

                SqlCommand command = connection.CreateCommand();
                command.CommandText = "dbo.Sp_GetByLastNameClient";
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
                    Client.Add(new Client()
                    {
                        Id = (int)reader["ID"],
                        FirstName = reader["FirstName"] as string,
                        LastName = reader["LastName"] as string,
                        MiddleName = reader["MiddleName"] as string,
                        SubscriptionNumber = (int)reader["SubscriptionNumber"],
                        IDCoach = reader["IDcoach"] as int?,
                    });
                }
                return Client;
            }
        }

        public IEnumerable<Client> GetAll()
        {
            List<Client> Client = new List<Client>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                var command = new SqlCommand("Sp_GetClients", connection);
                command.CommandType = CommandType.StoredProcedure;

                connection.Open();


                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Client.Add(new Client()
                    {
                        Id = (int)reader["ID"],
                        FirstName = reader["FirstName"] as string,
                        LastName = reader["LastName"] as string,
                        MiddleName = reader["MiddleName"] as string,
                        SubscriptionNumber = (int)reader["SubscriptionNumber"],
                        IDCoach = reader["IDCoach"] as int?,
                    });
                }
            }
            return Client;
        }
    }
}
