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
            throw new NotImplementedException();
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
                var command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT [ID],[FirstName],[LastName] ,[MiddleName],[SubscriptionNumber],[IDCoach] FROM[FitnessCenter].[dbo].[Client]";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())  
                {
                    Client.Add(new Client() 
                    {
                       Id = (int) reader["ID"],
                       Firstname = reader["FirstName"] as string,
                       LastName = reader ["LastName"] as string,
                       MiddleName = reader["MiddleName"] as string,
                       SubscriptionNumber = (int)reader["SubscriptionNumber"],
                       IDCoach = (decimal) reader["IDCoach"]
                    });
                }
            }
            return Client;
        }

    }
}
