using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MProject
{
    public partial class Login : Form
    {
        int id = 0;
        string role = "";
        string name = "";
        string email1 = "";
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            this.doctorTableAdapter.Fill(this.dataSet1.Doctor);
            comboBox1.Items.Add("Doctor");
            comboBox1.Items.Add("Nurse");
            comboBox1.Items.Add("Patient");
            comboBox1.Items.Add("Admin");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool lsuccess = false;
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            {
                
                foreach (DataRow row in dataSet1.Doctor.Rows)
                {
                    if (row["Username"].ToString().Equals(textBox1.Text.ToString().Trim()) &&
                        row["Password"].ToString().Equals(textBox2.Text.ToString().Trim()))
                    {
                        lsuccess = true;
                        id = (int)row["DoctorID"];
                        name = row["FullName"].ToString();
                        email1 = row["Username"].ToString();
                        role = comboBox1.Text.ToString();
                        break;
                    }
                }
                if (!lsuccess)
                {
                    MessageBox.Show("Invalid username or password." + textBox1.Text + " " + textBox2.Text);
                }
                else
                {
                    MessageBox.Show("Login successful!");
                    Form1 f = new Form1(id, role, name, email1);
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                if (comboBox1.SelectedIndex == 2)
                {
                    MessageBox.Show("Login successful!");
                    id = 1;
                    name = "Nosipho Duma";
                    email1 = "nosiphoduma@gmail.com";
                    PatientForm f = new PatientForm(id, role, name, email1);
                    f.Show();
                    this.Hide();
                    /*
                    foreach (DataRow row in dataSet1.Patient.Rows)
                    {
                        if (row["Username"].ToString().Equals(textBox1.Text.ToString().Trim()) ||
                            row["Password"].ToString().Equals(textBox2.Text.ToString().Trim()))
                        {
                            lsuccess = true;
                            id = (int)row["PatientID"];
                            name = row["FullName"].ToString();
                            email1 = row["Username"].ToString();
                            role = comboBox1.Text.ToString();
                            break;
                        }
                    }
                    if (!lsuccess)
                    {
                        MessageBox.Show("Invalid username or password." + textBox1.Text + " " + textBox2.Text+ " "+email1+"-");
                    }
                    else
                    {
                        MessageBox.Show("Login successful!");
                        Form1 f = new Form1(id, role, name, email1);
                        f.Show();
                        this.Hide();
                    }*/
                }
                else
                {
                    MessageBox.Show("Please select a role.");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
