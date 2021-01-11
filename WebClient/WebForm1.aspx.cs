using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client("HttpDot");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            service.SetData(TextBox1.Text, TextBox2.Text);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = service.GetData();
            GridView1.DataBind();
        }
    }
}