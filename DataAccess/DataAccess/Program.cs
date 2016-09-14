using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using DataAccess.Properties;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            SqlConnection connection = new SqlConnection(Settings.Default.DefaultConnection);
            connection.Open();

            try
            {
                //Active customers

                SqlCommand cmd = new SqlCommand("select Id, Name from Customers where IsDeleted=0", connection);
                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("Active Customers:");

                while (reader.Read())
                {
                    Console.WriteLine("Name= " + reader.GetString(1));
                }

                reader.Close();


                //Deleted customers

                cmd = new SqlCommand("select Id, Name, LastActivityDate from Customers where IsDeleted=1", connection);
                reader = cmd.ExecuteReader();

                Console.WriteLine("Deleted Customers:");

                while (reader.Read())
                {
                    Console.WriteLine("Name= " + reader.GetString(1) + " LastActivityDate= " + reader.GetDateTime(2));
                }

                reader.Close();


                //CustomersGet tarolt eljaras

                cmd = new SqlCommand("CustomersGet", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter parameter = new SqlParameter("@Id", new Guid("39a72f68-1d03-4b64-bf54-e38bf5c94cb0"));
                cmd.Parameters.Add(parameter);

                reader = cmd.ExecuteReader();

                Console.WriteLine("Tarolt eljaras:");

                while (reader.Read())
                {
                    Console.WriteLine("Name= " + reader.GetString(1));
                }

                reader.Close();


                //CustomerInsert tarolt eljaras

                cmd = new SqlCommand("CustomerInsert", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@Id", Guid.NewGuid()));
                cmd.Parameters.Add(new SqlParameter("@GroupId", new Guid("6b834580-0f14-4b60-a4a9-acffde11a7de")));
                cmd.Parameters.Add(new SqlParameter("@Name", "Andras"));
                cmd.Parameters.Add(new SqlParameter("@AccountBalance", 100));
                cmd.Parameters.Add(new SqlParameter("@LastActivityDate", DateTime.Now));
                cmd.Parameters.Add(new SqlParameter("@IsLocked", false));
                cmd.Parameters.Add(new SqlParameter("@IsDeleted", false));
                cmd.Parameters.Add(new SqlParameter("@AuditUser", "Audit Andras"));

                cmd.ExecuteNonQuery();




            }
            catch (SqlException ex)
            {
                switch ( ex.Number )
                {
                    case 2601: Console.WriteLine("Nem lehet ket egyforma nev az adatbazisban!");
                        EventLog.WriteEntry("DataAccess", ex.ToString()); 
                        break;
                    default: Console.WriteLine("Adatbazis hiba: " + ex.Message);
                        break;
                }
            }
            finally
            {
                connection.Close();
            }
             */

            SqlConnection connection = new SqlConnection(Settings.Default.DefaultConnection);
            SqlCommand cmd = new SqlCommand("select * from customers", connection);
            DataSet dataSet = new DataSet();
            SqlDataAdapter cmdAdapter = new SqlDataAdapter();
            cmdAdapter.SelectCommand = cmd;

            cmdAdapter.Fill(dataSet, "Customers");

            dataSet.Tables["Customers"].Rows[2]["Name"] = "xxxx";

            List<string> l = GetChangedColumnNames(dataSet.Tables["Customers"].Rows[2]);

            cmdAdapter.UpdateCommand = GetUpdateCommand(connection);
            cmdAdapter.Update(dataSet, "Customers");

            CustomersDataSet ds = new CustomersDataSet();
            CustomersTableAdapter cta = new CustomersTableAdapter();
            cta.Connection = connection;
            cta.GetData();


            ListDataSet(dataSet);

        }

        private static SqlCommand GetUpdateCommand(SqlConnection c)
        {
            SqlCommand cmd = new SqlCommand("CustomerUpdate", c);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add("@Id", SqlDbType.UniqueIdentifier, 16, "Id");
            cmd.Parameters.Add("@GroupId", SqlDbType.UniqueIdentifier, 16, "GroupId");
            cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 200, "Name");
            cmd.Parameters.Add("@AccountBalance", SqlDbType.Decimal, 18, "AccountBalance");
            cmd.Parameters.Add("@LastActivityDate", SqlDbType.DateTime, 8, "LastActivityDate");
            cmd.Parameters.Add("@IsLocked", SqlDbType.Bit, 1, "IsLocked");
            cmd.Parameters.Add("@IsDeleted", SqlDbType.Bit, 1, "IsDeleted");
            cmd.Parameters.Add("@AuditUser", SqlDbType.NVarChar).Value="Kezzel irt";

            return cmd;

        }

        private static void ListDataSet(DataSet dataSet)
        {
            foreach (DataRow r in dataSet.Tables["Customers"].Rows)
            {
                Console.WriteLine("Id= " + r["Id"]
                                   + " Name= " + r["Name"]
                                   + " RowState= " + r.RowState
                                  );
                
                //Naplozashoz jo:
                //"Id= " + r["Id", DataRowVersion.Current]
            }
        }

        private static List<string> GetChangedColumnNames(DataRow row)
        {
            List<string> l = new List<string>();

            foreach (DataColumn dc in row.Table.Columns)
            {
                if (row[dc.ColumnName, DataRowVersion.Current] != row[dc.ColumnName, DataRowVersion.Original])
                {
                    l.Add(dc.ColumnName);
                }
            }

            return l;
        }
             
    }
}
