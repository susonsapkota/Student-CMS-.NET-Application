using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class StudentForm : Form
    {

        public StudentForm()
        {
            InitializeComponent();
            BindGrid();
            btnUpdate.Visible = false;
            reportTable.Columns[1].Width = 100;
            reportTable.Columns[0].Width = 275;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
        }
        private void BindGrid()
        {
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            DataTable dt = Utility.ConvertToDataTable(listStudents);
            dataGridStudents.DataSource = dt;
            BindChart(listStudents);
            BindReport();
        }
        private void BindReport()
        {
            reportTable.Rows.Clear();
            Student obj = new Student();
            List<Student> listStudents = obj.List();

            int computing = 0;
            int networking = 0;
            int multimedia = 0;


            foreach (Student stu in listStudents)
            {
                if (stu.CourseEnrolled == "Computing")
                {
                    computing += 1;
                }
                else if (stu.CourseEnrolled == "Multimedia Technologies")
                {

                    multimedia += 1;

                }
                else if (stu.CourseEnrolled == "Networks and IT Security")
                {
                    networking += 1;
                }
            }


            reportTable.Rows.Add(new Object[] { "Computing", computing });
            reportTable.Rows.Add(new Object[] { "Multimedia Technologies", multimedia });
            reportTable.Rows.Add(new Object[] { "Networks and IT Security", networking });

        }
        private void Clear()
        {
            txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtContactNo.Text = "";
            dpDate.Value = DateTime.Today;
            cbCourse.SelectedItem = null;
            statusBox.SelectedItem = null;

        }

        private void GridRow_DbClick(object sender, DataGridViewRowEventArgs e)
        {
            int id = 0;
            string myValue = dataGridStudents[e.Row.Index, 0].Value.ToString();

            //get the clicked id 
            //read text file 
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            Student s = listStudents.Where(x => x.Id == id).FirstOrDefault();
            //txtFirstName.Text = s.Name.Split(' ')[0];
            //txtLastName.Text = s.Name.Split(' ')[1];
        }

        private void BindChart(List<Student> lst)
        {
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => l.CourseEnrolled)
                    .Select(cl => new
                    {
                        CourseEnrolled = cl.First().CourseEnrolled,
                        Count = cl.Count().ToString()
                    }).ToList();
                DataTable dt = Utility.ConvertToDataTable(result);
                chart1.DataSource = dt;
                chart1.Name = "CourseEnrolled";
                chart1.Series["Series1"].XValueMember = "CourseEnrolled";
                chart1.Series["Series1"].YValueMembers = "Count";
                this.chart1.Titles.Remove(this.chart1.Titles.FirstOrDefault());
                this.chart1.Titles.Add("Weekly Enrollment Chart");
                chart1.Series["Series1"].IsValueShownAsLabel = false;
                chart1.Legends.Clear();
            }
        }


        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            // checking for empty fields
            if (String.IsNullOrEmpty(txtFirstName.Text) ||
               String.IsNullOrEmpty(txtLastName.Text) ||
               String.IsNullOrEmpty(txtId.Text) ||
               String.IsNullOrEmpty(statusBox.Text) ||
               String.IsNullOrEmpty(txtAddress.Text) ||
               String.IsNullOrEmpty(txtContactNo.Text) ||
               String.IsNullOrEmpty(dpDate.Value.ToString()) ||
               String.IsNullOrEmpty(cbCourse.Text)
               )
            {
                MessageBox.Show("Cannot leave any field empty!", "Student Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            Student obj = new Student();


            // checking the validity of the id
            int val = 0;

            if (Int32.TryParse(txtId.Text, out val))
            {
                obj.Id = Int32.Parse(txtId.Text);
            }
            else
            {
                MessageBox.Show("Id must be valid integer", "Student Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // hacky way of checking if id already already exixts

            foreach (Student stu in obj.List())
            {
                if (stu.Id == Int32.Parse(txtId.Text))
                {
                    MessageBox.Show("Id must be unique integer", "Student Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // if validation passes then information is added


            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            obj.Name = firstName + " " + lastName;
            obj.Address = txtAddress.Text;
            obj.ContactNo = txtContactNo.Text;
            obj.RegistrationDate = dpDate.Value;
            obj.CourseEnrolled = cbCourse.SelectedItem.ToString();
            obj.Status = statusBox.SelectedItem.ToString();
            obj.Add(obj);
            BindGrid();

            Clear();

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Student obj = new Student();
            obj.Id = int.Parse(txtId.Text);
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            obj.Name = firstName + " " + lastName;
            obj.Address = txtAddress.Text;
            obj.ContactNo = txtContactNo.Text;
            obj.RegistrationDate = dpDate.Value;
            obj.CourseEnrolled = cbCourse.SelectedItem.ToString();
            obj.Status = statusBox.SelectedItem.ToString();
            obj.Edit(obj);
            BindGrid();

            Clear();
            btnUpdate.Visible = false;
            btnSubmit.Visible = true;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Student obj = new Student();
            if (e.ColumnIndex == 0)
            {
                //get the value of the clicked rows id column
                string value = dataGridStudents[2, e.RowIndex].Value.ToString();
                int id = 0;
                if (String.IsNullOrEmpty(value))
                {
                    MessageBox.Show("Invalid Data");
                }
                else
                {
                    id = int.Parse(value);
                    Student s = obj.List().Where(x => x.Id == id).FirstOrDefault();
                    txtId.Text = s.Id.ToString();
                    txtFirstName.Text = s.Name.Split(' ')[0];
                    txtLastName.Text = s.Name.Split(' ')[1];
                    txtAddress.Text = s.Address;
                    txtContactNo.Text = s.ContactNo;
                    dpDate.Value = s.RegistrationDate;
                    cbCourse.SelectedItem = s.CourseEnrolled;
                    statusBox.SelectedItem = s.Status;
                    btnSubmit.Visible = false;
                    btnUpdate.Visible = true;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                string message = "Do you want to Delete this Record?";
                string title = "Delete Confirmation";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.OK)
                {
                    //get the value of the clicked rows id column
                    string value = dataGridStudents[2, e.RowIndex].Value.ToString();
                    obj.Delete(int.Parse(value));
                    BindGrid();
                    MessageBox.Show("Record Successfully Deleted");
                }
            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            if (sortBox.SelectedItem == null)
            {
                MessageBox.Show("Empty Sort parameters!. Please select valid item from dropdown", "Student Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String selected = sortBox.SelectedItem.ToString();
            Student student = new Student();
            List<Student> studentList = student.List();
            List<Student> list;

            /*  Available Dropdowns:
             *  First Name(Ascending
             *  First Name(Descending
             *  Registration Date(Ascending
             *  Registration Date(Descending)
            */


            if (selected.Equals("First Name(Ascending)"))
            { 
                list = sort(studentList, "NameA");
            }
            else if (selected.Equals("First Name(Descending)"))
            { 
                list = sort(studentList, "NameD");
            }
            else if (selected.Equals("Registration Date(Ascending)"))
            {
                list = sort(studentList, "DateA");
            }
            else if (selected.Equals("Registration Date(Descending)"))
            {
                list = sort(studentList, "DateD");
            }
            else
            {
                MessageBox.Show("Invalid Sort parameters!. Please select valid item from dropdown", "Student Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dt = Utility.ConvertToDataTable(list);
            dataGridStudents.DataSource = dt;
            BindChart(list);

        }

        public List<Student> sort(List<Student> studentList, string sortBy)
        {

            if (studentList != null)
            {
                for (int i = 0; i < studentList.Count - 1; i++)
                {
                    for (int j = i + 1; j < studentList.Count; j++)
                    {
                        // date ascending
                        if (sortBy.Equals("DateA"))
                        {
                            if (studentList[i].RegistrationDate.CompareTo(studentList[j].RegistrationDate) > 0)
                            {

                                Student tempStudent = studentList[i];
                                studentList[i] = studentList[j];
                                studentList[j] = tempStudent;
                            }
                        }
                        // date descending 
                        else if (sortBy.Equals("DateD"))
                        {
                            if (studentList[i].RegistrationDate.CompareTo(studentList[j].RegistrationDate) < 0)
                            {

                                Student tempStudent = studentList[i];
                                studentList[i] = studentList[j];
                                studentList[j] = tempStudent;
                            }
                        }
                        // name ascending
                        else if (sortBy.Equals("NameA"))
                        {
                            if (studentList[i].Name.CompareTo(studentList[j].Name) > 0)
                            {

                                Student tempStudent = studentList[i];
                                studentList[i] = studentList[j];
                                studentList[j] = tempStudent;
                            }
                        }
                        // name descending
                        else if (sortBy.Equals("NameD"))
                        {
                            if (studentList[i].Name.CompareTo(studentList[j].Name) < 0)
                            {

                                Student tempStudent = studentList[i];
                                studentList[i] = studentList[j];
                                studentList[j] = tempStudent;
                            }
                        }
                    }
                }
                return studentList;
            }
            return null;
        }
        private void generatebtn_Click(object sender, EventArgs e)
        {


            DateTime selected = reportDate.Value;
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var diff = selected.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
            if (diff < 0)
                diff += 7;
            var first_day_week = selected.AddDays(-diff).Date;
            startingDateLbl.Text = "Weekly Data shown starting with first day of week:" + first_day_week.ToString("dd/MM/yyyy");
            var last_day_week = selected.AddDays(7);
            reportTable.Rows.Clear();
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            var convertStudents = listStudents.Where(s => s.RegistrationDate >= first_day_week && s.RegistrationDate < last_day_week);

            BindChart(convertStudents.ToList());

            int computing = 0;
            int networking = 0;
            int multimedia = 0;


            foreach (Student stu in convertStudents)
            {
                if (stu.CourseEnrolled == "Computing")
                {
                    computing += 1;
                }
                else if (stu.CourseEnrolled == "Multimedia Technologies")
                {

                    multimedia += 1;

                }
                else if (stu.CourseEnrolled == "Networks and IT Security")
                {
                    networking += 1;
                }
            }


            reportTable.Rows.Add(new Object[] { "Computing", computing });
            reportTable.Rows.Add(new Object[] { "Multimedia Technologies", multimedia });
            reportTable.Rows.Add(new Object[] { "Networks and IT Security", networking });

            if (computing == 0 && networking == 0 && multimedia == 0)
            {
                noDataLbl.Text = "No data available to plot chart. Change the date and try again.";
            }



        }
    }
}
