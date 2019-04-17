namespace medical_store
{
    partial class Form6
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
            System.Windows.Forms.Label name_of_medicineLabel;
            System.Windows.Forms.Label dose__mg_Label;
            System.Windows.Forms.Label issued_DateLabel;
            System.Windows.Forms.Label exp_DateLabel;
            System.Windows.Forms.Label daily_DoseLabel;
            System.Windows.Forms.Label storage_AdviceLabel;
            System.Windows.Forms.Label use_of_MedicineLabel;
            System.Windows.Forms.Label patient_IDLabel;
            System.Windows.Forms.Label doc_s_NHS_NoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.medicalDataSet = new medical_store.medicalDataSet();
            this.pharmacyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyTableAdapter = new medical_store.medicalDataSetTableAdapters.PharmacyTableAdapter();
            this.tableAdapterManager = new medical_store.medicalDataSetTableAdapters.TableAdapterManager();
            this.pharmacyBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.medicalDataSet1 = new medical_store.medicalDataSet1();
            this.pharmacyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacyTableAdapter1 = new medical_store.medicalDataSet1TableAdapters.PharmacyTableAdapter();
            this.tableAdapterManager1 = new medical_store.medicalDataSet1TableAdapters.TableAdapterManager();
            this.name_of_medicineTextBox = new System.Windows.Forms.TextBox();
            this.dose__mg_TextBox = new System.Windows.Forms.TextBox();
            this.issued_DateTextBox = new System.Windows.Forms.TextBox();
            this.exp_DateTextBox = new System.Windows.Forms.TextBox();
            this.daily_DoseTextBox = new System.Windows.Forms.TextBox();
            this.storage_AdviceTextBox = new System.Windows.Forms.TextBox();
            this.use_of_MedicineTextBox = new System.Windows.Forms.TextBox();
            this.patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.doc_s_NHS_NoTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.pharmacyBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pharmacyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            name_of_medicineLabel = new System.Windows.Forms.Label();
            dose__mg_Label = new System.Windows.Forms.Label();
            issued_DateLabel = new System.Windows.Forms.Label();
            exp_DateLabel = new System.Windows.Forms.Label();
            daily_DoseLabel = new System.Windows.Forms.Label();
            storage_AdviceLabel = new System.Windows.Forms.Label();
            use_of_MedicineLabel = new System.Windows.Forms.Label();
            patient_IDLabel = new System.Windows.Forms.Label();
            doc_s_NHS_NoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingNavigator)).BeginInit();
            this.pharmacyBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // medicalDataSet
            // 
            this.medicalDataSet.DataSetName = "medicalDataSet";
            this.medicalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacyBindingSource
            // 
            this.pharmacyBindingSource.DataMember = "Pharmacy";
            this.pharmacyBindingSource.DataSource = this.medicalDataSet;
            // 
            // pharmacyTableAdapter
            // 
            this.pharmacyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GP_Appointment_NoTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = this.pharmacyTableAdapter;
            this.tableAdapterManager.UpdateOrder = medical_store.medicalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pharmacyBindingNavigator
            // 
            this.pharmacyBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pharmacyBindingNavigator.BindingSource = this.pharmacyBindingSource;
            this.pharmacyBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pharmacyBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pharmacyBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pharmacyBindingNavigatorSaveItem});
            this.pharmacyBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pharmacyBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pharmacyBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pharmacyBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pharmacyBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pharmacyBindingNavigator.Name = "pharmacyBindingNavigator";
            this.pharmacyBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pharmacyBindingNavigator.Size = new System.Drawing.Size(984, 25);
            this.pharmacyBindingNavigator.TabIndex = 0;
            this.pharmacyBindingNavigator.Text = "bindingNavigator1";
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
            // pharmacyBindingSource1
            // 
            this.pharmacyBindingSource1.DataMember = "Pharmacy";
            this.pharmacyBindingSource1.DataSource = this.medicalDataSet1;
            // 
            // pharmacyTableAdapter1
            // 
            this.pharmacyTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.DoctorTableAdapter = null;
            this.tableAdapterManager1.GP_AppointmentTableAdapter = null;
            this.tableAdapterManager1.PatientTableAdapter = null;
            this.tableAdapterManager1.PaymentTableAdapter = null;
            this.tableAdapterManager1.PharmacyTableAdapter = this.pharmacyTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = medical_store.medicalDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // name_of_medicineLabel
            // 
            name_of_medicineLabel.AutoSize = true;
            name_of_medicineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            name_of_medicineLabel.Location = new System.Drawing.Point(93, 92);
            name_of_medicineLabel.Name = "name_of_medicineLabel";
            name_of_medicineLabel.Size = new System.Drawing.Size(141, 16);
            name_of_medicineLabel.TabIndex = 1;
            name_of_medicineLabel.Text = "Name of medicine:";
            // 
            // name_of_medicineTextBox
            // 
            this.name_of_medicineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource1, "Name of medicine", true));
            this.name_of_medicineTextBox.Location = new System.Drawing.Point(240, 92);
            this.name_of_medicineTextBox.Name = "name_of_medicineTextBox";
            this.name_of_medicineTextBox.Size = new System.Drawing.Size(146, 20);
            this.name_of_medicineTextBox.TabIndex = 2;
            // 
            // dose__mg_Label
            // 
            dose__mg_Label.AutoSize = true;
            dose__mg_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dose__mg_Label.Location = new System.Drawing.Point(93, 118);
            dose__mg_Label.Name = "dose__mg_Label";
            dose__mg_Label.Size = new System.Drawing.Size(89, 16);
            dose__mg_Label.TabIndex = 3;
            dose__mg_Label.Text = "Dose (mg):";
            // 
            // dose__mg_TextBox
            // 
            this.dose__mg_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource1, "Dose (mg)", true));
            this.dose__mg_TextBox.Location = new System.Drawing.Point(240, 118);
            this.dose__mg_TextBox.Name = "dose__mg_TextBox";
            this.dose__mg_TextBox.Size = new System.Drawing.Size(146, 20);
            this.dose__mg_TextBox.TabIndex = 4;
            // 
            // issued_DateLabel
            // 
            issued_DateLabel.AutoSize = true;
            issued_DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            issued_DateLabel.Location = new System.Drawing.Point(93, 144);
            issued_DateLabel.Name = "issued_DateLabel";
            issued_DateLabel.Size = new System.Drawing.Size(99, 16);
            issued_DateLabel.TabIndex = 5;
            issued_DateLabel.Text = "Issued Date:";
            // 
            // issued_DateTextBox
            // 
            this.issued_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource1, "Issued Date", true));
            this.issued_DateTextBox.Location = new System.Drawing.Point(240, 144);
            this.issued_DateTextBox.Name = "issued_DateTextBox";
            this.issued_DateTextBox.Size = new System.Drawing.Size(146, 20);
            this.issued_DateTextBox.TabIndex = 6;
            // 
            // exp_DateLabel
            // 
            exp_DateLabel.AutoSize = true;
            exp_DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            exp_DateLabel.Location = new System.Drawing.Point(93, 170);
            exp_DateLabel.Name = "exp_DateLabel";
            exp_DateLabel.Size = new System.Drawing.Size(79, 16);
            exp_DateLabel.TabIndex = 7;
            exp_DateLabel.Text = "Exp Date:";
            // 
            // exp_DateTextBox
            // 
            this.exp_DateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource1, "Exp Date", true));
            this.exp_DateTextBox.Location = new System.Drawing.Point(240, 170);
            this.exp_DateTextBox.Name = "exp_DateTextBox";
            this.exp_DateTextBox.Size = new System.Drawing.Size(146, 20);
            this.exp_DateTextBox.TabIndex = 8;
            // 
            // daily_DoseLabel
            // 
            daily_DoseLabel.AutoSize = true;
            daily_DoseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            daily_DoseLabel.Location = new System.Drawing.Point(93, 196);
            daily_DoseLabel.Name = "daily_DoseLabel";
            daily_DoseLabel.Size = new System.Drawing.Size(93, 16);
            daily_DoseLabel.TabIndex = 9;
            daily_DoseLabel.Text = "Daily Dose:";
            // 
            // daily_DoseTextBox
            // 
            this.daily_DoseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource1, "Daily Dose", true));
            this.daily_DoseTextBox.Location = new System.Drawing.Point(240, 196);
            this.daily_DoseTextBox.Name = "daily_DoseTextBox";
            this.daily_DoseTextBox.Size = new System.Drawing.Size(146, 20);
            this.daily_DoseTextBox.TabIndex = 10;
            // 
            // storage_AdviceLabel
            // 
            storage_AdviceLabel.AutoSize = true;
            storage_AdviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            storage_AdviceLabel.Location = new System.Drawing.Point(526, 92);
            storage_AdviceLabel.Name = "storage_AdviceLabel";
            storage_AdviceLabel.Size = new System.Drawing.Size(123, 16);
            storage_AdviceLabel.TabIndex = 11;
            storage_AdviceLabel.Text = "Storage Advice:";
            // 
            // storage_AdviceTextBox
            // 
            this.storage_AdviceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource1, "Storage Advice", true));
            this.storage_AdviceTextBox.Location = new System.Drawing.Point(679, 92);
            this.storage_AdviceTextBox.Name = "storage_AdviceTextBox";
            this.storage_AdviceTextBox.Size = new System.Drawing.Size(151, 20);
            this.storage_AdviceTextBox.TabIndex = 12;
            // 
            // use_of_MedicineLabel
            // 
            use_of_MedicineLabel.AutoSize = true;
            use_of_MedicineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            use_of_MedicineLabel.Location = new System.Drawing.Point(526, 118);
            use_of_MedicineLabel.Name = "use_of_MedicineLabel";
            use_of_MedicineLabel.Size = new System.Drawing.Size(129, 16);
            use_of_MedicineLabel.TabIndex = 13;
            use_of_MedicineLabel.Text = "Use of Medicine:";
            // 
            // use_of_MedicineTextBox
            // 
            this.use_of_MedicineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource1, "Use of Medicine", true));
            this.use_of_MedicineTextBox.Location = new System.Drawing.Point(679, 118);
            this.use_of_MedicineTextBox.Name = "use_of_MedicineTextBox";
            this.use_of_MedicineTextBox.Size = new System.Drawing.Size(151, 20);
            this.use_of_MedicineTextBox.TabIndex = 14;
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_IDLabel.Location = new System.Drawing.Point(526, 144);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(84, 16);
            patient_IDLabel.TabIndex = 15;
            patient_IDLabel.Text = "Patient ID:";
            // 
            // patient_IDTextBox
            // 
            this.patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource1, "Patient ID", true));
            this.patient_IDTextBox.Location = new System.Drawing.Point(679, 144);
            this.patient_IDTextBox.Name = "patient_IDTextBox";
            this.patient_IDTextBox.Size = new System.Drawing.Size(151, 20);
            this.patient_IDTextBox.TabIndex = 16;
            // 
            // doc_s_NHS_NoLabel
            // 
            doc_s_NHS_NoLabel.AutoSize = true;
            doc_s_NHS_NoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doc_s_NHS_NoLabel.Location = new System.Drawing.Point(526, 170);
            doc_s_NHS_NoLabel.Name = "doc_s_NHS_NoLabel";
            doc_s_NHS_NoLabel.Size = new System.Drawing.Size(120, 16);
            doc_s_NHS_NoLabel.TabIndex = 17;
            doc_s_NHS_NoLabel.Text = "Doc\'s NHS No:";
            // 
            // doc_s_NHS_NoTextBox
            // 
            this.doc_s_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pharmacyBindingSource1, "Doc\'s NHS No", true));
            this.doc_s_NHS_NoTextBox.Location = new System.Drawing.Point(679, 170);
            this.doc_s_NHS_NoTextBox.Name = "doc_s_NHS_NoTextBox";
            this.doc_s_NHS_NoTextBox.Size = new System.Drawing.Size(151, 20);
            this.doc_s_NHS_NoTextBox.TabIndex = 18;
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
            // pharmacyBindingNavigatorSaveItem
            // 
            this.pharmacyBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pharmacyBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pharmacyBindingNavigatorSaveItem.Image")));
            this.pharmacyBindingNavigatorSaveItem.Name = "pharmacyBindingNavigatorSaveItem";
            this.pharmacyBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pharmacyBindingNavigatorSaveItem.Text = "Save Data";
            this.pharmacyBindingNavigatorSaveItem.Click += new System.EventHandler(this.pharmacyBindingNavigatorSaveItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pharmacyDataGridView);
            this.panel1.Location = new System.Drawing.Point(96, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 205);
            this.panel1.TabIndex = 19;
            // 
            // pharmacyDataGridView
            // 
            this.pharmacyDataGridView.AutoGenerateColumns = false;
            this.pharmacyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pharmacyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.pharmacyDataGridView.DataSource = this.pharmacyBindingSource1;
            this.pharmacyDataGridView.Location = new System.Drawing.Point(0, 0);
            this.pharmacyDataGridView.Name = "pharmacyDataGridView";
            this.pharmacyDataGridView.Size = new System.Drawing.Size(741, 202);
            this.pharmacyDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name of medicine";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name of medicine";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Dose (mg)";
            this.dataGridViewTextBoxColumn2.HeaderText = "Dose (mg)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Issued Date";
            this.dataGridViewTextBoxColumn3.HeaderText = "Issued Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Exp Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Exp Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Daily Dose";
            this.dataGridViewTextBoxColumn5.HeaderText = "Daily Dose";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Storage Advice";
            this.dataGridViewTextBoxColumn6.HeaderText = "Storage Advice";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Use of Medicine";
            this.dataGridViewTextBoxColumn7.HeaderText = "Use of Medicine";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Patient ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "Patient ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Doc\'s NHS No";
            this.dataGridViewTextBoxColumn9.HeaderText = "Doc\'s NHS No";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Pharmacy Report";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnnext);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Location = new System.Drawing.Point(342, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 36);
            this.panel2.TabIndex = 26;
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
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 588);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(name_of_medicineLabel);
            this.Controls.Add(this.name_of_medicineTextBox);
            this.Controls.Add(dose__mg_Label);
            this.Controls.Add(this.dose__mg_TextBox);
            this.Controls.Add(issued_DateLabel);
            this.Controls.Add(this.issued_DateTextBox);
            this.Controls.Add(exp_DateLabel);
            this.Controls.Add(this.exp_DateTextBox);
            this.Controls.Add(daily_DoseLabel);
            this.Controls.Add(this.daily_DoseTextBox);
            this.Controls.Add(storage_AdviceLabel);
            this.Controls.Add(this.storage_AdviceTextBox);
            this.Controls.Add(use_of_MedicineLabel);
            this.Controls.Add(this.use_of_MedicineTextBox);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDTextBox);
            this.Controls.Add(doc_s_NHS_NoLabel);
            this.Controls.Add(this.doc_s_NHS_NoTextBox);
            this.Controls.Add(this.pharmacyBindingNavigator);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingNavigator)).EndInit();
            this.pharmacyBindingNavigator.ResumeLayout(false);
            this.pharmacyBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private medicalDataSet medicalDataSet;
        private System.Windows.Forms.BindingSource pharmacyBindingSource;
        private medicalDataSetTableAdapters.PharmacyTableAdapter pharmacyTableAdapter;
        private medicalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pharmacyBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pharmacyBindingNavigatorSaveItem;
        private medicalDataSet1 medicalDataSet1;
        private System.Windows.Forms.BindingSource pharmacyBindingSource1;
        private medicalDataSet1TableAdapters.PharmacyTableAdapter pharmacyTableAdapter1;
        private medicalDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox name_of_medicineTextBox;
        private System.Windows.Forms.TextBox dose__mg_TextBox;
        private System.Windows.Forms.TextBox issued_DateTextBox;
        private System.Windows.Forms.TextBox exp_DateTextBox;
        private System.Windows.Forms.TextBox daily_DoseTextBox;
        private System.Windows.Forms.TextBox storage_AdviceTextBox;
        private System.Windows.Forms.TextBox use_of_MedicineTextBox;
        private System.Windows.Forms.TextBox patient_IDTextBox;
        private System.Windows.Forms.TextBox doc_s_NHS_NoTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView pharmacyDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
    }
}