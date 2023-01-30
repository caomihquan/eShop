using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Utilities.Helpper
{
    public class LoadData
    {
        public DataTable LoadDataSQL(string SQL, params object[] parameters)
        {
            string connectionString = "Data Source=LAPTOP-3E89RURE\\CMQUAN;Initial Catalog=eShopSolution;Integrated Security=yes";                      
            var sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            var cmd = sqlConnection.CreateCommand();
            cmd.CommandText = SQL;
            var indexParam = 0;
            var sql = cmd.CommandText;
            SqlDataAdapter adapter = new SqlDataAdapter();
            foreach (var item in parameters)
            {
                var p = cmd.CreateParameter();
                p.ParameterName = "p" + indexParam;
                if (item == null)
                {
                    p.Value = DBNull.Value;
                    cmd.CommandText = cmd.CommandText.Replace("{" + indexParam + "}", "@p" + indexParam);
                }
                else
                {
                    p.Value = item;
                    sql = sql.Replace("{" + indexParam + "}", "'" + p.Value.ToString().Replace("'", "''") + "'");
                    cmd.CommandText = cmd.CommandText.Replace("{" + indexParam + "}", "@p" + indexParam);
                }
                indexParam++;
                cmd.Parameters.Add(p);
            }
            adapter.SelectCommand = cmd;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;           
    }
}
}
