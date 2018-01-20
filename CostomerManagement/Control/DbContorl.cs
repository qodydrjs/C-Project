using CostomerManagement.DBconn;
using MySql.Data.MySqlClient;
using System.Data;

namespace CostomerManagement.Control
{
    

    public class DbContorl
    {
        public enum DbworkName
        {
            LookupCostomer,
            LookupLental,
        }

        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataAdapter adpt;
        private DataSet ds;
        private MySqlTransaction transaction;

        public void Insert()
        {

        }

        public DataSet Select(DbworkName dbworkname)
        {
            if (dbworkname == DbworkName.LookupCostomer)
                return LookupCostomer();
            else if (dbworkname == DbworkName.LookupLental)
                return LookupLental();

            return null;
        }


        public void Delete()
        {

        }

        public void Update()
        {

        }



        public DataSet LookupCostomer()
        {
            try
            {
                ds = new DataSet();
                conn = Dbconnection.GetMySqlConnection();

                string sql = "Select * From 고객";
                adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "costomer");
            }
            catch (MySqlException e)
            {
                System.Console.WriteLine(e.ToString());
            }

            return ds;
        }

        public DataSet LookupLental()
        {
            try
            {
                ds = new DataSet();
                conn = Dbconnection.GetMySqlConnection();

                string sql = "Select * From v_자전거대여";
                adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "lental");

            }
            catch (MySqlException e)
            {
                System.Console.WriteLine(e.ToString());
            }

            return ds;
        }

        public DataSet LookupRepair()
        {
            try
            {
                ds = new DataSet();
                conn = Dbconnection.GetMySqlConnection();

                string sql = "Select * From 수리";
                adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "Repair");

            }
            catch (MySqlException e)
            {
                System.Console.WriteLine(e.ToString());
            }

            return ds;
        }

        public DataSet LookupManufacture()
        {
            try
            {
                ds = new DataSet();
                conn = Dbconnection.GetMySqlConnection();

                string sql = "Select * From 제조회사";
                adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "Manufacture");

            }
            catch (MySqlException e)
            {
                System.Console.WriteLine(e.ToString());
            }

            return ds;
        }

        public DataSet LookupBycicle()
        {
            try
            {
                ds = new DataSet();
                conn = Dbconnection.GetMySqlConnection();

                string sql = "Select * From 자전거";
                adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "Bycicle");

            }
            catch (MySqlException e)
            {
                System.Console.WriteLine(e.ToString());
            }

            return ds;
        }

        public DataSet LookupPart()
        {
            try
            {
                ds = new DataSet();
                conn = Dbconnection.GetMySqlConnection();

                string sql = "Select * From 부품";
                adpt = new MySqlDataAdapter(sql, conn);
                adpt.Fill(ds, "Bycicle");

            }
            catch (MySqlException e)
            {
                System.Console.WriteLine(e.ToString());
            }

            return ds;
        }

        public void InsertCostomer(string name, string address, string phone)
        {
            string insertSQL = "Insert into 고객(이름,주소,전화번호) values( '" + name + "', '" + address + "', '" +
                phone + "')";
            cmd = new MySqlCommand();
            conn = Dbconnection.GetMySqlConnection();
            try
            {
                

                conn.Open();
                transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandText = insertSQL;
                cmd.ExecuteNonQuery();

                transaction.Commit();
                
                

            }catch(MySqlException ex)
            {
                transaction.Rollback();
                System.Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            

        }
        public void DeleteCostomer(int index)
        {
            cmd = new MySqlCommand();
            conn = Dbconnection.GetMySqlConnection();
            try
            {


                conn.Open();
                transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "deleteCostomer";

                cmd.Parameters.Add(new MySqlParameter("num",index));

                cmd.ExecuteNonQuery();

                transaction.Commit();



            }
            catch (MySqlException ex)
            {
                transaction.Rollback();
                System.Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateCostomer(int index, string name, string address, string phone)
        {
            string insertSQL = "update 고객 set 이름 = '" + name + "' , 주소='" + address +
                "' , 전화번호 ='" + phone + " ' where 고객번호 = " + index ;
            cmd = new MySqlCommand();
            conn = Dbconnection.GetMySqlConnection();
            try
            {


                conn.Open();
                transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                cmd.CommandText = insertSQL;
                cmd.ExecuteNonQuery();

                transaction.Commit();



            }
            catch (MySqlException ex)
            {
                transaction.Rollback();
                System.Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }



        }
    }

   
}
