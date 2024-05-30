using CounterProduct.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProduct.Repository
{
    public class GetData : IPlanRepository
    {
        private string DbConnection;

        public GetData()
        {
            DbConnection = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        }
        public void Add(dynamic model)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PlanModel> GetAll()
        {
            List<PlanModel> plans = new List<PlanModel>();
            string query = "SELECT Production_Plans.*, Global_Model_Codes.CycleTime " +
                "FROM Production_Plans " +
                "INNER JOIN Global_Model_Codes ON Production_Plans.ModelCode = Global_Model_Codes.ModelCode";

            using (SqlConnection connection = new SqlConnection(DbConnection))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        plans.Add(new PlanModel
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Date = DateOnly.FromDateTime(Convert.ToDateTime(reader["Date"])),
                            Sequence = Convert.ToInt32(reader["Sequence"]),
                            ModelCode = reader["ModelCode"].ToString(),
                            Plan = Convert.ToInt32(reader["Plan"]),
                            Target = Convert.ToInt32(reader["Target"]),
                            Balancing = Convert.ToInt32(reader["Balancing"]),
                            Actual = Convert.ToInt32(reader["Actual"]),
                            Time = TimeSpan.Parse(reader["CycleTime"].ToString())
                        });
                    }
                }
            }
            return plans;
        }

        public IEnumerable<PlanModel> GetCycle(TimeOnly model)
        {
            throw new NotImplementedException();
        }
    }
}
