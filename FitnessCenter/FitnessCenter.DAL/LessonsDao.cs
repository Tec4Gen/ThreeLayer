
using FitnessCenter.DAL.Interface;
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
    public class LessonsDao : ILessonsDao
    {
        private string _connectionString = ConfigurationManager.ConnectionStrings["FitnessCenter"].ConnectionString;

        public string Add(Lessons item)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                Lessons lessons = new Lessons();

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
    }
}
