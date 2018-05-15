using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int count = (int) Application["ct"];
        count++;
        Application["ct"] = count;
        Label1.Text = count.ToString();
    }
}