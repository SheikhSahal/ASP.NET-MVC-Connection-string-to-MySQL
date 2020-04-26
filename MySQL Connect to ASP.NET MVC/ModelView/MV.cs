using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySQL_Connect_to_ASP.NET_MVC.Models;
using MySql.Data.MySqlClient;

namespace MySQL_Connect_to_ASP.NET_MVC.ModelView
{
    public class MV
    {
        //string oradb = "server=localhost;port=8080;database=test;uid=root;password=''";
        //string oradb = "Server=127.0.0.1;port=8080;username=root;password='';SslMode=None";
        string oradb = "Server=127.0.0.1;Database=test;Uid=root;Pwd='';SslMode=None";

        public List<EMP> GEtdb()
        {
            List<EMP> DBase = new List<EMP>();

            MySqlConnection con = new MySqlConnection(oradb);
            string query = "Select * from test";
            MySqlCommand cmd = new MySqlCommand(query);
            //cmd.CommandText = "Select * from test";
            cmd.Connection = con;
            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                EMP emp = new EMP();

                emp.Name = Convert.ToString(reader["Name"]);


                DBase.Add(emp);

            }

            return DBase;
        }
    }
}