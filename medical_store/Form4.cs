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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicalDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalDataSet1.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter1.Fill(this.medicalDataSet1.Patient);
            // TODO: This line of code loads data into the 'medicalDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.medicalDataSet.Patient);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.patientBindingSource1.AddNew();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.patientBindingSource1.RemoveCurrent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.patientBindingSource1.MoveNext();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicalDataSet);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if your want to exit?", "Patient's report", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
