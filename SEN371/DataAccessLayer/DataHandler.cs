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
    public struct FieldValue
    {       
        public string Field { get; set; }
        public string Value { get; set; }

        public FieldValue(string field, string value)
        {
            this.Field = field;
            this.Value = value;
        }      
    }


    internal class DataHandler
    {      
        public string ConnectionString { get; private set; }

        private SqlConnection sql_connection;


        public DataHandler(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;

            sql_connection = new SqlConnection(ConnectionString);
     
        }

        public SqlDataAdapter RetrieveData(string table)
        {       
            sql_connection.Open();

            string query = $"SELECT * FROM {table}";

            SqlDataAdapter adapter = null;

            try
            {
                adapter = new SqlDataAdapter(query, sql_connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex);
            }
            finally
            {
                sql_connection.Close();
            }

            return adapter;
        }



        public void Insert(string table, string[] fields, string[] values)
        {         
            sql_connection.Open();

            Debug.Assert(!(fields == null || values == null));
            Debug.Assert(fields.Length == values.Length);

            string FieldsConcat = "", ValuesConcat = "";

            for (int i = 0; i < fields.Length; i++)
            {
                ValuesConcat += ("'" + values[i] + "'");

                if (i == fields.Length - 1)               
                    FieldsConcat += fields[i];
                
                else
                {
                    FieldsConcat += (fields[i] + ",");
                    ValuesConcat += ",";
                }
            }

            string query = $"INSERT INTO {table}({FieldsConcat}) VALUES({ValuesConcat})";

            MessageBox.Show(query);


            SqlCommand command = new SqlCommand(query, sql_connection);
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
                sql_connection.Close();
            }

            //return RetrieveData(table);
        }


        public void oldInsert(string table, string[] fields,string[] values)
            {

                
            sql_connection.Open();


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

                string insert = $"INSERT INTO {table}({FieldsConcat}) VALUES({ValuesConcat})";

            SqlCommand command = new SqlCommand(insert, sql_connection);
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
                sql_connection.Close();
            }
        }
         
        
        public SqlDataAdapter viewallAddress()
        {
            string query = "SELECT * FROM Address";


            SqlConnection connect = new SqlConnection(@"Data Source=software-engineering371.database.windows.net;Initial Catalog=PremierServiceSolutions;User ID=SEN371Database;Password=Christiaan,Kyle,Hanno,Shammah2022;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connect.Open();
                            
            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);

            connect.Close();

            return adapter;
        }

        /*
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


        */


        //update client information
        public void Update(string table, FieldValue[] fieldvalues, string condition = "")
        {
            sql_connection.Open();

            string builder = "";

            for (int i = 0; i < fieldvalues.Length; i++)
            {
                if(i == fieldvalues.Length - 1)              
                    builder += $"{fieldvalues[i].Field} = '{fieldvalues[i].Value}'";           
                else          
                    builder += $"{fieldvalues[i].Field} = '{fieldvalues[i].Value}', ";                          
            }

            string query = "";

            if (condition == "")
                query = $"UPDATE {table} SET {builder}";
            else
                query = $"UPDATE {table} SET {builder} WHERE {condition}";

            MessageBox.Show(query);


            SqlCommand command = new SqlCommand(query, sql_connection);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show(query);
                MessageBox.Show("Value updated");
            }
            catch (Exception error)
            {
                MessageBox.Show("Update Error " + error.Message);
            }
            finally
            {
                sql_connection.Close();
            }
        }

        public void Delete(string table, string condition)
        {
            sql_connection.Open();


            string query = $"DELETE FROM {table} WHERE  {condition}";
            MessageBox.Show(query);

            SqlCommand command = new SqlCommand(query, sql_connection);
            try
            {
                command.ExecuteNonQuery();
                //MessageBox.Show(query);
                MessageBox.Show("Value deleted");
            }
            catch (Exception error)
            {
                MessageBox.Show("Delete Error " + error.Message);
            }
            finally
            {
                sql_connection.Close();
            }
        }
    }
}