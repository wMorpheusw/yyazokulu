﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace yyazokulu
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.OGRAD = txtad.Text;
            ent.OGRSOYAD = txtsoyad.Text;
            ent.OGRNUMARA = txtnumara.Text;
            ent.OGRSIFRE = txtsifre.Text;
            ent.OGRFOTOGRAF = txtfoto.Text;
            BLLOgrenci.OgrenciEkleBLL(ent);
            

        }
    }
}