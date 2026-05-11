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
    public partial class PatientForm : Form
    {
        string name1;
        int id;
        string emailAddress;
        string role;
        public PatientForm(int id, string role, string name, string email1)
        {
            InitializeComponent();
            this.id = id;
            this.role = role;
            this.name1 = name;
            this.emailAddress = email1;   
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
