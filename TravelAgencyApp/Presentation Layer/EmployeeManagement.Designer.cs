
namespace TravelAgencyApp.Presentation_Layer
{
    partial class EmployeeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagement));
            this.empdelectgroupBox = new System.Windows.Forms.GroupBox();
            this.deleteempbutton = new System.Windows.Forms.Button();
            this.deleteemptextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.empsearchgroupBox = new System.Windows.Forms.GroupBox();
            this.searchempbutton = new System.Windows.Forms.Button();
            this.searchemptextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backempbutton = new System.Windows.Forms.Button();
            this.empdatabasegroupBox = new System.Windows.Forms.GroupBox();
            this.employeedataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gendertextBox = new System.Windows.Forms.TextBox();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.addresstextBox = new System.Windows.Forms.TextBox();
            this.addresslabel = new System.Windows.Forms.Label();
            this.phoneNumbertextBox = new System.Windows.Forms.TextBox();
            this.bloodGroupcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salarylabel = new System.Windows.Forms.Label();
            this.hiredatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salarytextBox = new System.Windows.Forms.TextBox();
            this.dateOfBirthdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.designationlabel = new System.Windows.Forms.Label();
            this.designationcomboBox = new System.Windows.Forms.ComboBox();
            this.Updateempbutton = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.userNametextBox = new System.Windows.Forms.TextBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.refreshbutton = new System.Windows.Forms.Button();
            this.empdelectgroupBox.SuspendLayout();
            this.empsearchgroupBox.SuspendLayout();
            this.empdatabasegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeedataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // empdelectgroupBox
            // 
            this.empdelectgroupBox.Controls.Add(this.deleteempbutton);
            this.empdelectgroupBox.Controls.Add(this.deleteemptextBox);
            this.empdelectgroupBox.Controls.Add(this.label3);
            this.empdelectgroupBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empdelectgroupBox.Location = new System.Drawing.Point(20, 164);
            this.empdelectgroupBox.Name = "empdelectgroupBox";
            this.empdelectgroupBox.Size = new System.Drawing.Size(273, 119);
            this.empdelectgroupBox.TabIndex = 54;
            this.empdelectgroupBox.TabStop = false;
            this.empdelectgroupBox.Text = "Delete Employee";
            // 
            // deleteempbutton
            // 
            this.deleteempbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteempbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteempbutton.ForeColor = System.Drawing.Color.White;
            this.deleteempbutton.Location = new System.Drawing.Point(19, 65);
            this.deleteempbutton.Name = "deleteempbutton";
            this.deleteempbutton.Size = new System.Drawing.Size(235, 34);
            this.deleteempbutton.TabIndex = 51;
            this.deleteempbutton.Text = "Delete";
            this.deleteempbutton.UseVisualStyleBackColor = false;
            this.deleteempbutton.Click += new System.EventHandler(this.deleteempbutton_Click);
            // 
            // deleteemptextBox
            // 
            this.deleteemptextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteemptextBox.Location = new System.Drawing.Point(109, 28);
            this.deleteemptextBox.Name = "deleteemptextBox";
            this.deleteemptextBox.Size = new System.Drawing.Size(145, 22);
            this.deleteemptextBox.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Employee ID";
            // 
            // empsearchgroupBox
            // 
            this.empsearchgroupBox.Controls.Add(this.searchempbutton);
            this.empsearchgroupBox.Controls.Add(this.searchemptextBox);
            this.empsearchgroupBox.Controls.Add(this.label1);
            this.empsearchgroupBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empsearchgroupBox.Location = new System.Drawing.Point(19, 24);
            this.empsearchgroupBox.Name = "empsearchgroupBox";
            this.empsearchgroupBox.Size = new System.Drawing.Size(273, 119);
            this.empsearchgroupBox.TabIndex = 53;
            this.empsearchgroupBox.TabStop = false;
            this.empsearchgroupBox.Text = "Serach Employee";
            // 
            // searchempbutton
            // 
            this.searchempbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.searchempbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchempbutton.ForeColor = System.Drawing.Color.White;
            this.searchempbutton.Location = new System.Drawing.Point(19, 65);
            this.searchempbutton.Name = "searchempbutton";
            this.searchempbutton.Size = new System.Drawing.Size(235, 34);
            this.searchempbutton.TabIndex = 51;
            this.searchempbutton.Text = "Search";
            this.searchempbutton.UseVisualStyleBackColor = false;
            this.searchempbutton.Click += new System.EventHandler(this.searchempbutton_Click);
            // 
            // searchemptextBox
            // 
            this.searchemptextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchemptextBox.Location = new System.Drawing.Point(109, 28);
            this.searchemptextBox.Name = "searchemptextBox";
            this.searchemptextBox.Size = new System.Drawing.Size(145, 22);
            this.searchemptextBox.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 49;
            this.label1.Text = "Employee ID";
            // 
            // backempbutton
            // 
            this.backempbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.backempbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backempbutton.ForeColor = System.Drawing.Color.White;
            this.backempbutton.Location = new System.Drawing.Point(35, 583);
            this.backempbutton.Name = "backempbutton";
            this.backempbutton.Size = new System.Drawing.Size(87, 34);
            this.backempbutton.TabIndex = 55;
            this.backempbutton.Text = "Back";
            this.backempbutton.UseVisualStyleBackColor = false;
            this.backempbutton.Click += new System.EventHandler(this.backempbutton_Click);
            // 
            // empdatabasegroupBox
            // 
            this.empdatabasegroupBox.Controls.Add(this.employeedataGridView);
            this.empdatabasegroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empdatabasegroupBox.Location = new System.Drawing.Point(306, 12);
            this.empdatabasegroupBox.Name = "empdatabasegroupBox";
            this.empdatabasegroupBox.Size = new System.Drawing.Size(509, 611);
            this.empdatabasegroupBox.TabIndex = 83;
            this.empdatabasegroupBox.TabStop = false;
            this.empdatabasegroupBox.Text = "Employee Database";
            // 
            // employeedataGridView
            // 
            this.employeedataGridView.AllowUserToAddRows = false;
            this.employeedataGridView.AllowUserToDeleteRows = false;
            this.employeedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeedataGridView.Location = new System.Drawing.Point(6, 28);
            this.employeedataGridView.Name = "employeedataGridView";
            this.employeedataGridView.ReadOnly = true;
            this.employeedataGridView.Size = new System.Drawing.Size(497, 577);
            this.employeedataGridView.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gendertextBox);
            this.groupBox3.Controls.Add(this.idtextBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.addresstextBox);
            this.groupBox3.Controls.Add(this.addresslabel);
            this.groupBox3.Controls.Add(this.phoneNumbertextBox);
            this.groupBox3.Controls.Add(this.bloodGroupcomboBox);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.salarylabel);
            this.groupBox3.Controls.Add(this.hiredatedateTimePicker);
            this.groupBox3.Controls.Add(this.salarytextBox);
            this.groupBox3.Controls.Add(this.dateOfBirthdateTimePicker);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.designationlabel);
            this.groupBox3.Controls.Add(this.designationcomboBox);
            this.groupBox3.Controls.Add(this.Updateempbutton);
            this.groupBox3.Controls.Add(this.namelabel);
            this.groupBox3.Controls.Add(this.passwordtextBox);
            this.groupBox3.Controls.Add(this.nametextBox);
            this.groupBox3.Controls.Add(this.emailtextBox);
            this.groupBox3.Controls.Add(this.userNametextBox);
            this.groupBox3.Controls.Add(this.usernamelabel);
            this.groupBox3.Controls.Add(this.emaillabel);
            this.groupBox3.Controls.Add(this.passwordlabel);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(830, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 599);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update Employee";
            // 
            // gendertextBox
            // 
            this.gendertextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gendertextBox.Location = new System.Drawing.Point(118, 377);
            this.gendertextBox.Name = "gendertextBox";
            this.gendertextBox.Size = new System.Drawing.Size(131, 22);
            this.gendertextBox.TabIndex = 72;
            // 
            // idtextBox
            // 
            this.idtextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtextBox.Location = new System.Drawing.Point(121, 31);
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(128, 22);
            this.idtextBox.TabIndex = 71;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 70;
            this.label8.Text = "Employee ID";
            // 
            // addresstextBox
            // 
            this.addresstextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstextBox.Location = new System.Drawing.Point(121, 224);
            this.addresstextBox.Name = "addresstextBox";
            this.addresstextBox.Size = new System.Drawing.Size(128, 22);
            this.addresstextBox.TabIndex = 60;
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslabel.Location = new System.Drawing.Point(14, 224);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(60, 19);
            this.addresslabel.TabIndex = 59;
            this.addresslabel.Text = "Address";
            // 
            // phoneNumbertextBox
            // 
            this.phoneNumbertextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumbertextBox.Location = new System.Drawing.Point(121, 262);
            this.phoneNumbertextBox.Name = "phoneNumbertextBox";
            this.phoneNumbertextBox.Size = new System.Drawing.Size(128, 22);
            this.phoneNumbertextBox.TabIndex = 69;
            // 
            // bloodGroupcomboBox
            // 
            this.bloodGroupcomboBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloodGroupcomboBox.FormattingEnabled = true;
            this.bloodGroupcomboBox.Items.AddRange(new object[] {
            "AB+",
            "AB-",
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-"});
            this.bloodGroupcomboBox.Location = new System.Drawing.Point(121, 304);
            this.bloodGroupcomboBox.Name = "bloodGroupcomboBox";
            this.bloodGroupcomboBox.Size = new System.Drawing.Size(128, 23);
            this.bloodGroupcomboBox.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 58;
            this.label2.Text = "Hire Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 68;
            this.label4.Text = "Phone Number";
            // 
            // salarylabel
            // 
            this.salarylabel.AutoSize = true;
            this.salarylabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarylabel.Location = new System.Drawing.Point(14, 450);
            this.salarylabel.Name = "salarylabel";
            this.salarylabel.Size = new System.Drawing.Size(47, 19);
            this.salarylabel.TabIndex = 55;
            this.salarylabel.Text = "Salary";
            // 
            // hiredatedateTimePicker
            // 
            this.hiredatedateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiredatedateTimePicker.Location = new System.Drawing.Point(118, 487);
            this.hiredatedateTimePicker.Name = "hiredatedateTimePicker";
            this.hiredatedateTimePicker.Size = new System.Drawing.Size(131, 22);
            this.hiredatedateTimePicker.TabIndex = 57;
            // 
            // salarytextBox
            // 
            this.salarytextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarytextBox.Location = new System.Drawing.Point(118, 450);
            this.salarytextBox.Name = "salarytextBox";
            this.salarytextBox.Size = new System.Drawing.Size(131, 22);
            this.salarytextBox.TabIndex = 56;
            // 
            // dateOfBirthdateTimePicker
            // 
            this.dateOfBirthdateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthdateTimePicker.Location = new System.Drawing.Point(118, 344);
            this.dateOfBirthdateTimePicker.Name = "dateOfBirthdateTimePicker";
            this.dateOfBirthdateTimePicker.Size = new System.Drawing.Size(131, 22);
            this.dateOfBirthdateTimePicker.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 65;
            this.label5.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 61;
            this.label6.Text = "Blood Group";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 63;
            this.label7.Text = "Date of Birth";
            // 
            // designationlabel
            // 
            this.designationlabel.AutoSize = true;
            this.designationlabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designationlabel.Location = new System.Drawing.Point(14, 412);
            this.designationlabel.Name = "designationlabel";
            this.designationlabel.Size = new System.Drawing.Size(79, 19);
            this.designationlabel.TabIndex = 53;
            this.designationlabel.Text = "Designation";
            // 
            // designationcomboBox
            // 
            this.designationcomboBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designationcomboBox.FormattingEnabled = true;
            this.designationcomboBox.Items.AddRange(new object[] {
            "Manager",
            "Human Resources",
            "Sales Executive",
            "Clerk"});
            this.designationcomboBox.Location = new System.Drawing.Point(118, 412);
            this.designationcomboBox.Name = "designationcomboBox";
            this.designationcomboBox.Size = new System.Drawing.Size(131, 23);
            this.designationcomboBox.TabIndex = 54;
            // 
            // Updateempbutton
            // 
            this.Updateempbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Updateempbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updateempbutton.ForeColor = System.Drawing.Color.White;
            this.Updateempbutton.Location = new System.Drawing.Point(14, 559);
            this.Updateempbutton.Name = "Updateempbutton";
            this.Updateempbutton.Size = new System.Drawing.Size(235, 34);
            this.Updateempbutton.TabIndex = 52;
            this.Updateempbutton.Text = "Update";
            this.Updateempbutton.UseVisualStyleBackColor = false;
            this.Updateempbutton.Click += new System.EventHandler(this.Updateempbutton_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(14, 68);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(46, 19);
            this.namelabel.TabIndex = 36;
            this.namelabel.Text = "Name";
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox.Location = new System.Drawing.Point(121, 184);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(128, 22);
            this.passwordtextBox.TabIndex = 43;
            // 
            // nametextBox
            // 
            this.nametextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametextBox.Location = new System.Drawing.Point(121, 68);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(128, 22);
            this.nametextBox.TabIndex = 37;
            // 
            // emailtextBox
            // 
            this.emailtextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtextBox.Location = new System.Drawing.Point(121, 145);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(128, 22);
            this.emailtextBox.TabIndex = 41;
            // 
            // userNametextBox
            // 
            this.userNametextBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNametextBox.Location = new System.Drawing.Point(121, 106);
            this.userNametextBox.Name = "userNametextBox";
            this.userNametextBox.Size = new System.Drawing.Size(128, 22);
            this.userNametextBox.TabIndex = 39;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.Location = new System.Drawing.Point(14, 106);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(70, 19);
            this.usernamelabel.TabIndex = 38;
            this.usernamelabel.Text = "Username";
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.Location = new System.Drawing.Point(14, 145);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(42, 19);
            this.emaillabel.TabIndex = 40;
            this.emaillabel.Text = "Email";
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(14, 184);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(69, 19);
            this.passwordlabel.TabIndex = 42;
            this.passwordlabel.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TravelAgencyApp.Properties.Resources.management;
            this.pictureBox1.Location = new System.Drawing.Point(19, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // refreshbutton
            // 
            this.refreshbutton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.refreshbutton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbutton.ForeColor = System.Drawing.Color.White;
            this.refreshbutton.Location = new System.Drawing.Point(175, 583);
            this.refreshbutton.Name = "refreshbutton";
            this.refreshbutton.Size = new System.Drawing.Size(87, 34);
            this.refreshbutton.TabIndex = 84;
            this.refreshbutton.Text = "Refresh";
            this.refreshbutton.UseVisualStyleBackColor = false;
            this.refreshbutton.Click += new System.EventHandler(this.refreshbutton_Click);
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 638);
            this.Controls.Add(this.refreshbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.empdatabasegroupBox);
            this.Controls.Add(this.backempbutton);
            this.Controls.Add(this.empdelectgroupBox);
            this.Controls.Add(this.empsearchgroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeManagement";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmployeeManagement_FormClosing);
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            this.empdelectgroupBox.ResumeLayout(false);
            this.empdelectgroupBox.PerformLayout();
            this.empsearchgroupBox.ResumeLayout(false);
            this.empsearchgroupBox.PerformLayout();
            this.empdatabasegroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeedataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox empdelectgroupBox;
        private System.Windows.Forms.Button deleteempbutton;
        private System.Windows.Forms.TextBox deleteemptextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox empsearchgroupBox;
        private System.Windows.Forms.Button searchempbutton;
        private System.Windows.Forms.TextBox searchemptextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backempbutton;
        private System.Windows.Forms.GroupBox empdatabasegroupBox;
        private System.Windows.Forms.DataGridView employeedataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Updateempbutton;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox userNametextBox;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox addresstextBox;
        private System.Windows.Forms.Label addresslabel;
        private System.Windows.Forms.TextBox phoneNumbertextBox;
        private System.Windows.Forms.ComboBox bloodGroupcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label salarylabel;
        private System.Windows.Forms.DateTimePicker hiredatedateTimePicker;
        private System.Windows.Forms.TextBox salarytextBox;
        private System.Windows.Forms.DateTimePicker dateOfBirthdateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label designationlabel;
        private System.Windows.Forms.ComboBox designationcomboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button refreshbutton;
        private System.Windows.Forms.TextBox gendertextBox;
    }
}