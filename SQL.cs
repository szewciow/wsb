using System;
using System.Data.SqlClient;

namespace sql
{
    class Program
    {
        static void Main(string[] args)
        {
            string sql = "";
            SqlDataReader read = null;

            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS; Initial Catalog=komis1; Integrated Security=true");

            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS; Initial Catalog=komis1; User=krystyna; Password=asia123");

            try
            {
                conn.Open();
                Console.WriteLine("Prawidłowe połączenie z bazą danych komis1\n");
                sql = "select * from [user]";
                SqlCommand result = new SqlCommand(sql, conn);

                read = result.ExecuteReader();


                while (read.Read())
                {
                    Console.WriteLine("Imię: {0}, nazwisko: {1}", read[1],read[2]);
                }


            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn !=null)
                {
                    conn.Close();
                }

                if (read != null)
                {
                    read.Close();
                }
            }

            Console.ReadKey();
        }
    }
}
