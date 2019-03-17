namespace Vtdi_Gatelog
{
    partial class GateIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GateIn));
            this.BtSave = new System.Windows.Forms.Button();
            this.BtCancel = new System.Windows.Forms.Button();
            this.BTExit = new System.Windows.Forms.Button();
            this.LbLicense = new System.Windows.Forms.Label();
            this.LbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLic = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.fKGateInTablePurposeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purposeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gateInDatabaseDataSet = new Vtdi_Gatelog.GateInDatabaseDataSet();
            this.LbEmployeeNum = new System.Windows.Forms.Label();
            this.LbEmpID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.purposeTableAdapter = new Vtdi_Gatelog.GateInDatabaseDataSetTableAdapters.PurposeTableAdapter();
            this.gateInTableTableAdapter = new Vtdi_Gatelog.GateInDatabaseDataSetTableAdapters.GateInTableTableAdapter();
            this.cbreason = new System.Windows.Forms.ComboBox();
            this.cbitems = new System.Windows.Forms.ComboBox();
            this.itemstoDeclareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbvehicle = new System.Windows.Forms.ComboBox();
            this.vehicletypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderTableAdapter = new Vtdi_Gatelog.GateInDatabaseDataSetTableAdapters.GenderTableAdapter();
            this.itemstoDeclareTableAdapter = new Vtdi_Gatelog.GateInDatabaseDataSetTableAdapters.ItemstoDeclareTableAdapter();
            this.vehicletypesTableAdapter = new Vtdi_Gatelog.GateInDatabaseDataSetTableAdapters.VehicletypesTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fKGateInTablePurposeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gateInDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemstoDeclareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicletypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtSave
            // 
            this.BtSave.BackColor = System.Drawing.Color.Green;
            this.BtSave.FlatAppearance.BorderSize = 0;
            this.BtSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSave.ForeColor = System.Drawing.Color.White;
            this.BtSave.Location = new System.Drawing.Point(305, 344);
            this.BtSave.Name = "BtSave";
            this.BtSave.Size = new System.Drawing.Size(68, 26);
            this.BtSave.TabIndex = 80;
            this.BtSave.Text = "Save";
            this.BtSave.UseVisualStyleBackColor = false;
            this.BtSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // BtCancel
            // 
            this.BtCancel.BackColor = System.Drawing.Color.Green;
            this.BtCancel.FlatAppearance.BorderSize = 0;
            this.BtCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancel.ForeColor = System.Drawing.Color.White;
            this.BtCancel.Location = new System.Drawing.Point(402, 344);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(76, 26);
            this.BtCancel.TabIndex = 81;
            this.BtCancel.Text = "Cancel";
            this.BtCancel.UseVisualStyleBackColor = false;
            this.BtCancel.Click += new System.EventHandler(this.BtCancel_Click);
            // 
            // BTExit
            // 
            this.BTExit.BackColor = System.Drawing.Color.Green;
            this.BTExit.FlatAppearance.BorderSize = 0;
            this.BTExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTExit.ForeColor = System.Drawing.Color.White;
            this.BTExit.Location = new System.Drawing.Point(517, 344);
            this.BTExit.Name = "BTExit";
            this.BTExit.Size = new System.Drawing.Size(84, 26);
            this.BTExit.TabIndex = 82;
            this.BTExit.Text = "Exit";
            this.BTExit.UseVisualStyleBackColor = false;
            this.BTExit.Click += new System.EventHandler(this.BTExit_Click);
            // 
            // LbLicense
            // 
            this.LbLicense.AutoSize = true;
            this.LbLicense.BackColor = System.Drawing.Color.Transparent;
            this.LbLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLicense.ForeColor = System.Drawing.Color.White;
            this.LbLicense.Location = new System.Drawing.Point(296, 95);
            this.LbLicense.Name = "LbLicense";
            this.LbLicense.Size = new System.Drawing.Size(69, 15);
            this.LbLicense.TabIndex = 3;
            this.LbLicense.Text = "License #";
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.BackColor = System.Drawing.Color.Transparent;
            this.LbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbName.ForeColor = System.Drawing.Color.White;
            this.LbName.Location = new System.Drawing.Point(296, 24);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(77, 15);
            this.LbName.TabIndex = 6;
            this.LbName.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reason for Visit";
            // 
            // txtLic
            // 
            this.txtLic.Location = new System.Drawing.Point(402, 84);
            this.txtLic.Multiline = true;
            this.txtLic.Name = "txtLic";
            this.txtLic.Size = new System.Drawing.Size(155, 26);
            this.txtLic.TabIndex = 20;
            this.txtLic.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(402, 12);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(155, 26);
            this.txtFirstName.TabIndex = 32;
            // 
            // fKGateInTablePurposeBindingSource
            // 
            this.fKGateInTablePurposeBindingSource.DataMember = "FK_GateInTable_Purpose";
            this.fKGateInTablePurposeBindingSource.DataSource = this.purposeBindingSource;
            // 
            // purposeBindingSource
            // 
            this.purposeBindingSource.DataMember = "Purpose";
            this.purposeBindingSource.DataSource = this.gateInDatabaseDataSet;
            // 
            // gateInDatabaseDataSet
            // 
            this.gateInDatabaseDataSet.DataSetName = "GateInDatabaseDataSet";
            this.gateInDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LbEmployeeNum
            // 
            this.LbEmployeeNum.AutoSize = true;
            this.LbEmployeeNum.Location = new System.Drawing.Point(227, -1);
            this.LbEmployeeNum.Name = "LbEmployeeNum";
            this.LbEmployeeNum.Size = new System.Drawing.Size(63, 13);
            this.LbEmployeeNum.TabIndex = 80;
            this.LbEmployeeNum.Text = "Employee #";
            // 
            // LbEmpID
            // 
            this.LbEmpID.AutoSize = true;
            this.LbEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEmpID.Location = new System.Drawing.Point(251, 12);
            this.LbEmpID.Name = "LbEmpID";
            this.LbEmpID.Size = new System.Drawing.Size(39, 13);
            this.LbEmpID.TabIndex = 81;
            this.LbEmpID.Text = "QD90";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(294, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 83;
            this.label5.Text = "Items to declare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(296, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 85;
            this.label2.Text = "Vehicle Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(296, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 15);
            this.label4.TabIndex = 87;
            this.label4.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(402, 49);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(155, 26);
            this.txtLastName.TabIndex = 88;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // purposeTableAdapter
            // 
            this.purposeTableAdapter.ClearBeforeFill = true;
            // 
            // gateInTableTableAdapter
            // 
            this.gateInTableTableAdapter.ClearBeforeFill = true;
            // 
            // cbreason
            // 
            this.cbreason.DataSource = this.purposeBindingSource;
            this.cbreason.DisplayMember = "Name";
            this.cbreason.FormattingEnabled = true;
            this.cbreason.Location = new System.Drawing.Point(410, 220);
            this.cbreason.Name = "cbreason";
            this.cbreason.Size = new System.Drawing.Size(121, 21);
            this.cbreason.TabIndex = 90;
            this.cbreason.ValueMember = "Id";
            // 
            // cbitems
            // 
            this.cbitems.DataSource = this.itemstoDeclareBindingSource;
            this.cbitems.DisplayMember = "Name";
            this.cbitems.FormattingEnabled = true;
            this.cbitems.Location = new System.Drawing.Point(415, 299);
            this.cbitems.Name = "cbitems";
            this.cbitems.Size = new System.Drawing.Size(121, 21);
            this.cbitems.TabIndex = 91;
            this.cbitems.ValueMember = "Id";
            // 
            // itemstoDeclareBindingSource
            // 
            this.itemstoDeclareBindingSource.DataMember = "ItemstoDeclare";
            this.itemstoDeclareBindingSource.DataSource = this.gateInDatabaseDataSet;
            // 
            // cbvehicle
            // 
            this.cbvehicle.DataSource = this.vehicletypesBindingSource;
            this.cbvehicle.DisplayMember = "Name";
            this.cbvehicle.FormattingEnabled = true;
            this.cbvehicle.Location = new System.Drawing.Point(410, 146);
            this.cbvehicle.Name = "cbvehicle";
            this.cbvehicle.Size = new System.Drawing.Size(121, 21);
            this.cbvehicle.TabIndex = 92;
            this.cbvehicle.ValueMember = "Id";
            // 
            // vehicletypesBindingSource
            // 
            this.vehicletypesBindingSource.DataMember = "Vehicletypes";
            this.vehicletypesBindingSource.DataSource = this.gateInDatabaseDataSet;
            // 
            // genderBindingSource
            // 
            this.genderBindingSource.DataMember = "Gender";
            this.genderBindingSource.DataSource = this.gateInDatabaseDataSet;
            // 
            // genderTableAdapter
            // 
            this.genderTableAdapter.ClearBeforeFill = true;
            // 
            // itemstoDeclareTableAdapter
            // 
            this.itemstoDeclareTableAdapter.ClearBeforeFill = true;
            // 
            // vehicletypesTableAdapter
            // 
            this.vehicletypesTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Emp ID";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(145, 15);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 94;
            // 
            // GateIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 382);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbvehicle);
            this.Controls.Add(this.cbitems);
            this.Controls.Add(this.cbreason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BTExit);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.BtSave);
            this.Controls.Add(this.LbEmpID);
            this.Controls.Add(this.txtLic);
            this.Controls.Add(this.LbName);
            this.Controls.Add(this.LbLicense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.LbEmployeeNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GateIn";
            this.Text = "GateIn";
            this.Load += new System.EventHandler(this.GateIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fKGateInTablePurposeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purposeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gateInDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemstoDeclareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicletypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbLicense;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLic;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label LbEmployeeNum;
        private System.Windows.Forms.Label LbEmpID;
        private System.Windows.Forms.Button BtSave;
        private System.Windows.Forms.Button BtCancel;
        private System.Windows.Forms.Button BTExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private GateInDatabaseDataSet gateInDatabaseDataSet;
        private System.Windows.Forms.BindingSource purposeBindingSource;
        private GateInDatabaseDataSetTableAdapters.PurposeTableAdapter purposeTableAdapter;
        private System.Windows.Forms.BindingSource fKGateInTablePurposeBindingSource;
        private GateInDatabaseDataSetTableAdapters.GateInTableTableAdapter gateInTableTableAdapter;
        private System.Windows.Forms.ComboBox cbreason;
        private System.Windows.Forms.ComboBox cbitems;
        private System.Windows.Forms.ComboBox cbvehicle;
        private System.Windows.Forms.BindingSource genderBindingSource;
        private GateInDatabaseDataSetTableAdapters.GenderTableAdapter genderTableAdapter;
        private System.Windows.Forms.BindingSource itemstoDeclareBindingSource;
        private GateInDatabaseDataSetTableAdapters.ItemstoDeclareTableAdapter itemstoDeclareTableAdapter;
        private System.Windows.Forms.BindingSource vehicletypesBindingSource;
        private GateInDatabaseDataSetTableAdapters.VehicletypesTableAdapter vehicletypesTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUser;
    }
}