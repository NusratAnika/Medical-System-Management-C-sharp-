namespace medical_store
{
    partial class Form3
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
            System.Windows.Forms.Label gP_Appointment_RefLabel;
            System.Windows.Forms.Label patient_NHS_NoLabel;
            System.Windows.Forms.Label gP_AppointmentLabel;
            System.Windows.Forms.Label patient_Full_NameLabel;
            System.Windows.Forms.Label patient_IDLabel;
            System.Windows.Forms.Label doc_s_NHS_NoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.medicalDataSet = new medical_store.medicalDataSet();
            this.gP_Appointment_NoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gP_Appointment_NoTableAdapter = new medical_store.medicalDataSetTableAdapters.GP_Appointment_NoTableAdapter();
            this.tableAdapterManager = new medical_store.medicalDataSetTableAdapters.TableAdapterManager();
            this.gP_Appointment_NoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.medicalDataSet1 = new medical_store.medicalDataSet1();
            this.gP_AppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gP_AppointmentTableAdapter = new medical_store.medicalDataSet1TableAdapters.GP_AppointmentTableAdapter();
            this.tableAdapterManager1 = new medical_store.medicalDataSet1TableAdapters.TableAdapterManager();
            this.gP_Appointment_RefTextBox = new System.Windows.Forms.TextBox();
            this.patient_NHS_NoTextBox = new System.Windows.Forms.TextBox();
            this.gP_AppointmentTextBox = new System.Windows.Forms.TextBox();
            this.patient_Full_NameTextBox = new System.Windows.Forms.TextBox();
            this.patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.doc_s_NHS_NoTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.gP_Appointment_NoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gP_AppointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            gP_Appointment_RefLabel = new System.Windows.Forms.Label();
            patient_NHS_NoLabel = new System.Windows.Forms.Label();
            gP_AppointmentLabel = new System.Windows.Forms.Label();
            patient_Full_NameLabel = new System.Windows.Forms.Label();
            patient_IDLabel = new System.Windows.Forms.Label();
            doc_s_NHS_NoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_Appointment_NoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_Appointment_NoBindingNavigator)).BeginInit();
            this.gP_Appointment_NoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // medicalDataSet
            // 
            this.medicalDataSet.DataSetName = "medicalDataSet";
            this.medicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gP_Appointment_NoBindingSource
            // 
            this.gP_Appointment_NoBindingSource.DataMember = "GP Appointment No";
            this.gP_Appointment_NoBindingSource.DataSource = this.medicalDataSet;
            // 
            // gP_Appointment_NoTableAdapter
            // 
            this.gP_Appointment_NoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GP_Appointment_NoTableAdapter = this.gP_Appointment_NoTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = medical_store.medicalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gP_Appointment_NoBindingNavigator
            // 
            this.gP_Appointment_NoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gP_Appointment_NoBindingNavigator.BindingSource = this.gP_Appointment_NoBindingSource;
            this.gP_Appointment_NoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gP_Appointment_NoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gP_Appointment_NoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gP_Appointment_NoBindingNavigatorSaveItem});
            this.gP_Appointment_NoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gP_Appointment_NoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gP_Appointment_NoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gP_Appointment_NoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gP_Appointment_NoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gP_Appointment_NoBindingNavigator.Name = "gP_Appointment_NoBindingNavigator";
            this.gP_Appointment_NoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gP_Appointment_NoBindingNavigator.Size = new System.Drawing.Size(984, 25);
            this.gP_Appointment_NoBindingNavigator.TabIndex = 0;
            this.gP_Appointment_NoBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // medicalDataSet1
            // 
            this.medicalDataSet1.DataSetName = "medicalDataSet1";
            this.medicalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gP_AppointmentBindingSource
            // 
            this.gP_AppointmentBindingSource.DataMember = "GP Appointment";
            this.gP_AppointmentBindingSource.DataSource = this.medicalDataSet1;
            // 
            // gP_AppointmentTableAdapter
            // 
            this.gP_AppointmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DoctorTableAdapter = null;
            this.tableAdapterManager1.GP_AppointmentTableAdapter = this.gP_AppointmentTableAdapter;
            this.tableAdapterManager1.PatientTableAdapter = null;
            this.tableAdapterManager1.PaymentTableAdapter = null;
            this.tableAdapterManager1.PharmacyTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = medical_store.medicalDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gP_Appointment_RefLabel
            // 
            gP_Appointment_RefLabel.AutoSize = true;
            gP_Appointment_RefLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gP_Appointment_RefLabel.Location = new System.Drawing.Point(280, 84);
            gP_Appointment_RefLabel.Name = "gP_Appointment_RefLabel";
            gP_Appointment_RefLabel.Size = new System.Drawing.Size(158, 16);
            gP_Appointment_RefLabel.TabIndex = 1;
            gP_Appointment_RefLabel.Text = "GP Appointment Ref:";
            // 
            // gP_Appointment_RefTextBox
            // 
            this.gP_Appointment_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "GP Appointment Ref", true));
            this.gP_Appointment_RefTextBox.Location = new System.Drawing.Point(522, 84);
            this.gP_Appointment_RefTextBox.Name = "gP_Appointment_RefTextBox";
            this.gP_Appointment_RefTextBox.Size = new System.Drawing.Size(161, 20);
            this.gP_Appointment_RefTextBox.TabIndex = 2;
            // 
            // patient_NHS_NoLabel
            // 
            patient_NHS_NoLabel.AutoSize = true;
            patient_NHS_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_NHS_NoLabel.Location = new System.Drawing.Point(280, 110);
            patient_NHS_NoLabel.Name = "patient_NHS_NoLabel";
            patient_NHS_NoLabel.Size = new System.Drawing.Size(128, 16);
            patient_NHS_NoLabel.TabIndex = 3;
            patient_NHS_NoLabel.Text = "Patient NHS No:";
            // 
            // patient_NHS_NoTextBox
            // 
            this.patient_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Patient NHS No", true));
            this.patient_NHS_NoTextBox.Location = new System.Drawing.Point(522, 110);
            this.patient_NHS_NoTextBox.Name = "patient_NHS_NoTextBox";
            this.patient_NHS_NoTextBox.Size = new System.Drawing.Size(161, 20);
            this.patient_NHS_NoTextBox.TabIndex = 4;
            // 
            // gP_AppointmentLabel
            // 
            gP_AppointmentLabel.AutoSize = true;
            gP_AppointmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gP_AppointmentLabel.Location = new System.Drawing.Point(280, 136);
            gP_AppointmentLabel.Name = "gP_AppointmentLabel";
            gP_AppointmentLabel.Size = new System.Drawing.Size(128, 16);
            gP_AppointmentLabel.TabIndex = 5;
            gP_AppointmentLabel.Text = "GP Appointment:";
            // 
            // gP_AppointmentTextBox
            // 
            this.gP_AppointmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "GP Appointment", true));
            this.gP_AppointmentTextBox.Location = new System.Drawing.Point(522, 136);
            this.gP_AppointmentTextBox.Name = "gP_AppointmentTextBox";
            this.gP_AppointmentTextBox.Size = new System.Drawing.Size(161, 20);
            this.gP_AppointmentTextBox.TabIndex = 6;
            // 
            // patient_Full_NameLabel
            // 
            patient_Full_NameLabel.AutoSize = true;
            patient_Full_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_Full_NameLabel.Location = new System.Drawing.Point(280, 162);
            patient_Full_NameLabel.Name = "patient_Full_NameLabel";
            patient_Full_NameLabel.Size = new System.Drawing.Size(140, 16);
            patient_Full_NameLabel.TabIndex = 7;
            patient_Full_NameLabel.Text = "Patient Full Name:";
            // 
            // patient_Full_NameTextBox
            // 
            this.patient_Full_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Patient Full Name", true));
            this.patient_Full_NameTextBox.Location = new System.Drawing.Point(522, 162);
            this.patient_Full_NameTextBox.Name = "patient_Full_NameTextBox";
            this.patient_Full_NameTextBox.Size = new System.Drawing.Size(161, 20);
            this.patient_Full_NameTextBox.TabIndex = 8;
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_IDLabel.Location = new System.Drawing.Point(280, 188);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(84, 16);
            patient_IDLabel.TabIndex = 9;
            patient_IDLabel.Text = "Patient ID:";
            // 
            // patient_IDTextBox
            // 
            this.patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Patient ID", true));
            this.patient_IDTextBox.Location = new System.Drawing.Point(522, 188);
            this.patient_IDTextBox.Name = "patient_IDTextBox";
            this.patient_IDTextBox.Size = new System.Drawing.Size(161, 20);
            this.patient_IDTextBox.TabIndex = 10;
            // 
            // doc_s_NHS_NoLabel
            // 
            doc_s_NHS_NoLabel.AutoSize = true;
            doc_s_NHS_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doc_s_NHS_NoLabel.Location = new System.Drawing.Point(280, 214);
            doc_s_NHS_NoLabel.Name = "doc_s_NHS_NoLabel";
            doc_s_NHS_NoLabel.Size = new System.Drawing.Size(120, 16);
            doc_s_NHS_NoLabel.TabIndex = 11;
            doc_s_NHS_NoLabel.Text = "Doc\'s NHS No:";
            // 
            // doc_s_NHS_NoTextBox
            // 
            this.doc_s_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gP_AppointmentBindingSource, "Doc\'s NHS No", true));
            this.doc_s_NHS_NoTextBox.Location = new System.Drawing.Point(522, 214);
            this.doc_s_NHS_NoTextBox.Name = "doc_s_NHS_NoTextBox";
            this.doc_s_NHS_NoTextBox.Size = new System.Drawing.Size(161, 20);
            this.doc_s_NHS_NoTextBox.TabIndex = 12;
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
            // gP_Appointment_NoBindingNavigatorSaveItem
            // 
            this.gP_Appointment_NoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gP_Appointment_NoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gP_Appointment_NoBindingNavigatorSaveItem.Image")));
            this.gP_Appointment_NoBindingNavigatorSaveItem.Name = "gP_Appointment_NoBindingNavigatorSaveItem";
            this.gP_Appointment_NoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.gP_Appointment_NoBindingNavigatorSaveItem.Text = "Save Data";
            this.gP_Appointment_NoBindingNavigatorSaveItem.Click += new System.EventHandler(this.gP_Appointment_NoBindingNavigatorSaveItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gP_AppointmentDataGridView);
            this.panel1.Location = new System.Drawing.Point(160, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 226);
            this.panel1.TabIndex = 13;
            // 
            // gP_AppointmentDataGridView
            // 
            this.gP_AppointmentDataGridView.AutoGenerateColumns = false;
            this.gP_AppointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gP_AppointmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gP_AppointmentDataGridView.DataSource = this.gP_AppointmentBindingSource;
            this.gP_AppointmentDataGridView.Location = new System.Drawing.Point(0, 3);
            this.gP_AppointmentDataGridView.Name = "gP_AppointmentDataGridView";
            this.gP_AppointmentDataGridView.Size = new System.Drawing.Size(643, 220);
            this.gP_AppointmentDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GP Appointment Ref";
            this.dataGridViewTextBoxColumn1.HeaderText = "GP Appointment Ref";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Patient NHS No";
            this.dataGridViewTextBoxColumn2.HeaderText = "Patient NHS No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GP Appointment";
            this.dataGridViewTextBoxColumn3.HeaderText = "GP Appointment";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Patient Full Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Patient Full Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Patient ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Patient ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Doc\'s NHS No";
            this.dataGridViewTextBoxColumn6.HeaderText = "Doc\'s NHS No";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "GP Report";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnnext);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Location = new System.Drawing.Point(318, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 36);
            this.panel2.TabIndex = 25;
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(394, 0);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(87, 33);
            this.btnexit.TabIndex = 26;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(298, 1);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(87, 33);
            this.btnsave.TabIndex = 25;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.Location = new System.Drawing.Point(202, 1);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(87, 33);
            this.btnnext.TabIndex = 24;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(103, 1);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(87, 33);
            this.btndelete.TabIndex = 23;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(3, 0);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(87, 33);
            this.btnadd.TabIndex = 22;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 596);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(gP_Appointment_RefLabel);
            this.Controls.Add(this.gP_Appointment_RefTextBox);
            this.Controls.Add(patient_NHS_NoLabel);
            this.Controls.Add(this.patient_NHS_NoTextBox);
            this.Controls.Add(gP_AppointmentLabel);
            this.Controls.Add(this.gP_AppointmentTextBox);
            this.Controls.Add(patient_Full_NameLabel);
            this.Controls.Add(this.patient_Full_NameTextBox);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDTextBox);
            this.Controls.Add(doc_s_NHS_NoLabel);
            this.Controls.Add(this.doc_s_NHS_NoTextBox);
            this.Controls.Add(this.gP_Appointment_NoBindingNavigator);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GP Appointment ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_Appointment_NoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_Appointment_NoBindingNavigator)).EndInit();
            this.gP_Appointment_NoBindingNavigator.ResumeLayout(false);
            this.gP_Appointment_NoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gP_AppointmentDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private medicalDataSet medicalDataSet;
        private System.Windows.Forms.BindingSource gP_Appointment_NoBindingSource;
        private medicalDataSetTableAdapters.GP_Appointment_NoTableAdapter gP_Appointment_NoTableAdapter;
        private medicalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator gP_Appointment_NoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gP_Appointment_NoBindingNavigatorSaveItem;
        private medicalDataSet1 medicalDataSet1;
        private System.Windows.Forms.BindingSource gP_AppointmentBindingSource;
        private medicalDataSet1TableAdapters.GP_AppointmentTableAdapter gP_AppointmentTableAdapter;
        private medicalDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox gP_Appointment_RefTextBox;
        private System.Windows.Forms.TextBox patient_NHS_NoTextBox;
        private System.Windows.Forms.TextBox gP_AppointmentTextBox;
        private System.Windows.Forms.TextBox patient_Full_NameTextBox;
        private System.Windows.Forms.TextBox patient_IDTextBox;
        private System.Windows.Forms.TextBox doc_s_NHS_NoTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gP_AppointmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
    }
}