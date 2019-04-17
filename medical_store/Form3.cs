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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void gP_Appointment_NoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gP_Appointment_NoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicalDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'medicalDataSet1.GP_Appointment' table. You can move, or remove it, as needed.
            this.gP_AppointmentTableAdapter.Fill(this.medicalDataSet1.GP_Appointment);
           

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if your want to exit?", "GP report", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gP_Appointment_NoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.medicalDataSet);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.AddNew();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.RemoveCurrent();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            this.gP_AppointmentBindingSource.MoveNext();
        }
    }
}
