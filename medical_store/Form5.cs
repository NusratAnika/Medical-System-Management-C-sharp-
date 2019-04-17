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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicalDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalDataSet1.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter1.Fill(this.medicalDataSet1.Payment);
         

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicalDataSet);

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.paymentBindingSource1.AddNew();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.paymentBindingSource1.RemoveCurrent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.paymentBindingSource1.MoveNext();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if your want to exit?", "Payment report", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
