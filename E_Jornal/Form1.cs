using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Jornal
{
    public partial class Form1 : Form
    {
        int Grope;
        int Subject;
        bool CBG = false;
        bool CBS = false;
        bool R = false;
        Lectures lectures = new Lectures();
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eJournalDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.eJournalDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eJournalDataSet.Lectures". При необходимости она может быть перемещена или удалена.
            this.lecturesTableAdapter.Fill(this.eJournalDataSet.Lectures);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eJournalDataSet.Subject". При необходимости она может быть перемещена или удалена.
            this.subjectTableAdapter.Fill(this.eJournalDataSet.Subject);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eJournalDataSet.Professors". При необходимости она может быть перемещена или удалена.
            this.professorsTableAdapter.Fill(this.eJournalDataSet.Professors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eJournalDataSet.Group_1". При необходимости она может быть перемещена или удалена.
            this.group_1TableAdapter.Fill(this.eJournalDataSet.Group_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eJournalDataSet.Students". При необходимости она может быть перемещена или удалена.
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eJournalDataSet.Group_1". При необходимости она может быть перемещена или удалена.
            this.group_1TableAdapter.Fill(this.eJournalDataSet.Group_1);
            //MessageBox.Show(CBgroup.SelectedValue.ToString());
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            
            LoadingDef();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[9].Visible = false;

            CBgroup.Enabled = CBG;
            CBSubject.Enabled = CBS;
            //Grope = (int)CBgroup.SelectedValue;
            //Subject = (int)CBSubject.SelectedValue;
        }

        private void Loading()
        {
            using (ZoraModel db = new ZoraModel())
            {
                var result = (from lectures in db.Lectures
                              join subject in db.Subject on lectures.Subject_Id equals subject.id
                              join professor in db.Professors on subject.Professor_Id equals professor.id
                              join students in db.Students on lectures.Studen_Id equals students.id
                              join gope in db.Group_1 on students.Group_Id equals gope.id
                              where students.Group_Id == Grope || lectures.Subject_Id == Subject

                              select new
                              {
                                  Id = lectures.id,
                                  SValue = subject.id,
                                  Data = lectures.Date,
                                  SubjectName = subject.Modul_Name,
                                  Professor = professor.FirstName,
                                  Student = students.FirstName,
                                  Group = gope.Group_Name,
                                  Mark = lectures.Mark,
                                  Student_Id = students.id
                              }).ToList();
                dataGridView1.DataSource = result;

                dataGridView1.Refresh();
            }


        }
        private void LoadingDef()
        {
            using (ZoraModel db = new ZoraModel())
            {
                var result = (from lectures in db.Lectures
                              join subject in db.Subject on lectures.Subject_Id equals subject.id
                              join professor in db.Professors on subject.Professor_Id equals professor.id
                              join students in db.Students on lectures.Studen_Id equals students.id
                              join gope in db.Group_1 on students.Group_Id equals gope.id
                              
                              select new
                              {
                                  Id = lectures.id,
                                  SValue = subject.id,
                                  Data = lectures.Date,
                                  SubjectName = subject.Modul_Name,
                                  Professor = professor.FirstName,
                                  Student = students.FirstName,
                                  Group = gope.Group_Name,
                                  Mark = lectures.Mark,
                                  Student_Id = students.id
                              }).ToList();
                dataGridView1.DataSource = result;
                dataGridView1.Refresh();
            }


        }



        private void button2_Click(object sender, EventArgs e)
        {
            Loading();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                lectures.id = (int)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                
                CBProfessor.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                UPMark.Value = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString());
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                CBStudent.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[9].Value;
            }
            catch (Exception)
            {
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBgroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Grope = (int)CBgroup.SelectedValue;
            }
            catch (Exception)
            {
            }
        }

        private void CBSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Subject = (int)CBSubject.SelectedValue;
            }
            catch (Exception)
            {
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CBG = !CBG;
            CBgroup.Enabled = CBG;
            if (!CBG)
            {
                Grope = default(int);
            }
            else
            {
                Grope = (int)CBgroup.SelectedValue;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CBS = !CBS;
            CBSubject.Enabled = CBS;
            if (!CBS)
            {
                Subject = default(int);
            }
            else
            {
                Subject = (int)CBSubject.SelectedValue;
            }
        }

        private void AddValue()
        {

            //try
            //{
            //    lectures.Date = Convert.ToDateTime(dateTimePicker1.Text);
            //    R = true;
            //}
            //catch (Exception)
            //{
            //    R = false;
            //    MessageBox.Show("Введите дату");
            //}
            lectures.Date = dateTimePicker1.Value;
            lectures.Mark = (int)UPMark.Value;
            lectures.Studen_Id = (int)CBStudent.SelectedValue;
            lectures.Subject_Id = (int)CBProfessor.SelectedValue;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                lectures = new Lectures();
                AddValue();
                using (ZoraModel db = new ZoraModel())
                {                   
                        db.Lectures.Add(lectures);
                        db.SaveChanges();
                        LoadingDef();
                        MessageBox.Show("Операция завершена успешно");
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Date error format");
            }
        }

        private void btnDell_Click(object sender, EventArgs e)
        {

            try
            {
                if (lectures.id >= 0)
                {
                    using (ZoraModel db = new ZoraModel())
                    {
                        lectures = db.Lectures.Find(lectures.id);

                        db.Lectures.Remove(lectures);
                        db.SaveChanges();
                        LoadingDef();
                        MessageBox.Show("Операция завершена успешно");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите объект из таблицы");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите объект из таблицы");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lectures.id >= 0)
            {
                using (ZoraModel db = new ZoraModel())
                {
                    lectures = db.Lectures.Find(lectures.id);
                    AddValue();
                    db.SaveChanges();
                    LoadingDef();
                    MessageBox.Show("Операция завершена успешно");
                }
            }
            else
            {
                MessageBox.Show("Выберите объект из таблицы");
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.subjectTableAdapter.FillBy(this.eJournalDataSet.Subject);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
