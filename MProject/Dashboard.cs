using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MProject
{
    public partial class Dashboard : Form
    {
        string name = "";
        int medID = 0;
        string role = "";
        string email1 = "";
        DataSet1 ds = new DataSet1();
        public Dashboard(int id, string r, string n, string e)
        {
            InitializeComponent();
            medID = id;
            name = n;
            email1 = e;
            role = r;
            if (role.Equals("Doctor"))
            {
                label1.Text = "Doctor ID: " + medID;
            }
            else {
                label1.Text = "Nurse ID: " + medID;
            }
            label2.Text = name;
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
            /* Clear previous data
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            // Columns
            dataGridView2.Columns.Add("ConsultationID", "ConsultationID");
            dataGridView2.Columns.Add("Nurse", "Nurse");
            dataGridView2.Columns.Add("Date", "Date");
            dataGridView2.Columns.Add("Diagnosis", "Diagnosis");
            dataGridView2.Columns.Add("Treatment", "Treatment");
            dataGridView2.Columns.Add("Notes", "Notes");

            */
            // Rows (clinic consultations - South African names)
            /*
            dataGridView2.Rows.Add(1, "Lerato Ndlovu", "2026-04-14", "Flu", "Rest + Flu meds", "Patient advised to rest and hydrate");
            dataGridView2.Rows.Add(2, "Nomsa Khumalo", "2026-04-14", "High Blood Pressure", "Lifestyle changes + medication", "Monitor BP weekly");
            dataGridView2.Rows.Add(3, "Sipho Dlamini", "2026-04-15", "Diabetes Type 2", "Metformin prescribed", "Diet plan provided");

            dataGridView2.Rows.Add(4, "Zinhle Nkosi", "2026-04-15", "Headache", "Pain relief medication", "Possible stress-related");
            dataGridView2.Rows.Add(5, "Ayanda Cele", "2026-04-15", "Asthma", "Inhaler prescribed", "Avoid dust and smoke");
            dataGridView2.Rows.Add(6, "Bongani Dube", "2026-04-16", "Skin Rash", "Antihistamine cream", "Likely allergic reaction");

            dataGridView2.Rows.Add(7, "Fatima Hassan", "2026-04-16", "Flu", "Rest + Paracetamol", "Follow up if symptoms worsen");
            dataGridView2.Rows.Add(8, "Neo Masuku", "2026-04-16", "Back Pain", "Pain relief + physiotherapy", "Advised posture correction");
            dataGridView2.Rows.Add(9, "Karabo Molefe", "2026-04-17", "Migraine", "Strong pain medication", "Reduce screen time");

            dataGridView2.Rows.Add(10, "Mpho Ramaphosa", "2026-04-17", "Hypertension", "Amlodipine prescribed", "Low salt diet recommended");
            dataGridView2.Rows.Add(11, "Thabo Mokoena", "2026-04-17", "Cold", "Rest + Vitamin C", "No complications observed");
            dataGridView2.Rows.Add(12, "Aisha Patel", "2026-04-18", "Sinus Infection", "Antibiotics prescribed", "Follow full course of meds");

            dataGridView2.Rows.Add(13, "John Smith", "2026-04-18", "Minor Injury", "Bandage + antiseptic", "Wound healing well");
            dataGridView2.Rows.Add(14, "Mary Jones", "2026-04-18", "Gastritis", "Antacids prescribed", "Avoid spicy food");
            dataGridView2.Rows.Add(15, "David Brown", "2026-04-18", "Anxiety", "Counselling recommended", "Referred to mental health nurse");
            */
            //this.consultationTableAdapter.FillByAppointmentID(this.dataSet1.Consultation, id);
            this.appointmentTableAdapter2.FillByDoctorID(this.dataSet11.Appointment,medID);
            this.consultationTableAdapter.Fill(this.dataSet1.Consultation);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Consultation' table. You can move, or remove it, as needed.
            this.consultationTableAdapter.Fill(this.dataSet1.Consultation);
            // TODO: This line of code loads data into the 'dataSet1.Appointment' table. You can move, or remove it, as needed.
            //this.dataTable1TableAdapter.FillByDoctorID(this.dataSet1.Appointment,medID);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
