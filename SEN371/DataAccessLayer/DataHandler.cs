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
        public string ConnectionString { get; private set; }

        private SqlConnection sql_connection;

        public DataHandler(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
          
            sql_connection = new SqlConnection(ConnectionString);
        }

        public SqlDataAdapter RetrieveTable(string table)
        {       
            sql_connection.Open();

            string query = $"SELECT * FROM {table}";

            SqlDataAdapter adapter = null;

            try
            {
                adapter = new SqlDataAdapter(query, sql_connection);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error retrieving data: " + error.Message);
            }
            finally
            {
                sql_connection.Close();
            }

            if (adapter == null) { }//raise excepetion or something here

            return adapter;
        }

        public void Insert(string table, (string Field, string Value)[] FieldValues)
        {         
            sql_connection.Open();

            Debug.Assert(FieldValues == null);

            string FieldsConcat = "", ValuesConcat = "";

            for (int i = 0; i < FieldValues.Length; i++)
            {
                ValuesConcat += ("'" + FieldValues[i].Value + "'");

                if (i == FieldValues.Length - 1)               
                    FieldsConcat += FieldValues[i].Field;         
                else
                {
                    FieldsConcat += (FieldValues[i].Field + ",");
                    ValuesConcat += ",";
                }
            }

            string query = $"INSERT INTO {table}({FieldsConcat}) VALUES({ValuesConcat})";
           
            SqlCommand command = new SqlCommand(query, sql_connection);
            try
            {
                command.ExecuteNonQuery();
                //MessageBox.Show(query);
                //MessageBox.Show("Values inserted");
                Debug.WriteLine("Insert successful");
            }
            catch (Exception error)
            {
                MessageBox.Show("Insert Error: " + error.Message);              
            }
            finally
            {
                sql_connection.Close();
            }          
        }
    
        public void Update(string table, (string Field, string Value)[] FieldValues, string condition = "")
        {
            sql_connection.Open();

            string builder = "";

            for (int i = 0; i < FieldValues.Length; i++)
            {
                if(i == FieldValues.Length - 1)              
                    builder += $"{FieldValues[i].Field} = '{FieldValues[i].Value}'";           
                else          
                    builder += $"{FieldValues[i].Field} = '{FieldValues[i].Value}', ";                          
            }

            string query;

            if (condition == "")
                query = $"UPDATE {table} SET {builder}";
            else
                query = $"UPDATE {table} SET {builder} WHERE {condition}";

            MessageBox.Show(query);


            SqlCommand command = new SqlCommand(query, sql_connection);

            try
            {
                command.ExecuteNonQuery();
                //MessageBox.Show(query);
                //MessageBox.Show("Value updated");
                Debug.WriteLine("Update successful");
            }
            catch (Exception error)
            {
                MessageBox.Show("Update Error: " + error.Message);
            }
            finally
            {
                sql_connection.Close();
            }
        }

        public void Delete(string table, string condition)
        {
            sql_connection.Open();

            string query = $"DELETE FROM {table} WHERE {condition}";
            MessageBox.Show(query);

            SqlCommand command = new SqlCommand(query, sql_connection);

            try
            {
                command.ExecuteNonQuery();
                //MessageBox.Show(query);
                //MessageBox.Show("Value deleted");
                Debug.WriteLine("Delete successful");
            }
            catch (Exception error)
            {
                MessageBox.Show("Delete Error: " + error.Message);
            }
            finally
            {
                sql_connection.Close();
            }
        }
    }
}