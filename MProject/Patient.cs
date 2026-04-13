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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Patient' table. You can move, or remove it, as needed.
            //this.patientTableAdapter.Fill(this.dataSet1.Patient);
            /*
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("FullName", "Full Name");
            dataGridView1.Columns.Add("DateOfBirth", "Date of Birth");
            dataGridView1.Columns.Add("Username", "Username");
            dataGridView1.Columns.Add("Password", "Password");
            dataGridView1.Columns.Add("Age", "Age");
            dataGridView1.Columns.Add("Cellphone", "Cellphone Number");

            dataGridView1.Rows.Add("John Smith", "1990-03-27", "johnS", "pass999", 35, "073 555 1015");
            dataGridView1.Rows.Add("Mary Jones", "1995-12-01", "maryJ", "pass888", 30, "072 555 1014");
            dataGridView1.Rows.Add("David Brown", "1988-06-19", "davidB", "pass777", 37, "071 555 1013");

            dataGridView1.Rows.Add("Thabo Mokoena", "1995-06-12", "thabo95", "pass123", 30, "082 555 1001");
            dataGridView1.Rows.Add("Aisha Patel", "1999-10-03", "aishaP", "pass666", 26, "083 555 1012");
            dataGridView1.Rows.Add("Sipho Dlamini", "1990-11-05", "siphoD", "pass789", 34, "071 555 1003");

            dataGridView1.Rows.Add("Lerato Ndlovu", "1998-03-21", "leratoN", "pass456", 27, "083 555 1002");
            dataGridView1.Rows.Add("Nomsa Khumalo", "1992-01-18", "nomsaK", "pass321", 33, "072 555 1004");
            dataGridView1.Rows.Add("Karabo Molefe", "1994-04-08", "karaboM", "pass111", 31, "076 555 1007");

            dataGridView1.Rows.Add("Zinhle Nkosi", "2000-07-14", "zinhleN", "pass987", 25, "074 555 1006");
            dataGridView1.Rows.Add("Ayanda Cele", "1997-09-30", "ayandaC", "pass654", 28, "073 555 1005");
            dataGridView1.Rows.Add("Bongani Dube", "1989-12-25", "bonganiD", "pass222", 35, "078 555 1008");

            dataGridView1.Rows.Add("Fatima Hassan", "1996-05-17", "fatimaH", "pass333", 29, "079 555 1009");
            dataGridView1.Rows.Add("Neo Masuku", "1991-02-11", "neoM", "pass555", 34, "082 555 1011");
            dataGridView1.Rows.Add("Mpho Ramaphosa", "1993-08-09", "mphoR", "pass444", 32, "081 555 1010");

            */
            this.patientTableAdapter.Fill(this.dataSet1.Patient);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
