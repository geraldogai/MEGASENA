using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MEGA
{
    public class Main
    {
        private string StringDeConexao = ("Data Source = GERALDO\\SQLEXPRESS; Initial Catalog = megasena; Integrated Security = True");

        public void SqlExecute(string pSql)
        {

            using (SqlConnection cn = new SqlConnection())

            {

                try

                {

                    cn.ConnectionString = StringDeConexao;

                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = cn;

                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = pSql;

                    cn.Open();
                    cmd.ExecuteNonQuery();

                }

                catch (SqlException e)

                {

                    // MessageBox.Show(e.Message);

                }

                finally

                {

                    cn.Close();

                }
            }
        }
    }
}
