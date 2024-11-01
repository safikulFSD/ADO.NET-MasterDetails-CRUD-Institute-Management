namespace ADO_Project
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTechInstitute = new System.Windows.Forms.DataGridView();
            this.dgvtxtTeachInstId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtInstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbPosition = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImageClear = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImageBrowse = new System.Windows.Forms.Button();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.rbtCotractual = new System.Windows.Forms.RadioButton();
            this.rbtRegular = new System.Windows.Forms.RadioButton();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbPositon = new System.Windows.Forms.ComboBox();
            this.txtTechName = new System.Windows.Forms.TextBox();
            this.txtTechCode = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvTeacher = new System.Windows.Forms.DataGridView();
            this.btnReport = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechInstitute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 540);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvTechInstitute);
            this.tabPage1.Controls.Add(this.btnImageClear);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnImageBrowse);
            this.tabPage1.Controls.Add(this.pbxPhoto);
            this.tabPage1.Controls.Add(this.rbtCotractual);
            this.tabPage1.Controls.Add(this.rbtRegular);
            this.tabPage1.Controls.Add(this.cmbGender);
            this.tabPage1.Controls.Add(this.cmbPositon);
            this.tabPage1.Controls.Add(this.txtTechName);
            this.tabPage1.Controls.Add(this.txtTechCode);
            this.tabPage1.Controls.Add(this.dtpDOB);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Teacher Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTechInstitute
            // 
            this.dgvTechInstitute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTechInstitute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechInstitute.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtTeachInstId,
            this.dgvtxtInstName,
            this.dgvcmbPosition,
            this.dgvtxtYear});
            this.dgvTechInstitute.Location = new System.Drawing.Point(30, 338);
            this.dgvTechInstitute.Name = "dgvTechInstitute";
            this.dgvTechInstitute.Size = new System.Drawing.Size(701, 102);
            this.dgvTechInstitute.TabIndex = 9;
            // 
            // dgvtxtTeachInstId
            // 
            this.dgvtxtTeachInstId.DataPropertyName = "TechInstId";
            this.dgvtxtTeachInstId.HeaderText = "TeachInstId";
            this.dgvtxtTeachInstId.Name = "dgvtxtTeachInstId";
            this.dgvtxtTeachInstId.Visible = false;
            // 
            // dgvtxtInstName
            // 
            this.dgvtxtInstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtInstName.DataPropertyName = "InstName";
            this.dgvtxtInstName.HeaderText = "InstName";
            this.dgvtxtInstName.Name = "dgvtxtInstName";
            // 
            // dgvcmbPosition
            // 
            this.dgvcmbPosition.DataPropertyName = "PositionId";
            this.dgvcmbPosition.HeaderText = "Position";
            this.dgvcmbPosition.Name = "dgvcmbPosition";
            // 
            // dgvtxtYear
            // 
            this.dgvtxtYear.DataPropertyName = "ExpYear";
            this.dgvtxtYear.HeaderText = "Year";
            this.dgvtxtYear.Name = "dgvtxtYear";
            // 
            // btnImageClear
            // 
            this.btnImageClear.Location = new System.Drawing.Point(473, 287);
            this.btnImageClear.Name = "btnImageClear";
            this.btnImageClear.Size = new System.Drawing.Size(75, 23);
            this.btnImageClear.TabIndex = 8;
            this.btnImageClear.Text = "Clear";
            this.btnImageClear.UseVisualStyleBackColor = true;
            this.btnImageClear.Click += new System.EventHandler(this.btnImageClear_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(500, 458);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(363, 458);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(214, 458);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImageBrowse
            // 
            this.btnImageBrowse.Location = new System.Drawing.Point(368, 287);
            this.btnImageBrowse.Name = "btnImageBrowse";
            this.btnImageBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnImageBrowse.TabIndex = 8;
            this.btnImageBrowse.Text = "Browse";
            this.btnImageBrowse.UseVisualStyleBackColor = true;
            this.btnImageBrowse.Click += new System.EventHandler(this.btnImageBrowse_Click);
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Location = new System.Drawing.Point(354, 61);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(212, 207);
            this.pbxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPhoto.TabIndex = 7;
            this.pbxPhoto.TabStop = false;
            // 
            // rbtCotractual
            // 
            this.rbtCotractual.AutoSize = true;
            this.rbtCotractual.Location = new System.Drawing.Point(178, 231);
            this.rbtCotractual.Name = "rbtCotractual";
            this.rbtCotractual.Size = new System.Drawing.Size(73, 17);
            this.rbtCotractual.TabIndex = 6;
            this.rbtCotractual.TabStop = true;
            this.rbtCotractual.Text = "Cotractual";
            this.rbtCotractual.UseVisualStyleBackColor = true;
            // 
            // rbtRegular
            // 
            this.rbtRegular.AutoSize = true;
            this.rbtRegular.Location = new System.Drawing.Point(101, 229);
            this.rbtRegular.Name = "rbtRegular";
            this.rbtRegular.Size = new System.Drawing.Size(62, 17);
            this.rbtRegular.TabIndex = 6;
            this.rbtRegular.TabStop = true;
            this.rbtRegular.Text = "Regular";
            this.rbtRegular.UseVisualStyleBackColor = true;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmbGender.Location = new System.Drawing.Point(100, 200);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(127, 21);
            this.cmbGender.TabIndex = 5;
            // 
            // cmbPositon
            // 
            this.cmbPositon.FormattingEnabled = true;
            this.cmbPositon.Location = new System.Drawing.Point(100, 135);
            this.cmbPositon.Name = "cmbPositon";
            this.cmbPositon.Size = new System.Drawing.Size(127, 21);
            this.cmbPositon.TabIndex = 4;
            // 
            // txtTechName
            // 
            this.txtTechName.Location = new System.Drawing.Point(100, 106);
            this.txtTechName.Name = "txtTechName";
            this.txtTechName.Size = new System.Drawing.Size(128, 20);
            this.txtTechName.TabIndex = 3;
            // 
            // txtTechCode
            // 
            this.txtTechCode.Location = new System.Drawing.Point(101, 75);
            this.txtTechCode.Name = "txtTechCode";
            this.txtTechCode.Size = new System.Drawing.Size(127, 20);
            this.txtTechCode.TabIndex = 3;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd-MM-yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(101, 166);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(127, 20);
            this.dtpDOB.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tech. Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tech. Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Institute Management";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReport);
            this.tabPage2.Controls.Add(this.dgvTeacher);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teacher Resister";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvTeacher
            // 
            this.dgvTeacher.AllowUserToAddRows = false;
            this.dgvTeacher.AllowUserToDeleteRows = false;
            this.dgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacher.Location = new System.Drawing.Point(6, 6);
            this.dgvTeacher.Name = "dgvTeacher";
            this.dgvTeacher.ReadOnly = true;
            this.dgvTeacher.Size = new System.Drawing.Size(751, 461);
            this.dgvTeacher.TabIndex = 0;
            this.dgvTeacher.DoubleClick += new System.EventHandler(this.dgvTeacher_DoubleClick);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(519, 473);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(127, 35);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "View Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 554);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechInstitute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvTechInstitute;
        private System.Windows.Forms.Button btnImageClear;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImageBrowse;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.RadioButton rbtCotractual;
        private System.Windows.Forms.RadioButton rbtRegular;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbPositon;
        private System.Windows.Forms.TextBox txtTechName;
        private System.Windows.Forms.TextBox txtTechCode;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTeachInstId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtInstName;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtYear;
        private System.Windows.Forms.Button btnReport;
    }
}

