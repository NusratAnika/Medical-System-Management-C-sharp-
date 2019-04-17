namespace medical_store
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            System.Windows.Forms.Label pharmacy_Patient_IDLabel;
            System.Windows.Forms.Label pharmacy_Doc_s_NHS_NoLabel;
            System.Windows.Forms.Label doctor_Doc_s_NHS_NoLabel;
            System.Windows.Forms.Label doctor_Patient_IDLabel;
            System.Windows.Forms.Label gP_Appointment_Patient_IDLabel;
            System.Windows.Forms.Label gP_Appointment_Doc_s_NHS_NoLabel;
            System.Windows.Forms.Label patient_Doc_s_NHS_NoLabel;
            System.Windows.Forms.Label patient_Patient_IDLabel;
            System.Windows.Forms.Label mastercardLabel;
            System.Windows.Forms.Label debit_CardLabel;
            this.medicalDataSet1 = new medical_store.medicalDataSet1();
            this.medical_QueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medical_QueryTableAdapter = new medical_store.medicalDataSet1TableAdapters.Medical_QueryTableAdapter();
            this.tableAdapterManager = new medical_store.medicalDataSet1TableAdapters.TableAdapterManager();
            this.medical_QueryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.medical_QueryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.pharmacy_Patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.pharmacy_Doc_s_NHS_NoTextBox = new System.Windows.Forms.TextBox();
            this.doctor_Doc_s_NHS_NoTextBox = new System.Windows.Forms.TextBox();
            this.doctor_Patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.gP_Appointment_Patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.gP_Appointment_Doc_s_NHS_NoTextBox = new System.Windows.Forms.TextBox();
            this.patient_Doc_s_NHS_NoTextBox = new System.Windows.Forms.TextBox();
            this.patient_Patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.mastercardTextBox = new System.Windows.Forms.TextBox();
            this.debit_CardTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.medical_QueryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pharmacy_Patient_IDLabel = new System.Windows.Forms.Label();
            pharmacy_Doc_s_NHS_NoLabel = new System.Windows.Forms.Label();
            doctor_Doc_s_NHS_NoLabel = new System.Windows.Forms.Label();
            doctor_Patient_IDLabel = new System.Windows.Forms.Label();
            gP_Appointment_Patient_IDLabel = new System.Windows.Forms.Label();
            gP_Appointment_Doc_s_NHS_NoLabel = new System.Windows.Forms.Label();
            patient_Doc_s_NHS_NoLabel = new System.Windows.Forms.Label();
            patient_Patient_IDLabel = new System.Windows.Forms.Label();
            mastercardLabel = new System.Windows.Forms.Label();
            debit_CardLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_QueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_QueryBindingNavigator)).BeginInit();
            this.medical_QueryBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medical_QueryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // medicalDataSet1
            // 
            this.medicalDataSet1.DataSetName = "medicalDataSet1";
            this.medicalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medical_QueryBindingSource
            // 
            this.medical_QueryBindingSource.DataMember = "Medical_Query";
            this.medical_QueryBindingSource.DataSource = this.medicalDataSet1;
            // 
            // medical_QueryTableAdapter
            // 
            this.medical_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GP_AppointmentTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = medical_store.medicalDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medical_QueryBindingNavigator
            // 
            this.medical_QueryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medical_QueryBindingNavigator.BindingSource = this.medical_QueryBindingSource;
            this.medical_QueryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medical_QueryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medical_QueryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.medical_QueryBindingNavigatorSaveItem});
            this.medical_QueryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medical_QueryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medical_QueryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medical_QueryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medical_QueryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medical_QueryBindingNavigator.Name = "medical_QueryBindingNavigator";
            this.medical_QueryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medical_QueryBindingNavigator.Size = new System.Drawing.Size(984, 25);
            this.medical_QueryBindingNavigator.TabIndex = 0;
            this.medical_QueryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // medical_QueryBindingNavigatorSaveItem
            // 
            this.medical_QueryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medical_QueryBindingNavigatorSaveItem.Enabled = false;
            this.medical_QueryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medical_QueryBindingNavigatorSaveItem.Image")));
            this.medical_QueryBindingNavigatorSaveItem.Name = "medical_QueryBindingNavigatorSaveItem";
            this.medical_QueryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.medical_QueryBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // pharmacy_Patient_IDLabel
            // 
            pharmacy_Patient_IDLabel.AutoSize = true;
            pharmacy_Patient_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pharmacy_Patient_IDLabel.Location = new System.Drawing.Point(76, 100);
            pharmacy_Patient_IDLabel.Name = "pharmacy_Patient_IDLabel";
            pharmacy_Patient_IDLabel.Size = new System.Drawing.Size(159, 16);
            pharmacy_Patient_IDLabel.TabIndex = 1;
            pharmacy_Patient_IDLabel.Text = "Pharmacy Patient ID:";
            // 
            // pharmacy_Patient_IDTextBox
            // 
            this.pharmacy_Patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medical_QueryBindingSource, "Pharmacy_Patient ID", true));
            this.pharmacy_Patient_IDTextBox.Location = new System.Drawing.Point(328, 100);
            this.pharmacy_Patient_IDTextBox.Name = "pharmacy_Patient_IDTextBox";
            this.pharmacy_Patient_IDTextBox.Size = new System.Drawing.Size(139, 20);
            this.pharmacy_Patient_IDTextBox.TabIndex = 2;
            // 
            // pharmacy_Doc_s_NHS_NoLabel
            // 
            pharmacy_Doc_s_NHS_NoLabel.AutoSize = true;
            pharmacy_Doc_s_NHS_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pharmacy_Doc_s_NHS_NoLabel.Location = new System.Drawing.Point(76, 126);
            pharmacy_Doc_s_NHS_NoLabel.Name = "pharmacy_Doc_s_NHS_NoLabel";
            pharmacy_Doc_s_NHS_NoLabel.Size = new System.Drawing.Size(195, 16);
            pharmacy_Doc_s_NHS_NoLabel.TabIndex = 3;
            pharmacy_Doc_s_NHS_NoLabel.Text = "Pharmacy Doc\'s NHS No:";
            // 
            // pharmacy_Doc_s_NHS_NoTextBox
            // 
            this.pharmacy_Doc_s_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medical_QueryBindingSource, "Pharmacy_Doc\'s NHS No", true));
            this.pharmacy_Doc_s_NHS_NoTextBox.Location = new System.Drawing.Point(328, 126);
            this.pharmacy_Doc_s_NHS_NoTextBox.Name = "pharmacy_Doc_s_NHS_NoTextBox";
            this.pharmacy_Doc_s_NHS_NoTextBox.Size = new System.Drawing.Size(139, 20);
            this.pharmacy_Doc_s_NHS_NoTextBox.TabIndex = 4;
            // 
            // doctor_Doc_s_NHS_NoLabel
            // 
            doctor_Doc_s_NHS_NoLabel.AutoSize = true;
            doctor_Doc_s_NHS_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctor_Doc_s_NHS_NoLabel.Location = new System.Drawing.Point(76, 152);
            doctor_Doc_s_NHS_NoLabel.Name = "doctor_Doc_s_NHS_NoLabel";
            doctor_Doc_s_NHS_NoLabel.Size = new System.Drawing.Size(172, 16);
            doctor_Doc_s_NHS_NoLabel.TabIndex = 5;
            doctor_Doc_s_NHS_NoLabel.Text = "Doctor Doc\'s NHS No:";
            // 
            // doctor_Doc_s_NHS_NoTextBox
            // 
            this.doctor_Doc_s_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medical_QueryBindingSource, "Doctor_Doc\'s NHS No", true));
            this.doctor_Doc_s_NHS_NoTextBox.Location = new System.Drawing.Point(328, 152);
            this.doctor_Doc_s_NHS_NoTextBox.Name = "doctor_Doc_s_NHS_NoTextBox";
            this.doctor_Doc_s_NHS_NoTextBox.Size = new System.Drawing.Size(139, 20);
            this.doctor_Doc_s_NHS_NoTextBox.TabIndex = 6;
            // 
            // doctor_Patient_IDLabel
            // 
            doctor_Patient_IDLabel.AutoSize = true;
            doctor_Patient_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctor_Patient_IDLabel.Location = new System.Drawing.Point(76, 178);
            doctor_Patient_IDLabel.Name = "doctor_Patient_IDLabel";
            doctor_Patient_IDLabel.Size = new System.Drawing.Size(136, 16);
            doctor_Patient_IDLabel.TabIndex = 7;
            doctor_Patient_IDLabel.Text = "Doctor Patient ID:";
            // 
            // doctor_Patient_IDTextBox
            // 
            this.doctor_Patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medical_QueryBindingSource, "Doctor_Patient ID", true));
            this.doctor_Patient_IDTextBox.Location = new System.Drawing.Point(328, 178);
            this.doctor_Patient_IDTextBox.Name = "doctor_Patient_IDTextBox";
            this.doctor_Patient_IDTextBox.Size = new System.Drawing.Size(139, 20);
            this.doctor_Patient_IDTextBox.TabIndex = 8;
            // 
            // gP_Appointment_Patient_IDLabel
            // 
            gP_Appointment_Patient_IDLabel.AutoSize = true;
            gP_Appointment_Patient_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gP_Appointment_Patient_IDLabel.Location = new System.Drawing.Point(76, 204);
            gP_Appointment_Patient_IDLabel.Name = "gP_Appointment_Patient_IDLabel";
            gP_Appointment_Patient_IDLabel.Size = new System.Drawing.Size(204, 16);
            gP_Appointment_Patient_IDLabel.TabIndex = 9;
            gP_Appointment_Patient_IDLabel.Text = "GP Appointment Patient ID:";
            // 
            // gP_Appointment_Patient_IDTextBox
            // 
            this.gP_Appointment_Patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medical_QueryBindingSource, "GP Appointment_Patient ID", true));
            this.gP_Appointment_Patient_IDTextBox.Location = new System.Drawing.Point(328, 204);
            this.gP_Appointment_Patient_IDTextBox.Name = "gP_Appointment_Patient_IDTextBox";
            this.gP_Appointment_Patient_IDTextBox.Size = new System.Drawing.Size(139, 20);
            this.gP_Appointment_Patient_IDTextBox.TabIndex = 10;
            // 
            // gP_Appointment_Doc_s_NHS_NoLabel
            // 
            gP_Appointment_Doc_s_NHS_NoLabel.AutoSize = true;
            gP_Appointment_Doc_s_NHS_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gP_Appointment_Doc_s_NHS_NoLabel.Location = new System.Drawing.Point(523, 98);
            gP_Appointment_Doc_s_NHS_NoLabel.Name = "gP_Appointment_Doc_s_NHS_NoLabel";
            gP_Appointment_Doc_s_NHS_NoLabel.Size = new System.Drawing.Size(240, 16);
            gP_Appointment_Doc_s_NHS_NoLabel.TabIndex = 11;
            gP_Appointment_Doc_s_NHS_NoLabel.Text = "GP Appointment Doc\'s NHS No:";
            // 
            // gP_Appointment_Doc_s_NHS_NoTextBox
            // 
            this.gP_Appointment_Doc_s_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medical_QueryBindingSource, "GP Appointment_Doc\'s NHS No", true));
            this.gP_Appointment_Doc_s_NHS_NoTextBox.Location = new System.Drawing.Point(781, 97);
            this.gP_Appointment_Doc_s_NHS_NoTextBox.Name = "gP_Appointment_Doc_s_NHS_NoTextBox";
            this.gP_Appointment_Doc_s_NHS_NoTextBox.Size = new System.Drawing.Size(151, 20);
            this.gP_Appointment_Doc_s_NHS_NoTextBox.TabIndex = 12;
            // 
            // patient_Doc_s_NHS_NoLabel
            // 
            patient_Doc_s_NHS_NoLabel.AutoSize = true;
            patient_Doc_s_NHS_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_Doc_s_NHS_NoLabel.Location = new System.Drawing.Point(523, 124);
            patient_Doc_s_NHS_NoLabel.Name = "patient_Doc_s_NHS_NoLabel";
            patient_Doc_s_NHS_NoLabel.Size = new System.Drawing.Size(174, 16);
            patient_Doc_s_NHS_NoLabel.TabIndex = 13;
            patient_Doc_s_NHS_NoLabel.Text = "Patient Doc\'s NHS No:";
            // 
            // patient_Doc_s_NHS_NoTextBox
            // 
            this.patient_Doc_s_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medical_QueryBindingSource, "Patient_Doc\'s NHS No", true));
            this.patient_Doc_s_NHS_NoTextBox.Location = new System.Drawing.Point(781, 123);
            this.patient_Doc_s_NHS_NoTextBox.Name = "patient_Doc_s_NHS_NoTextBox";
            this.patient_Doc_s_NHS_NoTextBox.Size = new System.Drawing.Size(151, 20);
            this.patient_Doc_s_NHS_NoTextBox.TabIndex = 14;
            // 
            // patient_Patient_IDLabel
            // 
            patient_Patient_IDLabel.AutoSize = true;
            patient_Patient_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_Patient_IDLabel.Location = new System.Drawing.Point(523, 150);
            patient_Patient_IDLabel.Name = "patient_Patient_IDLabel";
            patient_Patient_IDLabel.Size = new System.Drawing.Size(138, 16);
            patient_Patient_IDLabel.TabIndex = 15;
            patient_Patient_IDLabel.Text = "Patient Patient ID:";
            // 
            // patient_Patient_IDTextBox
            // 
            this.patient_Patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medical_QueryBindingSource, "Patient_Patient ID", true));
            this.patient_Patient_IDTextBox.Location = new System.Drawing.Point(781, 149);
            this.patient_Patient_IDTextBox.Name = "patient_Patient_IDTextBox";
            this.patient_Patient_IDTextBox.Size = new System.Drawing.Size(151, 20);
            this.patient_Patient_IDTextBox.TabIndex = 16;
            // 
            // mastercardLabel
            // 
            mastercardLabel.AutoSize = true;
            mastercardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mastercardLabel.Location = new System.Drawing.Point(523, 176);
            mastercardLabel.Name = "mastercardLabel";
            mastercardLabel.Size = new System.Drawing.Size(92, 16);
            mastercardLabel.TabIndex = 17;
            mastercardLabel.Text = "Mastercard:";
            // 
            // mastercardTextBox
            // 
            this.mastercardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medical_QueryBindingSource, "Mastercard", true));
            this.mastercardTextBox.Location = new System.Drawing.Point(781, 175);
            this.mastercardTextBox.Name = "mastercardTextBox";
            this.mastercardTextBox.Size = new System.Drawing.Size(151, 20);
            this.mastercardTextBox.TabIndex = 18;
            // 
            // debit_CardLabel
            // 
            debit_CardLabel.AutoSize = true;
            debit_CardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            debit_CardLabel.Location = new System.Drawing.Point(523, 202);
            debit_CardLabel.Name = "debit_CardLabel";
            debit_CardLabel.Size = new System.Drawing.Size(91, 16);
            debit_CardLabel.TabIndex = 19;
            debit_CardLabel.Text = "Debit Card:";
            // 
            // debit_CardTextBox
            // 
            this.debit_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medical_QueryBindingSource, "Debit Card", true));
            this.debit_CardTextBox.Location = new System.Drawing.Point(781, 201);
            this.debit_CardTextBox.Name = "debit_CardTextBox";
            this.debit_CardTextBox.Size = new System.Drawing.Size(151, 20);
            this.debit_CardTextBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Medical Office";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.medical_QueryDataGridView);
            this.panel1.Location = new System.Drawing.Point(79, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 222);
            this.panel1.TabIndex = 22;
            // 
            // medical_QueryDataGridView
            // 
            this.medical_QueryDataGridView.AutoGenerateColumns = false;
            this.medical_QueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medical_QueryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.medical_QueryDataGridView.DataSource = this.medical_QueryBindingSource;
            this.medical_QueryDataGridView.Location = new System.Drawing.Point(3, 0);
            this.medical_QueryDataGridView.Name = "medical_QueryDataGridView";
            this.medical_QueryDataGridView.Size = new System.Drawing.Size(847, 220);
            this.medical_QueryDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Pharmacy_Patient ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Pharmacy_Patient ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Pharmacy_Doc\'s NHS No";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pharmacy_Doc\'s NHS No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Doctor_Doc\'s NHS No";
            this.dataGridViewTextBoxColumn3.HeaderText = "Doctor_Doc\'s NHS No";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Doctor_Patient ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Doctor_Patient ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GP Appointment_Patient ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "GP Appointment_Patient ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GP Appointment_Doc\'s NHS No";
            this.dataGridViewTextBoxColumn6.HeaderText = "GP Appointment_Doc\'s NHS No";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Patient_Doc\'s NHS No";
            this.dataGridViewTextBoxColumn7.HeaderText = "Patient_Doc\'s NHS No";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Patient_Patient ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Patient_Patient ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Mastercard";
            this.dataGridViewTextBoxColumn9.HeaderText = "Mastercard";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Debit Card";
            this.dataGridViewTextBoxColumn10.HeaderText = "Debit Card";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(pharmacy_Patient_IDLabel);
            this.Controls.Add(this.pharmacy_Patient_IDTextBox);
            this.Controls.Add(pharmacy_Doc_s_NHS_NoLabel);
            this.Controls.Add(this.pharmacy_Doc_s_NHS_NoTextBox);
            this.Controls.Add(doctor_Doc_s_NHS_NoLabel);
            this.Controls.Add(this.doctor_Doc_s_NHS_NoTextBox);
            this.Controls.Add(doctor_Patient_IDLabel);
            this.Controls.Add(this.doctor_Patient_IDTextBox);
            this.Controls.Add(gP_Appointment_Patient_IDLabel);
            this.Controls.Add(this.gP_Appointment_Patient_IDTextBox);
            this.Controls.Add(gP_Appointment_Doc_s_NHS_NoLabel);
            this.Controls.Add(this.gP_Appointment_Doc_s_NHS_NoTextBox);
            this.Controls.Add(patient_Doc_s_NHS_NoLabel);
            this.Controls.Add(this.patient_Doc_s_NHS_NoTextBox);
            this.Controls.Add(patient_Patient_IDLabel);
            this.Controls.Add(this.patient_Patient_IDTextBox);
            this.Controls.Add(mastercardLabel);
            this.Controls.Add(this.mastercardTextBox);
            this.Controls.Add(debit_CardLabel);
            this.Controls.Add(this.debit_CardTextBox);
            this.Controls.Add(this.medical_QueryBindingNavigator);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medical Office ";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_QueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medical_QueryBindingNavigator)).EndInit();
            this.medical_QueryBindingNavigator.ResumeLayout(false);
            this.medical_QueryBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medical_QueryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private medicalDataSet1 medicalDataSet1;
        private System.Windows.Forms.BindingSource medical_QueryBindingSource;
        private medicalDataSet1TableAdapters.Medical_QueryTableAdapter medical_QueryTableAdapter;
        private medicalDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medical_QueryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton medical_QueryBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox pharmacy_Patient_IDTextBox;
        private System.Windows.Forms.TextBox pharmacy_Doc_s_NHS_NoTextBox;
        private System.Windows.Forms.TextBox doctor_Doc_s_NHS_NoTextBox;
        private System.Windows.Forms.TextBox doctor_Patient_IDTextBox;
        private System.Windows.Forms.TextBox gP_Appointment_Patient_IDTextBox;
        private System.Windows.Forms.TextBox gP_Appointment_Doc_s_NHS_NoTextBox;
        private System.Windows.Forms.TextBox patient_Doc_s_NHS_NoTextBox;
        private System.Windows.Forms.TextBox patient_Patient_IDTextBox;
        private System.Windows.Forms.TextBox mastercardTextBox;
        private System.Windows.Forms.TextBox debit_CardTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView medical_QueryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}