using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRADING_SYSTEMM
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\cute\GRADING SYSTEMM\Data.mdf;Integrated Security=True;Connect Timeout=30");
        new_class db = new new_class();
        public static string idnum, acc;

        private void logout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void id_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            string allowedchar = "0123456789-";

            if (e.KeyChar == (Char)Keys.Back || allowedchar.Any(chr => chr == e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
        }

        private void id_no_TextChanged(object sender, EventArgs e)
        {
            id_no.MaxLength = 11;
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                hi();
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            hi();
        }

        public void hi()
        {
            string query = "select * from Accounts where IDnumber ='" + id_no.Text + "' and Password ='" + password.Text + "'";
            schoolyear sy = new schoolyear();

            bool trial = db.login(query);

            if (trial == true)
            {
                idnum = id_no.Text;
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Accounts where IDnumber = '" + id_no.Text + "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    acc = (dr["AccLvl"].ToString());
                    sy.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                id_no.Text = "";
                password.Text = "";
                id_no.Focus();
            }
        }
    }
}
