using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MProject
{
    public partial class Form1 : Form
    {
        int id = 0;
        string role = "";
        string name = "";
        string email1 = "";
        public Form1(int d,string r, string n, string e)
        {
            InitializeComponent();
            id = d;
            role = r;
            name = n;
            email1 = e;
            aclabel.Text = e;
            if (role == "Doctor")
            {
                LoadForm(new Dashboard(id, role,name,email1));
            }
        }
        private void LoadForm(Form form)
        {
            mainpanel.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            mainpanel.Controls.Add(form);
            form.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dbbutton_Click(object sender, EventArgs e)
        {
           LoadForm(new Dashboard(id, role, name, email1));
        }

        private void apbutton_Click(object sender, EventArgs e)
        {
            LoadForm(new Appointment(id,role,name));
        }

        private void pabutton_Click(object sender, EventArgs e)
        {
            LoadForm(new Patient());
        }

        private void sebutton_Click(object sender, EventArgs e)
        {

        }

        private void lobutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aclabel_Click(object sender, EventArgs e)
        {

        }
    }
}
