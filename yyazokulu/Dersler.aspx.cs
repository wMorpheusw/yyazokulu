using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayer;
using BusinessLogicLayer;

namespace yyazokulu
{
    public partial class Dersle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DropDownList1.DataSource = BLLDers.DersListeleBLL();
                DropDownList1.DataTextField = "DERSAD";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataBind();
                DropDownList2.DataSource = BLLOgrenci.ListeleBLL();
                DropDownList2.DataTextField = "OGRNUMARA" ;
                DropDownList2.DataValueField = "OGRID";
                DropDownList2.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityBasvuruForm ent = new EntityBasvuruForm();
            ent.BASDERSID = int.Parse(DropDownList1.SelectedValue.ToString());
            ent.BASOGRID = int.Parse(DropDownList2.SelectedValue.ToString());
            BLLDers.TalepEkleBLL(ent);
            
        }
    }
}