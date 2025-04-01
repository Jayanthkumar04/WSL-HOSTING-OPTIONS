using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentClient.StudentReference;

namespace StudentClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Service1Client sc = new Service1Client("BasicHttpBinding_IService1");

            sc.Data(new Student() {Name = "jayanth" });
        }
    }
}