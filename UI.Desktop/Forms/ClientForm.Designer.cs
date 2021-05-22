namespace UI.Desktop.Forms
{
    partial class ClientForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelJob = new System.Windows.Forms.Label();
            this.btnModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(659, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(735, 189);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 26);
            this.txtName.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(54, 47);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(772, 507);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(120, 32);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(735, 279);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(172, 26);
            this.txtAddress.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(735, 370);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(173, 26);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(843, 446);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(172, 26);
            this.txtJob.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(942, 370);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(173, 26);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(942, 279);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(172, 26);
            this.txtCity.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(942, 189);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(173, 26);
            this.txtLastName.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(791, 157);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(985, 157);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(86, 20);
            this.labelLastName.TabIndex = 12;
            this.labelLastName.Text = "Last Name";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(791, 239);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(68, 20);
            this.labelAddress.TabIndex = 13;
            this.labelAddress.Text = "Address";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(1011, 238);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(35, 20);
            this.labelCity.TabIndex = 14;
            this.labelCity.Text = "City";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(791, 328);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 15;
            this.labelEmail.Text = "Email";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(1001, 328);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 20);
            this.labelPhone.TabIndex = 16;
            this.labelPhone.Text = "Phone";
            // 
            // labelJob
            // 
            this.labelJob.AutoSize = true;
            this.labelJob.Location = new System.Drawing.Point(909, 423);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(35, 20);
            this.labelJob.TabIndex = 17;
            this.labelJob.Text = "Job";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(955, 507);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(91, 32);
            this.btnModify.TabIndex = 18;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 658);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.labelJob);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.Button btnModify;
    }
}