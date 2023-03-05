using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAccessLayer;

namespace yyazokulu
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            int x = Convert.ToInt32(Request.QueryString["OGRID"]);
            txtid.Text = x.ToString();
            txtid.Enabled = false;

            if (Page.IsPostBack == false)
            { 
            List<EntityOgrenci> ogrlist = BLLOgrenci.detayBLL(x);
            txtad.Text = ogrlist[0].OGRAD.ToString();
            txtsoyad.Text = ogrlist[0].OGRSOYAD.ToString();
            txtsifre.Text = ogrlist[0].OGRSIFRE.ToString();
            txtnumara.Text = ogrlist[0].OGRNUMARA.ToString();
            txtfoto.Text = ogrlist[0].OGRFOTOGRAF.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent =new EntityOgrenci();
            ent.OGRAD=txtad.Text;
            ent.OGRSOYAD=txtsoyad.Text;
            ent.OGRSIFRE=txtsifre.Text;
            ent.OGRNUMARA=txtnumara.Text;
            ent.OGRFOTOGRAF=txtfoto.Text;
            ent.OGRID=Convert.ToInt32(txtid.Text);
            BLLOgrenci.OgrenciGuncelleBLL(ent);
            Response.Redirect("OgrenciListesi.aspx");

        }
    }
}