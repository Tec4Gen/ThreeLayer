using FitnessCenter.DAL.Interface;
using FitnessCenter.Entities;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenter.DAL
{
    public class ClientDao : IClientDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["FitnessCenter"].ConnectionString;
        public int Add(Client item) 
        {
            using (SqlConnection connection = new SqlConnection(_connectionString)) 
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.Sp_InsertClient";

                SqlParameter IdParameter = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = item.Id,
                    Direction = ParameterDirection.Output

                };
                command.Parameters.Add(IdParameter);

                SqlParameter ParameterFirtName = new SqlParameter() 
                { 
                     DbType = DbType.String,
                     ParameterName = "@FirstName",
                     Value = item.FirstName,
                     Direction = ParameterDirection.Input
                };
                command.Parameters.Add(ParameterFirtName);

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
                    Value = item.LastName,
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
                    ParameterName = "@IdCoach",
                    Value = item.IDCoach,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(ParameterIdCoach);

                connection.Open();

                command.ExecuteNonQuery();

                return (int)IdParameter.Value;
            }
        }

        public Client GetById (int id)
        {
            throw new  NotImplementedException(); 
        }

        public IEnumerable<Client> GetAll()
        {
            List<Client> Client = new List<Client>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                
                var command = new SqlCommand("Sp_GetClients", connection);
                command.CommandType = CommandType.StoredProcedure;

                 
                //command = connection.CreateCommand();
                // command.CommandText = "SELECT [ID],[FirstName],[LastName] ,[MiddleName],[SubscriptionNumber],[IDCoach] FROM[FitnessCenter].[dbo].[Client]";
                connection.Open();


                var reader = command.ExecuteReader();
                while (reader.Read())  
                {
                    Client.Add(new Client()
                    {
                        Id = (int) reader["ID"],
                        FirstName = reader["FirstName"] as string,
                        LastName = reader["LastName"] as string,
                        MiddleName = reader["MiddleName"] as string,
                        SubscriptionNumber = (int)reader["SubscriptionNumber"],
                        IDCoach = reader["IDCoach"] as int?
                    });
                }
            }
            return Client;
        }

    }
}
