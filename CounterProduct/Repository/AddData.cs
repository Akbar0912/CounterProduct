using System;
using System.Data;
using System.Configuration;
using Microsoft.Data.SqlClient;
using CounterProduct.Models;
using System.Windows.Forms;

namespace CounterProduct.Repository
{
    public class AddData : IAddData
    {
        private string DBConnectionResult;

        public AddData()
        {
            DBConnectionResult = ConfigurationManager.ConnectionStrings["DBConnectionResult"].ConnectionString;
        }

        public void Add(dynamic model)
        {
            using (var connection = new SqlConnection(DBConnectionResult))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;

                    // Check if the record with the same ID already exists
                    command.CommandText = "SELECT COUNT(*) FROM Production_PlansResults WHERE Id = @Id";
                    command.Parameters.Add("@Id", SqlDbType.Int).Value = model.id;

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        // If the record exists, update it
                        command.CommandText = "UPDATE Production_PlansResults SET Date = @Date, Sequence = @Sequence, ModelCode = @ModelCode, [Plan] = @Plan, Target = @Target, Balancing = @Balancing, Actual = @Actual WHERE Id = @Id";
                    }
                    else
                    {
                        // If the record does not exist, insert a new row
                        command.CommandText = "INSERT INTO Production_PlansResults (Id, Date, Sequence, ModelCode, [Plan], Target, Balancing, Actual) VALUES (@Id, @Date, @Sequence, @ModelCode, @Plan, @Target, @Balancing, @Actual)";
                    }

                    command.Parameters.Add("@Date", SqlDbType.Date).Value = model.date;
                    command.Parameters.Add("@Sequence", SqlDbType.Int).Value = model.sequence;
                    command.Parameters.Add("@ModelCode", SqlDbType.VarChar).Value = model.modelCode;
                    command.Parameters.Add("@Plan", SqlDbType.Int).Value = model.plan;
                    command.Parameters.Add("@Target", SqlDbType.Int).Value = model.target;
                    command.Parameters.Add("@Balancing", SqlDbType.Int).Value = model.balancing;
                    command.Parameters.Add("@Actual", SqlDbType.Int).Value = model.actual;

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
