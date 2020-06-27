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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\cute\GRADING SYSTEMM\Data.mdf;Integrated Security=True;Connect Timeout=30");
        new_class db = new new_class();
        int hi;

        private void logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
            log_in l = new log_in();
            l.Show();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            registrarid.Text = log_in.idnum;
            school_year.Text = schoolyear.syear;

            db.populate(accounts_data, "select IDnumber, Password, AccLvl from Accounts");
            db.populate(teachers_data, "select IDnumber, Name, Head from Teachers");
            db.populate(students_data, "select IDnumber, Sem, Grade, Strand, Section from StudentSection where SY = '"+ school_year.Text +"'");
        }

        private void subjects_Click(object sender, EventArgs e)
        {
            accounts_data.Visible = true;
            teachers_data.Visible = false;
            students_data.Visible = false;
            hi = 1;
        }

        private void teacher_Click(object sender, EventArgs e)
        {
            teachers_data.Visible = true;
            accounts_data.Visible = false;
            students_data.Visible = false;
            hi = 2;
        }

        private void student_Click(object sender, EventArgs e)
        {
            students_data.Visible = true;
            teachers_data.Visible = false;
            accounts_data.Visible = false;
            hi = 3;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            change_pass cp = new change_pass();
            cp.Show();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (hi == 1)
            {
                string query = "select * from Accounts where ((IDnumber like '%" + search.Text + "%') or (Password like '%" + search.Text + "%') or (AccLvl like '%" + search.Text + "%'))";
                db.populate(accounts_data, query);
            }
            else if (hi == 2)
            {
                string query = "select * from Teachers where ((IDnumber like '%" + search.Text + "%') or (Name like '%" + search.Text + "%') or (Head like '%" + search.Text + "%'))";
                db.populate(teachers_data, query);
            }
            else if (hi == 3)
            {
                string query = "select * from StudentSection where ((IDnumber like '%" + search.Text + "%') or (Sem like '%" + search.Text + "%') or (Grade like '%" + search.Text + "%') or (Strand like '%" + search.Text + "%') or (Section like '%" + search.Text + "%'))";
                db.populate(students_data, query);
            }
        }
    }
}
