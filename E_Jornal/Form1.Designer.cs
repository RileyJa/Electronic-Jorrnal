namespace E_Jornal
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CBSubject = new System.Windows.Forms.ComboBox();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eJournalDataSet = new E_Jornal.EJournalDataSet();
            this.CBgroup = new System.Windows.Forms.ComboBox();
            this.group1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CBProfessor = new System.Windows.Forms.ComboBox();
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.UPMark = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.CBStudent = new System.Windows.Forms.ComboBox();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDell = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.group_1TableAdapter = new E_Jornal.EJournalDataSetTableAdapters.Group_1TableAdapter();
            this.professorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professorsTableAdapter = new E_Jornal.EJournalDataSetTableAdapters.ProfessorsTableAdapter();
            this.subjectTableAdapter = new E_Jornal.EJournalDataSetTableAdapters.SubjectTableAdapter();
            this.fKLecturesSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturesTableAdapter = new E_Jornal.EJournalDataSetTableAdapters.LecturesTableAdapter();
            this.studentsTableAdapter = new E_Jornal.EJournalDataSetTableAdapters.StudentsTableAdapter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eJournalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.group1BindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UPMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLecturesSubjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gb);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1243, 299);
            this.panel1.TabIndex = 0;
            // 
            // gb
            // 
            this.gb.Controls.Add(this.checkBox2);
            this.gb.Controls.Add(this.checkBox1);
            this.gb.Controls.Add(this.CBSubject);
            this.gb.Controls.Add(this.CBgroup);
            this.gb.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb.Location = new System.Drawing.Point(0, 0);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(1069, 222);
            this.gb.TabIndex = 5;
            this.gb.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(224, 32);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(103, 26);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Subjects";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 26);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Groups";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CBSubject
            // 
            this.CBSubject.DataSource = this.subjectBindingSource;
            this.CBSubject.DisplayMember = "Modul_Name";
            this.CBSubject.Enabled = false;
            this.CBSubject.FormattingEnabled = true;
            this.CBSubject.Location = new System.Drawing.Point(224, 64);
            this.CBSubject.Name = "CBSubject";
            this.CBSubject.Size = new System.Drawing.Size(203, 30);
            this.CBSubject.TabIndex = 1;
            this.CBSubject.ValueMember = "id";
            this.CBSubject.SelectedIndexChanged += new System.EventHandler(this.CBSubject_SelectedIndexChanged);
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.eJournalDataSet;
            // 
            // eJournalDataSet
            // 
            this.eJournalDataSet.DataSetName = "EJournalDataSet";
            this.eJournalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CBgroup
            // 
            this.CBgroup.DataSource = this.group1BindingSource;
            this.CBgroup.DisplayMember = "Group_Name";
            this.CBgroup.Enabled = false;
            this.CBgroup.FormattingEnabled = true;
            this.CBgroup.Location = new System.Drawing.Point(6, 64);
            this.CBgroup.Name = "CBgroup";
            this.CBgroup.Size = new System.Drawing.Size(212, 30);
            this.CBgroup.TabIndex = 0;
            this.CBgroup.ValueMember = "id";
            this.CBgroup.SelectedIndexChanged += new System.EventHandler(this.CBgroup_SelectedIndexChanged);
            // 
            // group1BindingSource
            // 
            this.group1BindingSource.DataMember = "Group_1";
            this.group1BindingSource.DataSource = this.eJournalDataSet;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.Controls.Add(this.CBProfessor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.UPMark, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CBStudent, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDell, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 222);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1243, 77);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // CBProfessor
            // 
            this.CBProfessor.DataSource = this.subjectBindingSource1;
            this.CBProfessor.DisplayMember = "Modul_Name";
            this.CBProfessor.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBProfessor.FormattingEnabled = true;
            this.CBProfessor.Location = new System.Drawing.Point(3, 41);
            this.CBProfessor.Name = "CBProfessor";
            this.CBProfessor.Size = new System.Drawing.Size(142, 30);
            this.CBProfessor.TabIndex = 3;
            this.CBProfessor.ValueMember = "id";
            this.CBProfessor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // subjectBindingSource1
            // 
            this.subjectBindingSource1.DataMember = "Subject";
            this.subjectBindingSource1.DataSource = this.eJournalDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subject";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Location = new System.Drawing.Point(151, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(142, 38);
            this.label.TabIndex = 6;
            this.label.Text = "Mark";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UPMark
            // 
            this.UPMark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPMark.Location = new System.Drawing.Point(151, 41);
            this.UPMark.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.UPMark.Name = "UPMark";
            this.UPMark.Size = new System.Drawing.Size(142, 29);
            this.UPMark.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(299, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 38);
            this.label2.TabIndex = 7;
            this.label2.Text = "Дата";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBStudent
            // 
            this.CBStudent.DataSource = this.studentsBindingSource;
            this.CBStudent.DisplayMember = "FirstName";
            this.CBStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.CBStudent.FormattingEnabled = true;
            this.CBStudent.Location = new System.Drawing.Point(537, 41);
            this.CBStudent.Name = "CBStudent";
            this.CBStudent.Size = new System.Drawing.Size(259, 30);
            this.CBStudent.TabIndex = 9;
            this.CBStudent.ValueMember = "id";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.eJournalDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(537, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = "Student";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(1076, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 33);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDell
            // 
            this.btnDell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDell.Location = new System.Drawing.Point(897, 41);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(173, 33);
            this.btnDell.TabIndex = 12;
            this.btnDell.Text = "Delete";
            this.btnDell.UseVisualStyleBackColor = true;
            this.btnDell.Click += new System.EventHandler(this.btnDell_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(1076, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1156, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(0, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1243, 320);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1243, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column
            // 
            this.Column.HeaderText = "";
            this.Column.Name = "Column";
            // 
            // group_1TableAdapter
            // 
            this.group_1TableAdapter.ClearBeforeFill = true;
            // 
            // professorsBindingSource
            // 
            this.professorsBindingSource.DataMember = "Professors";
            this.professorsBindingSource.DataSource = this.eJournalDataSet;
            // 
            // professorsTableAdapter
            // 
            this.professorsTableAdapter.ClearBeforeFill = true;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // fKLecturesSubjectBindingSource
            // 
            this.fKLecturesSubjectBindingSource.DataMember = "FK_Lectures_Subject";
            this.fKLecturesSubjectBindingSource.DataSource = this.subjectBindingSource;
            // 
            // lecturesTableAdapter
            // 
            this.lecturesTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(299, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 29);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 619);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eJournalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.group1BindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UPMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKLecturesSubjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CBgroup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewButtonColumn Column;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox CBProfessor;
        private EJournalDataSet eJournalDataSet;
        private System.Windows.Forms.BindingSource group1BindingSource;
        private EJournalDataSetTableAdapters.Group_1TableAdapter group_1TableAdapter;
        private System.Windows.Forms.BindingSource professorsBindingSource;
        private EJournalDataSetTableAdapters.ProfessorsTableAdapter professorsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.NumericUpDown UPMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private EJournalDataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.ComboBox CBSubject;
        private System.Windows.Forms.BindingSource fKLecturesSubjectBindingSource;
        private EJournalDataSetTableAdapters.LecturesTableAdapter lecturesTableAdapter;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox CBStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private EJournalDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDell;
        private System.Windows.Forms.BindingSource subjectBindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

