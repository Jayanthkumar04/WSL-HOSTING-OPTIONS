using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AddServiceClient.AddServiceReference;
namespace AddServiceClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");
            Response.Write(client.Addition(5, 5));
        }
    }
}