namespace EmployeeManagementSystem
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalarySlip = new System.Windows.Forms.RichTextBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.FetchData = new System.Windows.Forms.Button();
            this.WorkedTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpNameTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpPosTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.EmpIDTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(1454, -2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 43);
            this.label10.TabIndex = 36;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(189, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(518, 75);
            this.label9.TabIndex = 35;
            this.label9.Text = "Manage Employee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.SalarySlip);
            this.panel1.Controls.Add(this.ViewButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Controls.Add(this.PrintButton);
            this.panel1.Controls.Add(this.FetchData);
            this.panel1.Controls.Add(this.WorkedTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EmpNameTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmpPosTb);
            this.panel1.Controls.Add(this.EmpIDTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1523, 605);
            this.panel1.TabIndex = 38;
            // 
            // SalarySlip
            // 
            this.SalarySlip.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SalarySlip.Font = new System.Drawing.Font("Verdana Pro Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SalarySlip.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.SalarySlip.Location = new System.Drawing.Point(699, 61);
            this.SalarySlip.Name = "SalarySlip";
            this.SalarySlip.Size = new System.Drawing.Size(795, 469);
            this.SalarySlip.TabIndex = 30;
            this.SalarySlip.Text = "";
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ViewButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ViewButton.Location = new System.Drawing.Point(202, 481);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(145, 49);
            this.ViewButton.TabIndex = 28;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = false;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HomeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.HomeButton.Location = new System.Drawing.Point(28, 481);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(145, 49);
            this.HomeButton.TabIndex = 27;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PrintButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PrintButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PrintButton.Location = new System.Drawing.Point(1349, 536);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(145, 49);
            this.PrintButton.TabIndex = 26;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // FetchData
            // 
            this.FetchData.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.FetchData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FetchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FetchData.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.FetchData.Location = new System.Drawing.Point(368, 119);
            this.FetchData.Name = "FetchData";
            this.FetchData.Size = new System.Drawing.Size(145, 49);
            this.FetchData.TabIndex = 25;
            this.FetchData.Text = "Add";
            this.FetchData.UseVisualStyleBackColor = false;
            this.FetchData.Click += new System.EventHandler(this.button1_Click);
            // 
            // WorkedTb
            // 
            this.WorkedTb.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.WorkedTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WorkedTb.Depth = 0;
            this.WorkedTb.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.WorkedTb.Hint = "";
            this.WorkedTb.Location = new System.Drawing.Point(28, 418);
            this.WorkedTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.WorkedTb.Name = "WorkedTb";
            this.WorkedTb.PasswordChar = '\0';
            this.WorkedTb.SelectedText = "";
            this.WorkedTb.SelectionLength = 0;
            this.WorkedTb.SelectionStart = 0;
            this.WorkedTb.Size = new System.Drawing.Size(308, 28);
            this.WorkedTb.TabIndex = 19;
            this.WorkedTb.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(20, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 43);
            this.label5.TabIndex = 18;
            this.label5.Text = "Worked Days";
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
            // EmpNameTb
            // 
            this.EmpNameTb.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpNameTb.Depth = 0;
            this.EmpNameTb.Enabled = false;
            this.EmpNameTb.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpNameTb.Hint = "";
            this.EmpNameTb.Location = new System.Drawing.Point(28, 230);
            this.EmpNameTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.PasswordChar = '\0';
            this.EmpNameTb.SelectedText = "";
            this.EmpNameTb.SelectionLength = 0;
            this.EmpNameTb.SelectionStart = 0;
            this.EmpNameTb.Size = new System.Drawing.Size(308, 28);
            this.EmpNameTb.TabIndex = 13;
            this.EmpNameTb.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(20, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 43);
            this.label3.TabIndex = 12;
            this.label3.Text = "Employee Name";
            // 
            // EmpPosTb
            // 
            this.EmpPosTb.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpPosTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpPosTb.Depth = 0;
            this.EmpPosTb.Enabled = false;
            this.EmpPosTb.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.EmpPosTb.Hint = "";
            this.EmpPosTb.Location = new System.Drawing.Point(28, 332);
            this.EmpPosTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmpPosTb.Name = "EmpPosTb";
            this.EmpPosTb.PasswordChar = '\0';
            this.EmpPosTb.SelectedText = "";
            this.EmpPosTb.SelectionLength = 0;
            this.EmpPosTb.SelectionStart = 0;
            this.EmpPosTb.Size = new System.Drawing.Size(319, 28);
            this.EmpPosTb.TabIndex = 10;
            this.EmpPosTb.UseSystemPasswordChar = false;
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1523, 838);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button FetchData;
        private MaterialSkin.Controls.MaterialSingleLineTextField WorkedTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField EmpNameTb;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField EmpPosTb;
        private MaterialSkin.Controls.MaterialSingleLineTextField EmpIDTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox SalarySlip;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}