using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bakery_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-Q3E2M1Q;database=Bakery_shop;User" +
                 " ID=sa;Password=270118");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Cake (id_cake, cake_name, cake_type, price_cake)" +
                    "values('101','coconut','two', '200')", con);
                


                SqlCommand cmd = new SqlCommand("insert into Cake (id_cake, cake_name, cake_type, price_cake)" +
                    "values('A102','rice','one', '300')", con);
                cmd.ExecuteNonQuery();

                SqlCommand cms = new SqlCommand("insert into Cake (id_cake, cake_name, cake_type, price_cake)" +
                "values('103','flour','three', '700')", con);

                SqlCommand cma = new SqlCommand("insert into Cake (id_cake, cake_name, cake_type, price_cake)" +
                "values('104','butter','seven', '900')", con);

                SqlCommand cmc = new SqlCommand("insert into Cake (id_cake, cake_name, cake_type, price_cake)" +
                "values('105','mixed','eight', '350')", con);
                cm.ExecuteNonQuery();

                SqlCommand cmm = new SqlCommand("insert into employee (id_employee, employee_name, Address, No_hp)" +
                    "values('1-100','Batis','wellingara', '9101112')", con);
                

                SqlCommand com = new SqlCommand("insert into buyers (Id_buyer, Buyer_Name, gender,date_birth, No_hp)" +
                    "values('pp101','Alieu','M','Bakau','2012-10-21', '09101112')", con);
               


                Console.WriteLine("sukses menambahkan data");
                Console.ReadKey();

            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
