using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectlogin
{
  public partial class Register : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnRegister_Click1(object sender, EventArgs e)
    {
      string loginString = Security.GetHash512(txtRegusername.Text, txtRegpassword.Text);

      DAL aLayer = new DAL();
      aLayer.userRegister( txtRegusername.Text, loginString);
          
      txtRegusername.Text = "";
    
      txtRegpassword.Text = "";
     

    }

  
  }
}
