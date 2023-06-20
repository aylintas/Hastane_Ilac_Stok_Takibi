using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hastane_Ilac_Stok_Takibi.DL
{
    

    public static class DataLayer
    {static MySqlConnection conn = new MySqlConnection(
        new MySqlConnectionStringBuilder()
        {
             Server = "127.0.0.1",
             Database = " Hastane_Ilac_Stok_Takibi",
             UserID = "Aylin_Taş",
             Password = "14753698Aylin.",
        }.ConnectionString
         );

        public static int HastaEkle(Hastalar m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("HASTALAR", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@tc", m.HastalarTC);
                komut.Parameters.AddWithValue("@ad", m.HastalarAdi);
                komut.Parameters.AddWithValue("@soyad", m.HastalarSoyadi);
                komut.Parameters.AddWithValue("@recete", m.HastalarRecete);
                komut.Parameters.AddWithValue("@id", m.IlacID);

                int res = komut.ExecuteNonQuery();
                return res;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
            return -1;
        }
    }
} 
