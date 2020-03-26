namespace ContactManager7798430
{
    partial class PersonalForm
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
            this.PersonalGrid = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSaveNew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSaveSelected = new System.Windows.Forms.Button();
            this.btnUpdateSelected = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbFname = new System.Windows.Forms.TextBox();
            this.txbLname = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.txbPtel = new System.Windows.Forms.TextBox();
            this.txbAddr2 = new System.Windows.Forms.TextBox();
            this.txbPostcode = new System.Windows.Forms.TextBox();
            this.txbAddr3 = new System.Windows.Forms.TextBox();
            this.txbAddr1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PersonalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonalGrid
            // 
            this.PersonalGrid.AllowUserToResizeColumns = false;
            this.PersonalGrid.AllowUserToResizeRows = false;
            this.PersonalGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.PersonalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PersonalGrid.Location = new System.Drawing.Point(12, 266);
            this.PersonalGrid.Margin = new System.Windows.Forms.Padding(4);
            this.PersonalGrid.MultiSelect = false;
            this.PersonalGrid.Name = "PersonalGrid";
            this.PersonalGrid.ReadOnly = true;
            this.PersonalGrid.RowHeadersWidth = 51;
            this.PersonalGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PersonalGrid.Size = new System.Drawing.Size(1139, 355);
            this.PersonalGrid.TabIndex = 0;
            this.PersonalGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PersonalGrid_CellClick);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(1001, 31);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(150, 31);
            this.btnAddNew.TabIndex = 1;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSaveNew
            // 
            this.btnSaveNew.Enabled = false;
            this.btnSaveNew.Location = new System.Drawing.Point(1001, 102);
            this.btnSaveNew.Name = "btnSaveNew";
            this.btnSaveNew.Size = new System.Drawing.Size(150, 31);
            this.btnSaveNew.TabIndex = 2;
            this.btnSaveNew.Text = "Save New";
            this.btnSaveNew.UseVisualStyleBackColor = true;
            this.btnSaveNew.Click += new System.EventHandler(this.btnSaveNew_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1001, 177);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 31);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSaveSelected
            // 
            this.btnSaveSelected.Enabled = false;
            this.btnSaveSelected.Location = new System.Drawing.Point(817, 102);
            this.btnSaveSelected.Name = "btnSaveSelected";
            this.btnSaveSelected.Size = new System.Drawing.Size(150, 31);
            this.btnSaveSelected.TabIndex = 4;
            this.btnSaveSelected.Text = "Save Selected";
            this.btnSaveSelected.UseVisualStyleBackColor = true;
            this.btnSaveSelected.Click += new System.EventHandler(this.btnSaveSelected_Click);
            // 
            // btnUpdateSelected
            // 
            this.btnUpdateSelected.Location = new System.Drawing.Point(817, 31);
            this.btnUpdateSelected.Name = "btnUpdateSelected";
            this.btnUpdateSelected.Size = new System.Drawing.Size(150, 31);
            this.btnUpdateSelected.TabIndex = 5;
            this.btnUpdateSelected.Text = "Update Selected";
            this.btnUpdateSelected.UseVisualStyleBackColor = true;
            this.btnUpdateSelected.Click += new System.EventHandler(this.btnUpdateSelected_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(817, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 31);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txbFname
            // 
            this.txbFname.Enabled = false;
            this.txbFname.Location = new System.Drawing.Point(100, 27);
            this.txbFname.Name = "txbFname";
            this.txbFname.Size = new System.Drawing.Size(100, 22);
            this.txbFname.TabIndex = 7;
            // 
            // txbLname
            // 
            this.txbLname.Enabled = false;
            this.txbLname.Location = new System.Drawing.Point(100, 81);
            this.txbLname.Name = "txbLname";
            this.txbLname.Size = new System.Drawing.Size(100, 22);
            this.txbLname.TabIndex = 8;
            // 
            // txbEmail
            // 
            this.txbEmail.Enabled = false;
            this.txbEmail.Location = new System.Drawing.Point(100, 141);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(100, 22);
            this.txbEmail.TabIndex = 9;
            // 
            // txbCity
            // 
            this.txbCity.Enabled = false;
            this.txbCity.Location = new System.Drawing.Point(311, 224);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(100, 22);
            this.txbCity.TabIndex = 10;
            // 
            // txbPtel
            // 
            this.txbPtel.Enabled = false;
            this.txbPtel.Location = new System.Drawing.Point(100, 195);
            this.txbPtel.Name = "txbPtel";
            this.txbPtel.Size = new System.Drawing.Size(100, 22);
            this.txbPtel.TabIndex = 11;
            // 
            // txbAddr2
            // 
            this.txbAddr2.Enabled = false;
            this.txbAddr2.Location = new System.Drawing.Point(311, 63);
            this.txbAddr2.Name = "txbAddr2";
            this.txbAddr2.Size = new System.Drawing.Size(100, 22);
            this.txbAddr2.TabIndex = 12;
            // 
            // txbPostcode
            // 
            this.txbPostcode.Enabled = false;
            this.txbPostcode.Location = new System.Drawing.Point(311, 169);
            this.txbPostcode.Name = "txbPostcode";
            this.txbPostcode.Size = new System.Drawing.Size(100, 22);
            this.txbPostcode.TabIndex = 13;
            // 
            // txbAddr3
            // 
            this.txbAddr3.Enabled = false;
            this.txbAddr3.Location = new System.Drawing.Point(311, 116);
            this.txbAddr3.Name = "txbAddr3";
            this.txbAddr3.Size = new System.Drawing.Size(100, 22);
            this.txbAddr3.TabIndex = 14;
            // 
            // txbAddr1
            // 
            this.txbAddr1.Enabled = false;
            this.txbAddr1.Location = new System.Drawing.Point(311, 10);
            this.txbAddr1.Name = "txbAddr1";
            this.txbAddr1.Size = new System.Drawing.Size(100, 22);
            this.txbAddr1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Personal Tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Addr 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Postcode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Addr 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Addr 3";
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 634);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbAddr1);
            this.Controls.Add(this.txbAddr3);
            this.Controls.Add(this.txbPostcode);
            this.Controls.Add(this.txbAddr2);
            this.Controls.Add(this.txbPtel);
            this.Controls.Add(this.txbCity);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbLname);
            this.Controls.Add(this.txbFname);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateSelected);
            this.Controls.Add(this.btnSaveSelected);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSaveNew);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.PersonalGrid);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonalForm";
            this.Text = "Personal Contact";
            this.Load += new System.EventHandler(this.PersonalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PersonalGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PersonalGrid;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSaveNew;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSaveSelected;
        private System.Windows.Forms.Button btnUpdateSelected;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txbFname;
        private System.Windows.Forms.TextBox txbLname;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.TextBox txbPtel;
        private System.Windows.Forms.TextBox txbAddr2;
        private System.Windows.Forms.TextBox txbPostcode;
        private System.Windows.Forms.TextBox txbAddr3;
        private System.Windows.Forms.TextBox txbAddr1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

