using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CostomerManagement.DBconn
{
    public class Dbconnection
    {
        private static MySqlConnection conn;


        public static MySqlConnection GetMySqlConnection()
        {
            if(conn != null)
            {
                return conn;
            }

            try
            {
                string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
                conn = new MySqlConnection(connString);

                System.Console.WriteLine("Dbconnection class :  Db 연결 성공");

            }catch (MySqlException e)
            {
                System.Console.WriteLine("Dbconnection class Error : " + e.ToString());
            }

            return conn;

        }

    }
}
