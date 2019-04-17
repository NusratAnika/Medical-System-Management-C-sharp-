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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void doctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicalDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalDataSet1.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter1.Fill(this.medicalDataSet1.Doctor);
            // TODO: This line of code loads data into the 'medicalDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.medicalDataSet.Doctor);

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if your want to exit?", "Doctor's report", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource1.AddNew();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource1.RemoveCurrent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource1.MoveNext();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicalDataSet);
        }
    }
}
