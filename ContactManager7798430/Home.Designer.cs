namespace ContactManager7798430
{
    partial class Home
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
            this.btnOpenPersonal = new System.Windows.Forms.Button();
            this.btnOpenBusinessContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenPersonal
            // 
            this.btnOpenPersonal.Location = new System.Drawing.Point(87, 146);
            this.btnOpenPersonal.Name = "btnOpenPersonal";
            this.btnOpenPersonal.Size = new System.Drawing.Size(214, 108);
            this.btnOpenPersonal.TabIndex = 0;
            this.btnOpenPersonal.Text = "Personal Contact";
            this.btnOpenPersonal.UseVisualStyleBackColor = true;
            this.btnOpenPersonal.Click += new System.EventHandler(this.btnOpenPersonal_Click);
            // 
            // btnOpenBusinessContact
            // 
            this.btnOpenBusinessContact.Location = new System.Drawing.Point(475, 146);
            this.btnOpenBusinessContact.Name = "btnOpenBusinessContact";
            this.btnOpenBusinessContact.Size = new System.Drawing.Size(214, 108);
            this.btnOpenBusinessContact.TabIndex = 1;
            this.btnOpenBusinessContact.Text = "Busines Contact";
            this.btnOpenBusinessContact.UseVisualStyleBackColor = true;
            this.btnOpenBusinessContact.Click += new System.EventHandler(this.btnOpenBusinessContact_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenBusinessContact);
            this.Controls.Add(this.btnOpenPersonal);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenPersonal;
        private System.Windows.Forms.Button btnOpenBusinessContact;
    }
}