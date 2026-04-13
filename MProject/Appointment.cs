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
    public partial class Appointment : Form
    {
        int id = 0;
        string role = "";
        string name = "";
        public Appointment(int d, string r, string n)
        {
            InitializeComponent();
            id = d;
            role = r;
            name = n;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter1.FillByDoctorID(this.dataSet1.Appointment, id);
            /*
            dataGridView1.Columns.Add("AppointmentID", "AppointmentID");
            dataGridView1.Columns.Add("Patient", "Patient");
            dataGridView1.Columns.Add("Nurse", "Nurse");
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("StartTime", "Start Time");
            dataGridView1.Columns.Add("EndTime", "End Time");

            dataGridView1.Rows.Add(1, "John Smith", "Lerato Ndlovu", "2026-04-14", "09:00", "09:30");
            dataGridView1.Rows.Add(2, "Mary Jones", "Nomsa Khumalo", "2026-04-14", "10:00", "10:30");
            dataGridView1.Rows.Add(3, "David Brown", "Sipho Dlamini", "2026-04-15", "11:30", "12:00");

            dataGridView1.Rows.Add(4, "Thabo Mokoena", "Zinhle Nkosi", "2026-04-15", "08:30", "09:00");
            dataGridView1.Rows.Add(5, "Aisha Patel", "Ayanda Cele", "2026-04-15", "09:00", "09:30");
            dataGridView1.Rows.Add(6, "Sipho Dlamini", "Bongani Dube", "2026-04-15", "09:30", "10:00");
            dataGridView1.Rows.Add(7, "Lerato Ndlovu", "Fatima Hassan", "2026-04-16", "10:00", "10:30");
            dataGridView1.Rows.Add(8, "John Smith", "Neo Masuku", "2026-04-16", "10:30", "11:00");
            dataGridView1.Rows.Add(9, "Nomsa Khumalo", "Karabo Molefe", "2026-04-16", "11:00", "11:30");
            dataGridView1.Rows.Add(10, "Karabo Molefe", "Mpho Ramaphosa", "2026-04-16", "11:30", "12:00");

            dataGridView1.Rows.Add(11, "Priya Singh", "Lerato Ndlovu", "2026-04-17", "12:00", "12:30");
            dataGridView1.Rows.Add(12, "Mpho Ramaphosa", "Sipho Dlamini", "2026-04-17", "13:00", "13:30");
            dataGridView1.Rows.Add(13, "Zinhle Nkosi", "Nomsa Khumalo", "2026-04-17", "13:30", "14:00");
            dataGridView1.Rows.Add(14, "David Brown", "Aisha Patel", "2026-04-17", "14:00", "14:30");
            dataGridView1.Rows.Add(15, "Ayanda Cele", "Thabo Mokoena", "2026-04-18", "14:30", "15:00");
            dataGridView1.Rows.Add(16, "Bongani Dube", "Neo Masuku", "2026-04-18", "15:00", "15:30");
            dataGridView1.Rows.Add(17, "Fatima Hassan", "Zinhle Nkosi", "2026-04-18", "15:30", "16:00");
            dataGridView1.Rows.Add(18, "Neo Masuku", "Lerato Ndlovu", "2026-04-18", "16:00", "16:30");
            */
            /*
            // Clear previous data
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            // Columns
            dataGridView2.Columns.Add("AppointmentID", "AppointmentID");
            dataGridView2.Columns.Add("Patient", "Patient");
            dataGridView2.Columns.Add("Nurse", "Nurse");
            dataGridView2.Columns.Add("Date", "Date");
            dataGridView2.Columns.Add("StartTime", "Start Time");
            dataGridView2.Columns.Add("EndTime", "End Time");

            // Rows

            dataGridView2.Rows.Add(1, "John Smith", "Lerato Ndlovu", "2026-04-14", "09:00", "09:30");
            dataGridView2.Rows.Add(2, "Mary Jones", "Nomsa Khumalo", "2026-04-14", "10:00", "10:30");
            dataGridView2.Rows.Add(3, "David Brown", "Sipho Dlamini", "2026-04-15", "11:30", "12:00");

            dataGridView2.Rows.Add(4, "Thabo Mokoena", "Zinhle Nkosi", "2026-04-15", "08:30", "09:00");
            dataGridView2.Rows.Add(5, "Aisha Patel", "Ayanda Cele", "2026-04-15", "09:00", "09:30");
            dataGridView2.Rows.Add(6, "Sipho Dlamini", "Bongani Dube", "2026-04-15", "09:30", "10:00");
            dataGridView2.Rows.Add(7, "Lerato Ndlovu", "Fatima Hassan", "2026-04-16", "10:00", "10:30");
            dataGridView2.Rows.Add(8, "John Smith", "Neo Masuku", "2026-04-16", "10:30", "11:00");
            dataGridView2.Rows.Add(9, "Nomsa Khumalo", "Karabo Molefe", "2026-04-16", "11:00", "11:30");
            dataGridView2.Rows.Add(10, "Karabo Molefe", "Mpho Ramaphosa", "2026-04-16", "11:30", "12:00");

            dataGridView2.Rows.Add(11, "Priya Singh", "Lerato Ndlovu", "2026-04-17", "12:00", "12:30");
            dataGridView2.Rows.Add(12, "Mpho Ramaphosa", "Sipho Dlamini", "2026-04-17", "13:00", "13:30");
            dataGridView2.Rows.Add(13, "Zinhle Nkosi", "Nomsa Khumalo", "2026-04-17", "13:30", "14:00");
            dataGridView2.Rows.Add(14, "David Brown", "Aisha Patel", "2026-04-17", "14:00", "14:30");
            dataGridView2.Rows.Add(15, "Ayanda Cele", "Thabo Mokoena", "2026-04-18", "14:30", "15:00");
            dataGridView2.Rows.Add(16, "Bongani Dube", "Neo Masuku", "2026-04-18", "15:00", "15:30");
            dataGridView2.Rows.Add(17, "Fatima Hassan", "Zinhle Nkosi", "2026-04-18", "15:30", "16:00");
            dataGridView2.Rows.Add(18, "Neo Masuku", "Lerato Ndlovu", "2026-04-18", "16:00", "16:30");
            */

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
