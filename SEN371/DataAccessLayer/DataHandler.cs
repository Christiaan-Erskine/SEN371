using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//important
using System.Windows.Forms;
using System.Diagnostics;

namespace Project_1.DataAccessLayer
{
    internal class DataHandler
    {

        public static string Connection = @"Data Source=software-engineering371.database.windows.net;Initial Catalog=PremierServiceSolutions;User ID=SEN371Database;Password=Christiaan,Kyle,Hanno,Shammah2022;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";



        public DataHandler()
        {
            
        }


       


        public void Insert(string table, string[] fields,string[] values)
        {
            SqlConnection connect = new SqlConnection(Connection);
            connect.Open();


            Debug.Assert(!(fields == null || values == null));
            Debug.Assert(fields.Length == values.Length);

          

            string FieldsConcat = "", ValuesConcat = "";

            for (int i = 0; i < fields.Length; i++)
            {

                ValuesConcat += ("'" + values[i] + "'");

                if (i == fields.Length - 1)
                {
                    FieldsConcat += fields[i];

                    
                }
                else
                {
                    FieldsConcat += (fields[i] + ",");

                    ValuesConcat += ",";
                }
                
            }


            /*
             INSERT INTO table_name (column1, column2, column3, ...)
             VALUES (value1, value2, value3, ...);
             */


            //values('" + address + "','" + suburb + "','" + city + "','" + country + "')

            string insert = $"INSERT INTO {table}({FieldsConcat}) VALUES({ValuesConcat})";

            MessageBox.Show(insert);


            SqlCommand command = new SqlCommand(insert, connect);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Values inserted");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                connect.Close();
            }
        }
        public SqlDataAdapter viewallAddress()
        {
            string query = "SELECT * FROM Address";
            SqlConnection connect = new SqlConnection(Connection);
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            return adapter;
        }
        public SqlDataAdapter viewallContract()
        {
            string query = "SELECT * FROM Contract";
            SqlConnection connect = new SqlConnection(Connection);
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            return adapter;
        }
        //view all employees
        public SqlDataAdapter viewallEmployee()
        {
            string query = "SELECT * FROM Employee";
            SqlConnection connect = new SqlConnection(Connection);
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            return adapter;
        }

        //view all clients
        public SqlDataAdapter viewallClient()
        {
            string query = "SELECT * FROM Client";
            SqlConnection connect = new SqlConnection(Connection);
            connect.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            return adapter;
        }
        
        public void Delete(int ClientID)
        {
            SqlConnection connect = new SqlConnection(Connection);
            connect.Open();
            string Delete = "DELETE FROM Client WHERE Clientid = " + ClientID + "";
            SqlCommand command = new SqlCommand(Delete, connect);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Value Deleted");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        //update client information
        public void Update(int ClientID, int CellPhoneNumber, string Email)
        {
            SqlConnection connect = new SqlConnection(Connection);
            connect.Open();
            string Update = "UPDATE Client SET CellPhoneNumber = '" + CellPhoneNumber + "', Email = '" + Email + "' WHERE Roll_number = " + ClientID + "";
            SqlCommand command = new SqlCommand(Update, connect);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Value updated");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
