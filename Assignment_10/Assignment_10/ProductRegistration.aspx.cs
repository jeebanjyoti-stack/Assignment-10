using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Assignment_10
{
    public partial class ProductRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
             
                PrdCatagory.Items.Add("Laptop");
                PrdCatagory.Items.Add("Mobile");
                PrdCatagory.Items.Add("Ipad");
                PrdCatagory.Items.Add("Desktop");
                PrdCatagory.Items.Add("Television");
                PrdCatagory.Items.Add("Fan");
                PrdCatagory.Items.Add("Dryer");


            }
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void TxtButton_Click(object sender, EventArgs e)
        {
            LblInfo.Visible = true;
            LblInfo.Text = "Registration Success!!!";
            LblInfo.Text += "<br/>Product Name: " + PrdName.Text;
            LblInfo.Text += "<br/>Catagory: " + PrdCatagory.Text;
            LblInfo.Text += "<br/>Price: " + PrdPrice.Text;
            LblInfo.Text += "<br/>Description: " + PrdDescription.Text;
            LblInfo.Text += "<br/>Release Date: " + PrdCalendar.SelectedDate;
        }
    }
}