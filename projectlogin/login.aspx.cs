using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectlogin
{
  public partial class login : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
      string loginString = Security.GetHash512(txtLoginusername.Text, txtLoginpassword.Text);
      string connectionstring = ConfigurationManager.ConnectionStrings["dblogindemo"].ConnectionString;
      SqlConnection connection;
      connection = new SqlConnection(connectionstring);
      connection.Open();
      SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from tbl_user where username='" + txtLoginusername.Text + "' and password= '" + loginString + "'", connection);
      DataTable dt = new DataTable();
      sda.Fill(dt);
      if (dt.Rows[0][0].ToString() == "1")
      {
        Response.Redirect("Home.aspx");
      }
      else
      {
        Response.Redirect("Register.aspx");
      }

    }
  }
}

