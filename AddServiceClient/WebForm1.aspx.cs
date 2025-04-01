using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
            AdditionServiceClient c = new AdditionServiceClient();

            try
            {
                Response.Write(c.Division(10, 0));
            }
            catch (FaultException<DivFault> D)
            {
                Response.Write(D.Detail.Message+"<br>");
                Response.Write(D.Detail.OperationMessage);
            }

        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AdditionServiceClient client = new AdditionServiceClient("BasicHttpBinding_AdditionService");
            Response.Write(client.AddServiceInt(10,20));


        }
    }
}