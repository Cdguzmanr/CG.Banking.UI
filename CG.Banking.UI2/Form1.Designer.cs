namespace CG.Banking.UI2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDeposits = new System.Windows.Forms.DataGridView();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.dgvWithdrawals = new System.Windows.Forms.DataGridView();
            this.lblDeposits = new System.Windows.Forms.Label();
            this.lblWithdraws = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblSSN = new System.Windows.Forms.Label();
            this.lblBDate = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblTextID = new System.Windows.Forms.Label();
            this.lblTextAge = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.txtBDate = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWithdrawals)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeposits
            // 
            this.dgvDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeposits.Location = new System.Drawing.Point(12, 337);
            this.dgvDeposits.Name = "dgvDeposits";
            this.dgvDeposits.RowHeadersWidth = 51;
            this.dgvDeposits.RowTemplate.Height = 29;
            this.dgvDeposits.Size = new System.Drawing.Size(613, 188);
            this.dgvDeposits.TabIndex = 17;
            this.dgvDeposits.Paint += new System.Windows.Forms.PaintEventHandler(this.dgv_Paint);
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 20;
            this.lstCustomers.Location = new System.Drawing.Point(12, 12);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(288, 244);
            this.lstCustomers.TabIndex = 0;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // dgvWithdrawals
            // 
            this.dgvWithdrawals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWithdrawals.Location = new System.Drawing.Point(12, 592);
            this.dgvWithdrawals.Name = "dgvWithdrawals";
            this.dgvWithdrawals.RowHeadersWidth = 51;
            this.dgvWithdrawals.RowTemplate.Height = 29;
            this.dgvWithdrawals.Size = new System.Drawing.Size(613, 188);
            this.dgvWithdrawals.TabIndex = 19;
            this.dgvWithdrawals.Paint += new System.Windows.Forms.PaintEventHandler(this.dgv_Paint);
            // 
            // lblDeposits
            // 
            this.lblDeposits.AutoSize = true;
            this.lblDeposits.Location = new System.Drawing.Point(12, 305);
            this.lblDeposits.Name = "lblDeposits";
            this.lblDeposits.Size = new System.Drawing.Size(70, 20);
            this.lblDeposits.TabIndex = 16;
            this.lblDeposits.Text = "Deposits:";
            // 
            // lblWithdraws
            // 
            this.lblWithdraws.AutoSize = true;
            this.lblWithdraws.Location = new System.Drawing.Point(12, 560);
            this.lblWithdraws.Name = "lblWithdraws";
            this.lblWithdraws.Size = new System.Drawing.Size(94, 20);
            this.lblWithdraws.TabIndex = 18;
            this.lblWithdraws.Text = "Withdrawals:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(331, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 20);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(331, 45);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(91, 20);
            this.lblFName.TabIndex = 3;
            this.lblFName.Text = "Firsta Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(331, 78);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(82, 20);
            this.lblLName.TabIndex = 5;
            this.lblLName.Text = "Last Name:";
            // 
            // lblSSN
            // 
            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(331, 111);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(39, 20);
            this.lblSSN.TabIndex = 7;
            this.lblSSN.Text = "SSN:";
            // 
            // lblBDate
            // 
            this.lblBDate.AutoSize = true;
            this.lblBDate.Location = new System.Drawing.Point(331, 144);
            this.lblBDate.Name = "lblBDate";
            this.lblBDate.Size = new System.Drawing.Size(79, 20);
            this.lblBDate.TabIndex = 9;
            this.lblBDate.Text = "Birth Date:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(331, 177);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(39, 20);
            this.lblAge.TabIndex = 11;
            this.lblAge.Text = "Age:";
            // 
            // lblTextID
            // 
            this.lblTextID.AutoSize = true;
            this.lblTextID.Location = new System.Drawing.Point(437, 12);
            this.lblTextID.Name = "lblTextID";
            this.lblTextID.Size = new System.Drawing.Size(0, 20);
            this.lblTextID.TabIndex = 2;
            // 
            // lblTextAge
            // 
            this.lblTextAge.AutoSize = true;
            this.lblTextAge.Location = new System.Drawing.Point(437, 177);
            this.lblTextAge.Name = "lblTextAge";
            this.lblTextAge.Size = new System.Drawing.Size(0, 20);
            this.lblTextAge.TabIndex = 12;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(437, 42);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(125, 27);
            this.txtFName.TabIndex = 4;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(437, 71);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(125, 27);
            this.txtLName.TabIndex = 6;
            // 
            // txtSSN
            // 
            this.txtSSN.Location = new System.Drawing.Point(437, 104);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(125, 27);
            this.txtSSN.TabIndex = 8;
            // 
            // txtBDate
            // 
            this.txtBDate.Location = new System.Drawing.Point(437, 137);
            this.txtBDate.Name = "txtBDate";
            this.txtBDate.Size = new System.Drawing.Size(125, 27);
            this.txtBDate.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(331, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(431, 227);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(531, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 804);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 29);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save to XML";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(138, 804);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 29);
            this.btnLoad.TabIndex = 21;
            this.btnLoad.Text = "Load from XML";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 854);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBDate);
            this.Controls.Add(this.txtSSN);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblTextAge);
            this.Controls.Add(this.lblTextID);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblBDate);
            this.Controls.Add(this.lblSSN);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblWithdraws);
            this.Controls.Add(this.lblDeposits);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.dgvWithdrawals);
            this.Controls.Add(this.dgvDeposits);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeposits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWithdrawals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvDeposits;
        private ListBox lstCustomers;
        private DataGridView dgvWithdrawals;
        private Label lblDeposits;
        private Label lblWithdraws;
        private Label lblID;
        private Label lblFName;
        private Label lblLName;
        private Label lblSSN;
        private Label lblBDate;
        private Label lblAge;
        private Label lblTextID;
        private Label lblTextAge;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtSSN;
        private TextBox txtBDate;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSave;
        private Button btnLoad;
    }
}