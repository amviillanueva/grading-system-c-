using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRADING_SYSTEMM
{
    class new_class
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\cute\GRADING SYSTEMM\Data.mdf;Integrated Security=True;Connect Timeout=30");
        
        public bool login(string query_login)
        {
            bool logintry = false;
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query_login, conn);
                sda.SelectCommand.CommandType = CommandType.Text;
                DataSet dttab = new DataSet();
                sda.Fill(dttab);
                conn.Close();
                int cont = dttab.Tables[0].Rows.Count;
                if (cont != 0)
                {
                    logintry = true;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.ToString());
                throw;
            }
            return logintry;
        }

        public void populatecombobox(ComboBox box)
        {
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Strand from Strands", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    box.Items.Add(dt.Rows[i]["Strand"]);
                }
                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
        }

        public int countdata(string query)
        {
            int i = 0;
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            i = ds.Tables[0].Rows.Count;
            return i;
        }

        public void openclose(string query)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = (query);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void populate(DataGridView dgv, string query)
        {
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
                dgv.AutoGenerateColumns = false;
                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
        }

        public void idnumber(string query)
        {
            string idnum = teacher.IDnumber;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@IDnumber", idnum);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
        }
    }
}