using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (getSession() == null)
        {
            HttpContext.Current.Response.Redirect(@"~/Default.aspx");
        }
    }

    public static SessionData getSession()
    {
        return (SessionData)HttpContext.Current.Session["session"];
    }

}
