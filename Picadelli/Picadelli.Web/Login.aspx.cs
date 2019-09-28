using System;

namespace Picadelli.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TxtLogin_Click(object sender, EventArgs e)
        {
            var usuario = TxtEmail.Text;
            var password = TxtPassword.Text;
        }
    }
}