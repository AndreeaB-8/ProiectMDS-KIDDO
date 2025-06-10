using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proiect_EDU
{
    public class AuditLogger    //inregistrarea actiunilor intr-un jurnal
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=proiect;Integrated Security=True");
        
        public void LogAction(string username, string action)
        {
            SqlCommand command = null;
            try
            {
                conn.Open();
                string query = "INSERT INTO AuditLog(Username, Action, Timestamp) VALUES (@username, @action, @timestamp)";

                command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@action", action);
                command.Parameters.AddWithValue("@timestamp", DateTime.Now);

                command.ExecuteNonQuery();  //pt interogari care nu intorc rez. (INSERT, DELETE, etc.)
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare" + ex.Message);
            }
            finally
            {
                //curatam memoria ocupata de cmd
                if (command != null)
                    command.Dispose();
                if (conn.State == System.Data.ConnectionState.Open)
                    conn.Close();
            }
        }

    }
}
