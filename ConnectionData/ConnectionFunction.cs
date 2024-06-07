using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyFormsManagmentApplication.ConnectionData
{
    internal class ConnectionFunction
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=(localdb)\\localhost;database=Pharmacy;Integrated Security=True";
            return connection;
        }
        public DataSet GetData(string query)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            return dataSet;
        }
    }
}
