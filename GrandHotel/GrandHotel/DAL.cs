using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandHotel
{
    public class DAL :DbContext,IDataContext
    {
        //public static IList<string> GetPaysFournisseurs()
        //{
        //    var list = new List<string>();
        //    var cmd = new SqlCommand();
        //    cmd.CommandText = @"select * from Client";

        //    using (var cnx = new SqlConnection(Settings1.Default.GrandHotelConnexion))
        //    {

        //        cmd.Connection = cnx;
        //        cnx.Open();

        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {

        //            while (reader.Read())
        //            {
        //                list.Add((string)reader["Nom"]);
        //            }
        //        }
        //    }
        //    return list;
        //}



    }
}
