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
        if (!IsPostBack)
        {
            Literal1.Text = "first";
            DropDownList1.DataSource = new string[]
            {
                "1","2","3","4"
            };
            DropDownList1.DataBind();
        } 
        else
            Literal1.Text = "postback";

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string s1 = Request.Params["T1"];
        string s2 = Text2.Value;
        string s3 = TextBox1.Text;
        Literal1.Text += String.Format("{4}:{0}/{1}/{2}/{3}", 
            s1, s2, s3, DropDownList1.SelectedValue,
            DateTime.Now.ToString());
        string s = (DropDownList1.SelectedIndex+1).ToString();
        if (s != null)
        {
            string n = String.Format("images/dining{0}.jpg", s);
            Image1.ImageUrl = n;
        }
    }
}