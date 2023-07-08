namespace EmployeeManagementSystem
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpDGV = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EmpGenCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EmpEduCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EmpPhoneTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpDob = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpPosCb = new System.Windows.Forms.ComboBox();
            this.EmpAddTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpNameTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.EmpIDTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.EmpDGV);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.EmpGenCb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.EmpEduCb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EmpPhoneTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EmpDob);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EmpPosCb);
            this.panel1.Controls.Add(this.EmpAddTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EmpNameTb);
            this.panel1.Controls.Add(this.EmpIDTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1523, 605);
            this.panel1.TabIndex = 0;
            // 
            // EmpDGV
            // 
            this.EmpDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.EmpDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpDGV.GridColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpDGV.Location = new System.Drawing.Point(741, 3);
            this.EmpDGV.Name = "EmpDGV";
            this.EmpDGV.RowHeadersWidth = 51;
            this.EmpDGV.RowTemplate.Height = 24;
            this.EmpDGV.Size = new System.Drawing.Size(779, 599);
            this.EmpDGV.TabIndex = 29;
            this.EmpDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDGV_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(191, 478);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 49);
            this.button4.TabIndex = 28;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button3.Location = new System.Drawing.Point(368, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 49);
            this.button3.TabIndex = 27;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(562, 478);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 49);
            this.button2.TabIndex = 26;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(28, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 49);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmpGenCb
            // 
            this.EmpGenCb.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpGenCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpGenCb.FormattingEnabled = true;
            this.EmpGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpGenCb.Location = new System.Drawing.Point(368, 230);
            this.EmpGenCb.Name = "EmpGenCb";
            this.EmpGenCb.Size = new System.Drawing.Size(339, 24);
            this.EmpGenCb.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(360, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(313, 43);
            this.label8.TabIndex = 23;
            this.label8.Text = "Employee Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(360, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 43);
            this.label7.TabIndex = 22;
            this.label7.Text = "Employee Name";
            // 
            // EmpEduCb
            // 
            this.EmpEduCb.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpEduCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpEduCb.FormattingEnabled = true;
            this.EmpEduCb.Items.AddRange(new object[] {
            "BTech",
            "MTech",
            "BBA",
            "BCA",
            "MBA",
            "BCom",
            "MCom"});
            this.EmpEduCb.Location = new System.Drawing.Point(368, 418);
            this.EmpEduCb.Name = "EmpEduCb";
            this.EmpEduCb.Size = new System.Drawing.Size(339, 24);
            this.EmpEduCb.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(360, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(359, 43);
            this.label6.TabIndex = 20;
            this.label6.Text = "Employee Education";
            // 
            // EmpPhoneTb
            // 
            this.EmpPhoneTb.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpPhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpPhoneTb.Depth = 0;
            this.EmpPhoneTb.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpPhoneTb.Hint = "";
            this.EmpPhoneTb.Location = new System.Drawing.Point(28, 418);
            this.EmpPhoneTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmpPhoneTb.Name = "EmpPhoneTb";
            this.EmpPhoneTb.PasswordChar = '\0';
            this.EmpPhoneTb.SelectedText = "";
            this.EmpPhoneTb.SelectionLength = 0;
            this.EmpPhoneTb.SelectionStart = 0;
            this.EmpPhoneTb.Size = new System.Drawing.Size(308, 28);
            this.EmpPhoneTb.TabIndex = 19;
            this.EmpPhoneTb.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(20, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(297, 43);
            this.label5.TabIndex = 18;
            this.label5.Text = "Employee Phone";
            // 
            // EmpDob
            // 
            this.EmpDob.CalendarForeColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpDob.CalendarMonthBackground = System.Drawing.Color.DeepSkyBlue;
            this.EmpDob.CalendarTitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpDob.CalendarTitleForeColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpDob.CalendarTrailingForeColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpDob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpDob.Location = new System.Drawing.Point(368, 322);
            this.EmpDob.Name = "EmpDob";
            this.EmpDob.Size = new System.Drawing.Size(339, 22);
            this.EmpDob.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(20, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 43);
            this.label4.TabIndex = 16;
            this.label4.Text = "Employee Position";
            // 
            // EmpPosCb
            // 
            this.EmpPosCb.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpPosCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EmpPosCb.FormattingEnabled = true;
            this.EmpPosCb.Items.AddRange(new object[] {
            "Manager",
            "Senior Developper",
            "Junior Developper",
            "Accountant ",
            "Receptionist"});
            this.EmpPosCb.Location = new System.Drawing.Point(28, 320);
            this.EmpPosCb.Name = "EmpPosCb";
            this.EmpPosCb.Size = new System.Drawing.Size(308, 24);
            this.EmpPosCb.TabIndex = 15;
            // 
            // EmpAddTb
            // 
            this.EmpAddTb.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpAddTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpAddTb.Depth = 0;
            this.EmpAddTb.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpAddTb.Hint = "";
            this.EmpAddTb.Location = new System.Drawing.Point(28, 230);
            this.EmpAddTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmpAddTb.Name = "EmpAddTb";
            this.EmpAddTb.PasswordChar = '\0';
            this.EmpAddTb.SelectedText = "";
            this.EmpAddTb.SelectionLength = 0;
            this.EmpAddTb.SelectionStart = 0;
            this.EmpAddTb.Size = new System.Drawing.Size(308, 28);
            this.EmpAddTb.TabIndex = 13;
            this.EmpAddTb.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(20, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 43);
            this.label3.TabIndex = 12;
            this.label3.Text = "Employee Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(360, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 43);
            this.label1.TabIndex = 11;
            this.label1.Text = "Employee Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpNameTb.Depth = 0;
            this.EmpNameTb.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpNameTb.Hint = "";
            this.EmpNameTb.Location = new System.Drawing.Point(368, 140);
            this.EmpNameTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.PasswordChar = '\0';
            this.EmpNameTb.SelectedText = "";
            this.EmpNameTb.SelectionLength = 0;
            this.EmpNameTb.SelectionStart = 0;
            this.EmpNameTb.Size = new System.Drawing.Size(339, 28);
            this.EmpNameTb.TabIndex = 10;
            this.EmpNameTb.UseSystemPasswordChar = false;
            // 
            // EmpIDTb
            // 
            this.EmpIDTb.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpIDTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpIDTb.Depth = 0;
            this.EmpIDTb.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpIDTb.Hint = "";
            this.EmpIDTb.Location = new System.Drawing.Point(28, 140);
            this.EmpIDTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmpIDTb.Name = "EmpIDTb";
            this.EmpIDTb.PasswordChar = '\0';
            this.EmpIDTb.SelectedText = "";
            this.EmpIDTb.SelectionLength = 0;
            this.EmpIDTb.SelectionStart = 0;
            this.EmpIDTb.Size = new System.Drawing.Size(308, 28);
            this.EmpIDTb.TabIndex = 9;
            this.EmpIDTb.UseSystemPasswordChar = false;
            this.EmpIDTb.Click += new System.EventHandler(this.EmpIDTb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 43);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(189, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(518, 75);
            this.label9.TabIndex = 29;
            this.label9.Text = "Manage Employee";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(1441, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 43);
            this.label10.TabIndex = 30;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1523, 838);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField EmpNameTb;
        private MaterialSkin.Controls.MaterialSingleLineTextField EmpIDTb;
        private System.Windows.Forms.ComboBox EmpEduCb;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialSingleLineTextField EmpPhoneTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker EmpDob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EmpPosCb;
        private MaterialSkin.Controls.MaterialSingleLineTextField EmpAddTb;
        private System.Windows.Forms.ComboBox EmpGenCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView EmpDGV;
    }
}