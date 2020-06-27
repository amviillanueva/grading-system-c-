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
    public partial class change_pass : Form
    {
        public change_pass()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\cute\GRADING SYSTEMM\Data.mdf;Integrated Security=True;Connect Timeout=30");
        new_class db = new new_class();

        private void save_Click(object sender, EventArgs e)
        {
            string id = log_in.idnum;
            string query = "select * from Accounts where IDnumber = '" + id + "' and Password = '" + old.Text + "'";
            bool trial = db.login(query);

            if (trial == true)
            {
                if (neww.Text == confirm.Text)
                {
                    this.Hide();
                    string q = "update Accounts set Password = '" + confirm.Text + "' where IDnumber = '" + id + "'";
                    db.openclose(q);
                    MessageBox.Show("Password Changed", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password doesn't match", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    old.Text = "";
                    neww.Text = "";
                    confirm.Text = "";
                }
            }
            else if (trial == false)
            {
                MessageBox.Show("Incorrect Password", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                old.Text = "";
                neww.Text = "";
                confirm.Text = "";
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
