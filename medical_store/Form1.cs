using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical_store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Anika" && txtPassword.Text == "1998")
            {
                btnAppointment.Enabled = true;
                btnDoctor.Enabled = true;
                btnPatient.Enabled = true;
                btnPharmacy.Enabled = true;
                btnpay.Enabled = true;
                btnmedical_office.Enabled = true;
                btnSpecial.Enabled = true;
                btnEmergency.Enabled = true;
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show("Please enter the correct login details!", "Medical System");
                txtUsername.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Doctor = new Form2();
            Doctor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 GP = new Form3();
            GP.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Patient = new Form4();
            Patient.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 Payment = new Form5();
            Payment.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 Pharmacy = new Form6();
            Pharmacy.Show();
        }

        private void btnmedical_office_Click(object sender, EventArgs e)
        {
            Form7 Medical_office = new Form7();
            Medical_office .Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if your want to exit?", "Medical System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAppointment.Enabled = false;
            btnDoctor.Enabled = false;
            btnPatient.Enabled = false;
            btnPharmacy.Enabled = false;
            btnpay.Enabled = false;
            btnmedical_office.Enabled = false;
            btnSpecial.Enabled = false;
            btnEmergency.Enabled = false;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
            btnAppointment.Enabled = false;
            btnDoctor.Enabled = false;
            btnPatient.Enabled = false;
            btnPharmacy.Enabled = false;
            btnpay.Enabled = false;
            btnmedical_office.Enabled = false;
            btnSpecial.Enabled = false;
            btnEmergency.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form8 special_consultant = new Form8();
            special_consultant.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form9 Emergency = new Form9();
            Emergency.Show();
        }
    }
}
