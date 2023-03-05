using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntityOgrenci parametre)
        {
            SqlCommand komut1 = new SqlCommand("insert into TBLOGRENCI (OGRAD, OGRSOYAD, OGRNUMARA, OGRFOTO, OGRSIFRE) values (@p1,@p2,@p3,@p4,@p5)", baglanti.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1", parametre.OGRAD);
            komut1.Parameters.AddWithValue("@p2", parametre.OGRSOYAD);
            komut1.Parameters.AddWithValue("@p3", parametre.OGRNUMARA);
            komut1.Parameters.AddWithValue("@p4", parametre.OGRFOTOGRAF);
            komut1.Parameters.AddWithValue("@p5", parametre.OGRSIFRE);
            return komut1.ExecuteNonQuery();
        }

        public static List<EntityOgrenci> OgrenciListesi()
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut2 = new SqlCommand("select * from TBLOGRENCI", baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();
                ent.OGRID = Convert.ToInt32(dr["OGRID"].ToString());
                ent.OGRAD = dr["OGRAD"].ToString();
                ent.OGRSOYAD = dr["OGRSOYAD"].ToString();
                ent.OGRNUMARA = dr["OGRNUMARA"].ToString();
                ent.OGRFOTOGRAF = dr["OGRFOTO"].ToString();
                ent.OGRSIFRE = dr["OGRSIFRE"].ToString();
                ent.OGRBAKIYE = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciSil(int parametre)
        {
            SqlCommand komut3 = new SqlCommand("Delete from TBLOGRENCI where OGRID=@p1", baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", parametre);
            return komut3.ExecuteNonQuery() != 0;

        }

        public static List<EntityOgrenci> OgrenciDetay(int id)
        {
            List<EntityOgrenci> degerler = new List<EntityOgrenci>();
            SqlCommand komut4 = new SqlCommand("select * from TBLOGRENCI where OGRID=@p1", baglanti.bgl);
            komut4.Parameters.AddWithValue("@p1", id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader dr = komut4.ExecuteReader();
            while (dr.Read())
            {
                EntityOgrenci ent = new EntityOgrenci();

                ent.OGRAD = dr["OGRAD"].ToString();
                ent.OGRSOYAD = dr["OGRSOYAD"].ToString();
                ent.OGRNUMARA = dr["OGRNUMARA"].ToString();
                ent.OGRFOTOGRAF = dr["OGRFOTO"].ToString();
                ent.OGRSIFRE = dr["OGRSIFRE"].ToString();
                ent.OGRBAKIYE = Convert.ToDouble(dr["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(EntityOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("update TBLOGRENCI set OGRAD=@P1, OGRSOYAD=@P2, OGRNUMARA=@P3, OGRFOTO=@P4, OGRSIFRE=@P5 where OGRID=@P6", baglanti.bgl);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@P1", deger.OGRAD);
            komut5.Parameters.AddWithValue("@P2", deger.OGRSOYAD);
            komut5.Parameters.AddWithValue("@P3", deger.OGRNUMARA);
            komut5.Parameters.AddWithValue("@P4", deger.OGRFOTOGRAF);
            komut5.Parameters.AddWithValue("@P5", deger.OGRSIFRE);
            komut5.Parameters.AddWithValue("@P6", deger.OGRID);
            return komut5.ExecuteNonQuery() != 0;

        }
    }
}
