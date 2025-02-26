namespace sql
{
    partial class Form1
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
            this.dgwprotect = new System.Windows.Forms.DataGridView();
            this.lblname = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.lblnumber = new System.Windows.Forms.Label();
            this.gbxadd = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.tbxnumber = new System.Windows.Forms.TextBox();
            this.tbxsurname = new System.Windows.Forms.TextBox();
            this.tbxname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxPhoneNUmberupdate = new System.Windows.Forms.TextBox();
            this.tbxSurnameupdate = new System.Windows.Forms.TextBox();
            this.tbxnameupdate = new System.Windows.Forms.TextBox();
            this.lblnameupdate = new System.Windows.Forms.Label();
            this.lblPhoneNumberUpdate = new System.Windows.Forms.Label();
            this.lblSurnameUpdate = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxsearchphonenumber = new System.Windows.Forms.TextBox();
            this.tbxsearcsurname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbxsearchName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwprotect)).BeginInit();
            this.gbxadd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwprotect
            // 
            this.dgwprotect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwprotect.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwprotect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwprotect.Location = new System.Drawing.Point(45, 41);
            this.dgwprotect.Name = "dgwprotect";
            this.dgwprotect.RowHeadersWidth = 51;
            this.dgwprotect.RowTemplate.Height = 24;
            this.dgwprotect.Size = new System.Drawing.Size(960, 165);
            this.dgwprotect.TabIndex = 0;
            this.dgwprotect.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwprotect_CellClick);
            this.dgwprotect.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.SpringGreen;
            this.lblname.Location = new System.Drawing.Point(28, 24);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 16);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.BackColor = System.Drawing.Color.Lime;
            this.lblsurname.Location = new System.Drawing.Point(28, 65);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(61, 16);
            this.lblsurname.TabIndex = 2;
            this.lblsurname.Text = "Surname";
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.BackColor = System.Drawing.Color.Lime;
            this.lblnumber.Location = new System.Drawing.Point(28, 104);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(94, 16);
            this.lblnumber.TabIndex = 3;
            this.lblnumber.Text = "PhoneNumber";
            this.lblnumber.Click += new System.EventHandler(this.label3_Click);
            // 
            // gbxadd
            // 
            this.gbxadd.Controls.Add(this.btnadd);
            this.gbxadd.Controls.Add(this.tbxnumber);
            this.gbxadd.Controls.Add(this.tbxsurname);
            this.gbxadd.Controls.Add(this.tbxname);
            this.gbxadd.Controls.Add(this.lblname);
            this.gbxadd.Controls.Add(this.lblnumber);
            this.gbxadd.Controls.Add(this.lblsurname);
            this.gbxadd.Location = new System.Drawing.Point(57, 223);
            this.gbxadd.Name = "gbxadd";
            this.gbxadd.Size = new System.Drawing.Size(277, 172);
            this.gbxadd.TabIndex = 4;
            this.gbxadd.TabStop = false;
            this.gbxadd.Text = "Add a Person";
            this.gbxadd.Enter += new System.EventHandler(this.gbxadd_Enter);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(100, 143);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // tbxnumber
            // 
            this.tbxnumber.Location = new System.Drawing.Point(151, 98);
            this.tbxnumber.Name = "tbxnumber";
            this.tbxnumber.Size = new System.Drawing.Size(100, 22);
            this.tbxnumber.TabIndex = 6;
            // 
            // tbxsurname
            // 
            this.tbxsurname.Location = new System.Drawing.Point(151, 59);
            this.tbxsurname.Name = "tbxsurname";
            this.tbxsurname.Size = new System.Drawing.Size(100, 22);
            this.tbxsurname.TabIndex = 5;
            // 
            // tbxname
            // 
            this.tbxname.Location = new System.Drawing.Point(151, 21);
            this.tbxname.Name = "tbxname";
            this.tbxname.Size = new System.Drawing.Size(100, 22);
            this.tbxname.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbxPhoneNUmberupdate);
            this.groupBox1.Controls.Add(this.tbxSurnameupdate);
            this.groupBox1.Controls.Add(this.tbxnameupdate);
            this.groupBox1.Controls.Add(this.lblnameupdate);
            this.groupBox1.Controls.Add(this.lblPhoneNumberUpdate);
            this.groupBox1.Controls.Add(this.lblSurnameUpdate);
            this.groupBox1.Location = new System.Drawing.Point(340, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 183);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update a Person";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxPhoneNUmberupdate
            // 
            this.tbxPhoneNUmberupdate.Location = new System.Drawing.Point(151, 98);
            this.tbxPhoneNUmberupdate.Name = "tbxPhoneNUmberupdate";
            this.tbxPhoneNUmberupdate.Size = new System.Drawing.Size(100, 22);
            this.tbxPhoneNUmberupdate.TabIndex = 6;
            // 
            // tbxSurnameupdate
            // 
            this.tbxSurnameupdate.Location = new System.Drawing.Point(151, 59);
            this.tbxSurnameupdate.Name = "tbxSurnameupdate";
            this.tbxSurnameupdate.Size = new System.Drawing.Size(100, 22);
            this.tbxSurnameupdate.TabIndex = 5;
            // 
            // tbxnameupdate
            // 
            this.tbxnameupdate.Location = new System.Drawing.Point(151, 21);
            this.tbxnameupdate.Name = "tbxnameupdate";
            this.tbxnameupdate.Size = new System.Drawing.Size(100, 22);
            this.tbxnameupdate.TabIndex = 4;
            // 
            // lblnameupdate
            // 
            this.lblnameupdate.AutoSize = true;
            this.lblnameupdate.BackColor = System.Drawing.Color.Aqua;
            this.lblnameupdate.Location = new System.Drawing.Point(28, 24);
            this.lblnameupdate.Name = "lblnameupdate";
            this.lblnameupdate.Size = new System.Drawing.Size(44, 16);
            this.lblnameupdate.TabIndex = 1;
            this.lblnameupdate.Text = "Name";
            // 
            // lblPhoneNumberUpdate
            // 
            this.lblPhoneNumberUpdate.AutoSize = true;
            this.lblPhoneNumberUpdate.BackColor = System.Drawing.Color.Aqua;
            this.lblPhoneNumberUpdate.Location = new System.Drawing.Point(28, 104);
            this.lblPhoneNumberUpdate.Name = "lblPhoneNumberUpdate";
            this.lblPhoneNumberUpdate.Size = new System.Drawing.Size(94, 16);
            this.lblPhoneNumberUpdate.TabIndex = 3;
            this.lblPhoneNumberUpdate.Text = "PhoneNumber";
            this.lblPhoneNumberUpdate.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSurnameUpdate
            // 
            this.lblSurnameUpdate.AutoSize = true;
            this.lblSurnameUpdate.BackColor = System.Drawing.Color.Aqua;
            this.lblSurnameUpdate.Location = new System.Drawing.Point(28, 65);
            this.lblSurnameUpdate.Name = "lblSurnameUpdate";
            this.lblSurnameUpdate.Size = new System.Drawing.Size(61, 16);
            this.lblSurnameUpdate.TabIndex = 2;
            this.lblSurnameUpdate.Text = "Surname";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.Red;
            this.lblsearch.Location = new System.Drawing.Point(19, 24);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(44, 16);
            this.lblsearch.TabIndex = 7;
            this.lblsearch.Text = "Name";
            this.lblsearch.Click += new System.EventHandler(this.lblsearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Surname";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(19, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "PhoneNumber";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxsearchphonenumber
            // 
            this.tbxsearchphonenumber.Location = new System.Drawing.Point(134, 106);
            this.tbxsearchphonenumber.Name = "tbxsearchphonenumber";
            this.tbxsearchphonenumber.Size = new System.Drawing.Size(186, 22);
            this.tbxsearchphonenumber.TabIndex = 10;
            this.tbxsearchphonenumber.TextChanged += new System.EventHandler(this.tbxsearchphonenumber_TextChanged);
            // 
            // tbxsearcsurname
            // 
            this.tbxsearcsurname.Location = new System.Drawing.Point(134, 67);
            this.tbxsearcsurname.Name = "tbxsearcsurname";
            this.tbxsearcsurname.Size = new System.Drawing.Size(186, 22);
            this.tbxsearcsurname.TabIndex = 11;
            this.tbxsearcsurname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblsearch);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbxsearchphonenumber);
            this.groupBox2.Controls.Add(this.tbxsearcsurname);
            this.groupBox2.Controls.Add(this.tbxsearchName);
            this.groupBox2.Location = new System.Drawing.Point(623, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 183);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search a Person";
            // 
            // tbxsearchName
            // 
            this.tbxsearchName.Location = new System.Drawing.Point(134, 21);
            this.tbxsearchName.Name = "tbxsearchName";
            this.tbxsearchName.Size = new System.Drawing.Size(186, 22);
            this.tbxsearchName.TabIndex = 7;
            this.tbxsearchName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxadd);
            this.Controls.Add(this.dgwprotect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwprotect)).EndInit();
            this.gbxadd.ResumeLayout(false);
            this.gbxadd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwprotect;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.GroupBox gbxadd;
        private System.Windows.Forms.TextBox tbxnumber;
        private System.Windows.Forms.TextBox tbxsurname;
        private System.Windows.Forms.TextBox tbxname;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxPhoneNUmberupdate;
        private System.Windows.Forms.TextBox tbxSurnameupdate;
        private System.Windows.Forms.TextBox tbxnameupdate;
        private System.Windows.Forms.Label lblnameupdate;
        private System.Windows.Forms.Label lblPhoneNumberUpdate;
        private System.Windows.Forms.Label lblSurnameUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxsearchphonenumber;
        private System.Windows.Forms.TextBox tbxsearcsurname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxsearchName;
    }
}

