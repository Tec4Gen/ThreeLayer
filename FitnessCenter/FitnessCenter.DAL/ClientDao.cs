using FitnessCenter.DAL.Interface;
using FitnessCenter.Entities;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System;

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
        public Client Delete(int subnumber)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Client RemoveClinet = new Client();

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
                    RemoveClinet.Id = (int)reader["ID"];
                    RemoveClinet.FirstName = reader["FirstName"] as string;
                    RemoveClinet.LastName = reader["LastName"] as string;
                    RemoveClinet.MiddleName = reader["MiddleName"] as string;
                    RemoveClinet.SubscriptionNumber = (int)reader["SubscriptionNumber"];
                    RemoveClinet.IDCoach = reader["IDcoach"] as int?;
                }
                else
                {
                    return null;
                }

                return RemoveClinet;
            }
        }

        public Client GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Client Client = new Client();

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
                    Client.Id = (int)reader["ID"];
                    Client.FirstName = reader["FirstName"] as string;
                    Client.LastName = reader["LastName"] as string;
                    Client.MiddleName = reader["MiddleName"] as string;
                    Client.SubscriptionNumber = (int)reader["SubscriptionNumber"];
                    Client.IDCoach = reader["IDcoach"] as int?;
                }
                else
                {
                    return null;
                }

                return Client;
            }
        }

        public Client GetBySubNumber(int subnumber)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Client Client = new Client();

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
                    Client.Id = (int)reader["ID"];
                    Client.FirstName = reader["FirstName"] as string;
                    Client.LastName = reader["LastName"] as string;
                    Client.MiddleName = reader["MiddleName"] as string;
                    Client.SubscriptionNumber = (int)reader["SubscriptionNumber"];
                    Client.IDCoach = reader["IDcoach"] as int?;
                }
                else
                {
                    return null;
                }

                return Client;
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
