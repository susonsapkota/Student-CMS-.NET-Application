namespace CourseWork
{
    partial class StudentForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sortBtn = new System.Windows.Forms.Button();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.sortlbl = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridStudents = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.cbCourse = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.noDataLbl = new System.Windows.Forms.Label();
            this.startingDateLbl = new System.Windows.Forms.Label();
            this.generatebtn = new System.Windows.Forms.Button();
            this.reportDate = new System.Windows.Forms.DateTimePicker();
            this.reportTable = new System.Windows.Forms.DataGridView();
            this.Programs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).BeginInit();
            this.groupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStudent
            // 
            this.panelStudent.Location = new System.Drawing.Point(85, 52);
            this.panelStudent.Margin = new System.Windows.Forms.Padding(4);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(724, 487);
            this.panelStudent.TabIndex = 15;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1497, 781);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sortBtn);
            this.tabPage1.Controls.Add(this.sortBox);
            this.tabPage1.Controls.Add(this.sortlbl);
            this.tabPage1.Controls.Add(this.btnUpdate);
            this.tabPage1.Controls.Add(this.dataGridStudents);
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.btnSubmit);
            this.tabPage1.Controls.Add(this.groupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1489, 752);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Input Details ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sortBtn
            // 
            this.sortBtn.Location = new System.Drawing.Point(1318, 380);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(100, 28);
            this.sortBtn.TabIndex = 38;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // sortBox
            // 
            this.sortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Items.AddRange(new object[] {
            "First Name(Ascending)",
            "First Name(Descending)",
            "Registration Date(Ascending)",
            "Registration Date(Descending)"});
            this.sortBox.Location = new System.Drawing.Point(1071, 384);
            this.sortBox.Margin = new System.Windows.Forms.Padding(4);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(206, 24);
            this.sortBox.TabIndex = 37;
            // 
            // sortlbl
            // 
            this.sortlbl.AutoSize = true;
            this.sortlbl.Location = new System.Drawing.Point(977, 391);
            this.sortlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortlbl.Name = "sortlbl";
            this.sortlbl.Size = new System.Drawing.Size(58, 17);
            this.sortlbl.TabIndex = 36;
            this.sortlbl.Text = "Sort By ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1062, 306);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // dataGridStudents
            // 
            this.dataGridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dataGridStudents.Location = new System.Drawing.Point(56, 424);
            this.dataGridStudents.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridStudents.Name = "dataGridStudents";
            this.dataGridStudents.RowHeadersWidth = 51;
            this.dataGridStudents.Size = new System.Drawing.Size(1361, 297);
            this.dataGridStudents.TabIndex = 23;
            this.dataGridStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudents_CellContentClick_1);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 125;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 125;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(169, 306);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1161, 306);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 28);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.statusBox);
            this.groupBox.Controls.Add(this.idLbl);
            this.groupBox.Controls.Add(this.lblCourse);
            this.groupBox.Controls.Add(this.txtId);
            this.groupBox.Controls.Add(this.lblFirstName);
            this.groupBox.Controls.Add(this.lblAddress);
            this.groupBox.Controls.Add(this.txtLastName);
            this.groupBox.Controls.Add(this.lblContactNo);
            this.groupBox.Controls.Add(this.lblLastName);
            this.groupBox.Controls.Add(this.lblRegistration);
            this.groupBox.Controls.Add(this.txtAddress);
            this.groupBox.Controls.Add(this.lblStatus);
            this.groupBox.Controls.Add(this.txtContactNo);
            this.groupBox.Controls.Add(this.txtFirstName);
            this.groupBox.Controls.Add(this.dpDate);
            this.groupBox.Controls.Add(this.cbCourse);
            this.groupBox.Location = new System.Drawing.Point(72, 34);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1337, 252);
            this.groupBox.TabIndex = 34;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Input All Details";
            // 
            // statusBox
            // 
            this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusBox.Location = new System.Drawing.Point(1008, 46);
            this.statusBox.Margin = new System.Windows.Forms.Padding(4);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(206, 24);
            this.statusBox.TabIndex = 35;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(94, 53);
            this.idLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(21, 17);
            this.idLbl.TabIndex = 34;
            this.idLbl.Text = "ID";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(876, 185);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(109, 17);
            this.lblCourse.TabIndex = 33;
            this.lblCourse.Text = "Course Enrolled";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(220, 48);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(246, 22);
            this.txtId.TabIndex = 25;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(94, 104);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 16;
            this.lblFirstName.Text = "First Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(94, 152);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(60, 17);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Address";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(1008, 90);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(206, 22);
            this.txtLastName.TabIndex = 18;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(876, 138);
            this.lblContactNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(78, 17);
            this.lblContactNo.TabIndex = 32;
            this.lblContactNo.Text = "Contact No";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(876, 93);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(72, 17);
            this.lblLastName.TabIndex = 17;
            this.lblLastName.Text = "LastName";
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Location = new System.Drawing.Point(94, 195);
            this.lblRegistration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(118, 17);
            this.lblRegistration.TabIndex = 30;
            this.lblRegistration.Text = "Registration Date";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(220, 147);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(246, 22);
            this.txtAddress.TabIndex = 21;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(876, 49);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Text = "Status";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(1008, 135);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(206, 22);
            this.txtContactNo.TabIndex = 31;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(220, 99);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(246, 22);
            this.txtFirstName.TabIndex = 15;
            // 
            // dpDate
            // 
            this.dpDate.Location = new System.Drawing.Point(220, 190);
            this.dpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(246, 22);
            this.dpDate.TabIndex = 28;
            // 
            // cbCourse
            // 
            this.cbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCourse.FormattingEnabled = true;
            this.cbCourse.Items.AddRange(new object[] {
            "Computing",
            "Multimedia Technologies",
            "Networks and IT Security"});
            this.cbCourse.Location = new System.Drawing.Point(1008, 180);
            this.cbCourse.Margin = new System.Windows.Forms.Padding(4);
            this.cbCourse.Name = "cbCourse";
            this.cbCourse.Size = new System.Drawing.Size(206, 24);
            this.cbCourse.TabIndex = 20;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.noDataLbl);
            this.tabPage2.Controls.Add(this.startingDateLbl);
            this.tabPage2.Controls.Add(this.generatebtn);
            this.tabPage2.Controls.Add(this.reportDate);
            this.tabPage2.Controls.Add(this.reportTable);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1489, 752);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chart And Reports";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // noDataLbl
            // 
            this.noDataLbl.AutoSize = true;
            this.noDataLbl.Location = new System.Drawing.Point(142, 591);
            this.noDataLbl.Name = "noDataLbl";
            this.noDataLbl.Size = new System.Drawing.Size(0, 17);
            this.noDataLbl.TabIndex = 22;
            // 
            // startingDateLbl
            // 
            this.startingDateLbl.AutoSize = true;
            this.startingDateLbl.Location = new System.Drawing.Point(773, 159);
            this.startingDateLbl.Name = "startingDateLbl";
            this.startingDateLbl.Size = new System.Drawing.Size(373, 17);
            this.startingDateLbl.TabIndex = 21;
            this.startingDateLbl.Text = "Showing all data till now (Change date to see weekly data)";
            // 
            // generatebtn
            // 
            this.generatebtn.Location = new System.Drawing.Point(1099, 116);
            this.generatebtn.Name = "generatebtn";
            this.generatebtn.Size = new System.Drawing.Size(166, 40);
            this.generatebtn.TabIndex = 20;
            this.generatebtn.Text = "Generate";
            this.generatebtn.UseVisualStyleBackColor = true;
            this.generatebtn.Click += new System.EventHandler(this.generatebtn_Click);
            // 
            // reportDate
            // 
            this.reportDate.Location = new System.Drawing.Point(776, 123);
            this.reportDate.Name = "reportDate";
            this.reportDate.Size = new System.Drawing.Size(250, 22);
            this.reportDate.TabIndex = 19;
            // 
            // reportTable
            // 
            this.reportTable.AllowUserToAddRows = false;
            this.reportTable.AllowUserToDeleteRows = false;
            this.reportTable.AllowUserToResizeColumns = false;
            this.reportTable.AllowUserToResizeRows = false;
            this.reportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Programs,
            this.totalStudent});
            this.reportTable.Location = new System.Drawing.Point(776, 196);
            this.reportTable.Name = "reportTable";
            this.reportTable.RowHeadersWidth = 51;
            this.reportTable.RowTemplate.Height = 24;
            this.reportTable.Size = new System.Drawing.Size(571, 122);
            this.reportTable.TabIndex = 18;
            // 
            // Programs
            // 
            this.Programs.HeaderText = "Programs";
            this.Programs.MinimumWidth = 6;
            this.Programs.Name = "Programs";
            this.Programs.Width = 125;
            // 
            // totalStudent
            // 
            this.totalStudent.HeaderText = "Total Student";
            this.totalStudent.MinimumWidth = 6;
            this.totalStudent.Name = "totalStudent";
            this.totalStudent.Width = 125;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(69, 59);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(602, 549);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 797);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelStudent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentForm";
            this.Text = "Student Form 1.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudents)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridStudents;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cbCourse;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridView reportTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Programs;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalStudent;
        private System.Windows.Forms.Button generatebtn;
        private System.Windows.Forms.DateTimePicker reportDate;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.Label sortlbl;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Label startingDateLbl;
        private System.Windows.Forms.Label noDataLbl;
    }
}

