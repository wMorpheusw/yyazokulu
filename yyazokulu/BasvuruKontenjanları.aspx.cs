using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;

namespace yyazokulu
{
    public partial class BasvuruKontenjanları : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e, object cmd)
        {
            SqlCommand komut = new SqlCommand("select BASVURUID, TBLDERSLER.DERSAD, TBLOGRENCI.OGRNUMARA from TBLBASVURU inner join TBLOGRENCI ON TBLBASVURU.OGRENCIID=TBLOGRENCI.OGRID join TBLDERSLER ON TBLBASVURU.DERSID=TBLDERSLER.DERSID", baglanti.bgl);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Repeater2.DataSource = dr;
                Repeater2.DataBind();
            }
        }
    }
}