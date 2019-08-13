using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace projectlogin
{
  
  public class DAL
  {
    string connectionstring = ConfigurationManager.ConnectionStrings["dblogindemo"].ConnectionString;
    SqlConnection connection;
    public void userRegister(string username,  string password)
    {
      connection = new SqlConnection(connectionstring);
      connection.Open();
      string query = "insert into tbl_user values('" + username + "','" + password + "')";

      SqlCommand command = new SqlCommand(query, connection);

      command.ExecuteNonQuery();

      connection.Close();
    }

  }
}
