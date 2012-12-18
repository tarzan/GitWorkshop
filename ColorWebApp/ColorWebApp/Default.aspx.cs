using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ColorWebApp
{
   public partial class Default : System.Web.UI.Page
   {
      protected void Page_Load(object sender, EventArgs e)
      {

      }

      protected void Button1_Click(object sender, EventArgs e)
      {
         if (this.RadioButtonList1.SelectedValue == "Blue")
         {
            Label1.ForeColor = System.Drawing.Color.Blue;
         }
         else if (RadioButtonList1.SelectedValue == "Red")
         {
            Label1.ForeColor = System.Drawing.Color.Red;
         }
         else if (RadioButtonList1.SelectedValue == "Yellow")
         {
            Label1.ForeColor = System.Drawing.Color.Yellow;
         }
         Label1.Text = RadioButtonList1.SelectedValue;
      }
   }
}