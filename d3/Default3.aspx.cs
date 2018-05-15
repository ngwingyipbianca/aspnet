using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            string con = @"Data Source=.;Initial Catalog=NORTHWIND;Integrated Security=True";
            string cmd = "SELECT * FROM Products";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, con);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            DropDownList1.DataSource = dataset.Tables[0];
            DropDownList1.DataTextField = "ProductName";
            DropDownList1.DataValueField = "ProductID";
            DropDownList1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = DropDownList1.SelectedValue;
    }
}