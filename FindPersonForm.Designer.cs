namespace Pk_Uppgift
{
    partial class FindPersonForm
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.Color.White, null);
            this.listView1 = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.work = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.institution = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.tabPageAddPerson = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.ComboBoxRoom = new System.Windows.Forms.ComboBox();
            this.ComboBoxInst = new System.Windows.Forms.ComboBox();
            this.TxtBoxEmail = new System.Windows.Forms.TextBox();
            this.TxtBoxPhone = new System.Windows.Forms.TextBox();
            this.TxtBoxTask = new System.Windows.Forms.TextBox();
            this.TxtBoxName = new System.Windows.Forms.TextBox();
            this.labelsearch = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageAddPerson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.work,
            this.institution});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewItem2.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(181, 279);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(991, 439);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SortName);
            this.listView1.DoubleClick += new System.EventHandler(this.ShowPerson);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 161;
            // 
            // work
            // 
            this.work.Text = "TaskDescription";
            this.work.Width = 311;
            // 
            // institution
            // 
            this.institution.Text = "Institution";
            this.institution.Width = 256;
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Location = new System.Drawing.Point(181, 231);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(183, 26);
            this.searchTxtBox.TabIndex = 1;
            this.searchTxtBox.TextChanged += new System.EventHandler(this.Search);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPageAddPerson);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1284, 923);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelsearch);
            this.tabPage1.Controls.Add(this.BtnRemove);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.searchTxtBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1276, 890);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Findperson";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.Red;
            this.BtnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.BtnRemove.ForeColor = System.Drawing.Color.Snow;
            this.BtnRemove.Location = new System.Drawing.Point(1056, 798);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(151, 54);
            this.BtnRemove.TabIndex = 2;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // tabPageAddPerson
            // 
            this.tabPageAddPerson.Controls.Add(this.label10);
            this.tabPageAddPerson.Controls.Add(this.label9);
            this.tabPageAddPerson.Controls.Add(this.label7);
            this.tabPageAddPerson.Controls.Add(this.label2);
            this.tabPageAddPerson.Controls.Add(this.label6);
            this.tabPageAddPerson.Controls.Add(this.label5);
            this.tabPageAddPerson.Controls.Add(this.label4);
            this.tabPageAddPerson.Controls.Add(this.label3);
            this.tabPageAddPerson.Controls.Add(this.email);
            this.tabPageAddPerson.Controls.Add(this.txtname);
            this.tabPageAddPerson.Controls.Add(this.BtnRegister);
            this.tabPageAddPerson.Controls.Add(this.ComboBoxRoom);
            this.tabPageAddPerson.Controls.Add(this.ComboBoxInst);
            this.tabPageAddPerson.Controls.Add(this.TxtBoxEmail);
            this.tabPageAddPerson.Controls.Add(this.TxtBoxPhone);
            this.tabPageAddPerson.Controls.Add(this.TxtBoxTask);
            this.tabPageAddPerson.Controls.Add(this.TxtBoxName);
            this.tabPageAddPerson.Location = new System.Drawing.Point(4, 29);
            this.tabPageAddPerson.Name = "tabPageAddPerson";
            this.tabPageAddPerson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddPerson.Size = new System.Drawing.Size(1276, 890);
            this.tabPageAddPerson.TabIndex = 1;
            this.tabPageAddPerson.Text = "AddPerson";
            this.tabPageAddPerson.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(637, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(661, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(90, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(90, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(553, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "TaskDescription";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(579, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Institution";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(36, 223);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(48, 20);
            this.email.TabIndex = 9;
            this.email.Text = "Email";
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Location = new System.Drawing.Point(33, 135);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(51, 20);
            this.txtname.TabIndex = 8;
            this.txtname.Text = "Name";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(498, 754);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(203, 51);
            this.BtnRegister.TabIndex = 7;
            this.BtnRegister.Text = "Add To Database";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // ComboBoxRoom
            // 
            this.ComboBoxRoom.FormattingEnabled = true;
            this.ComboBoxRoom.Location = new System.Drawing.Point(707, 314);
            this.ComboBoxRoom.Name = "ComboBoxRoom";
            this.ComboBoxRoom.Size = new System.Drawing.Size(291, 28);
            this.ComboBoxRoom.TabIndex = 6;
            // 
            // ComboBoxInst
            // 
            this.ComboBoxInst.FormattingEnabled = true;
            this.ComboBoxInst.Location = new System.Drawing.Point(718, 132);
            this.ComboBoxInst.Name = "ComboBoxInst";
            this.ComboBoxInst.Size = new System.Drawing.Size(291, 28);
            this.ComboBoxInst.TabIndex = 5;
            this.ComboBoxInst.DropDownClosed += new System.EventHandler(this.ComboBoxInst_DropdownClosed);
            // 
            // TxtBoxEmail
            // 
            this.TxtBoxEmail.Location = new System.Drawing.Point(171, 217);
            this.TxtBoxEmail.Name = "TxtBoxEmail";
            this.TxtBoxEmail.Size = new System.Drawing.Size(175, 26);
            this.TxtBoxEmail.TabIndex = 4;
            // 
            // TxtBoxPhone
            // 
            this.TxtBoxPhone.Location = new System.Drawing.Point(171, 314);
            this.TxtBoxPhone.Name = "TxtBoxPhone";
            this.TxtBoxPhone.Size = new System.Drawing.Size(175, 26);
            this.TxtBoxPhone.TabIndex = 3;
            // 
            // TxtBoxTask
            // 
            this.TxtBoxTask.Location = new System.Drawing.Point(339, 492);
            this.TxtBoxTask.Multiline = true;
            this.TxtBoxTask.Name = "TxtBoxTask";
            this.TxtBoxTask.Size = new System.Drawing.Size(561, 186);
            this.TxtBoxTask.TabIndex = 2;
            // 
            // TxtBoxName
            // 
            this.TxtBoxName.Location = new System.Drawing.Point(171, 132);
            this.TxtBoxName.Name = "TxtBoxName";
            this.TxtBoxName.Size = new System.Drawing.Size(175, 26);
            this.TxtBoxName.TabIndex = 0;
            // 
            // labelsearch
            // 
            this.labelsearch.AutoSize = true;
            this.labelsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsearch.Location = new System.Drawing.Point(177, 195);
            this.labelsearch.Name = "labelsearch";
            this.labelsearch.Size = new System.Drawing.Size(71, 20);
            this.labelsearch.TabIndex = 3;
            this.labelsearch.Text = "Search:";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FindPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 933);
            this.Controls.Add(this.tabControl1);
            this.Name = "FindPersonForm";
            this.Text = "FindPersonForm";
            this.Load += new System.EventHandler(this.FindPersonForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageAddPerson.ResumeLayout(false);
            this.tabPageAddPerson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader work;
        private System.Windows.Forms.ColumnHeader institution;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageAddPerson;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.ComboBox ComboBoxRoom;
        private System.Windows.Forms.ComboBox ComboBoxInst;
        private System.Windows.Forms.TextBox TxtBoxEmail;
        private System.Windows.Forms.TextBox TxtBoxPhone;
        private System.Windows.Forms.TextBox TxtBoxTask;
        private System.Windows.Forms.TextBox TxtBoxName;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelsearch;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}