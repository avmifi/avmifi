using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Shekels
{
    public partial class Mpage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(bool)Session["login"])
            { //unlogged
                bar6.Style.Add("display", "none");
                bar7.Style.Add("display", "none");
                bar10.Style.Add("display", "none");
            }
            else
            { //logged
                bar2.Style.Add("display", "none"); //signup
                bar3.Style.Add("display", "none"); //login
                bar7.Style.Add("display", "block"); 
                bar5.Style.Add("display", "block");
                bar6.Style.Add("display", "none");
                bar7.Style.Add("display", "block");
                bar10.Style.Add("display", "block");

            }

            if (!(bool)Session["admin"])
            { //unlogged
                bar6.Style.Add("display", "none");
            }
            else
            { //logged
                
                bar6.Style.Add("display", "block");
                bar7.Style.Add("display", "block");
            }


        }
    }
}