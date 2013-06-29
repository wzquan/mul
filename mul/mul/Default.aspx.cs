using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mul
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<p><font color=\"blue\" size=\"5\">99乘法口诀表</font></p><p></p>");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Response.Write(j + "x" + i + "=" + i * j + " ");
                }
                Response.Write("<br>");
            }

        }
    }
}