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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void pharmacyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pharmacyBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicalDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalDataSet1.Pharmacy' table. You can move, or remove it, as needed.
            this.pharmacyTableAdapter1.Fill(this.medicalDataSet1.Pharmacy);
            // TODO: This line of code loads data into the 'medicalDataSet.Pharmacy' table. You can move, or remove it, as needed.
            this.pharmacyTableAdapter.Fill(this.medicalDataSet.Pharmacy);

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pharmacyBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicalDataSet);

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           
            this.pharmacyBindingSource1.AddNew();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.pharmacyBindingSource1.RemoveCurrent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.pharmacyBindingSource1.MoveNext();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if your want to exit?", "Pharmacy report", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
