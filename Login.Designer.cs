namespace EmployeeManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UidTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Label1 = new System.Windows.Forms.Label();
            this.PassTb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UidTb
            // 
            this.UidTb.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UidTb.Depth = 0;
            this.UidTb.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.UidTb.Hint = "";
            this.UidTb.Location = new System.Drawing.Point(372, 81);
            this.UidTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.UidTb.Name = "UidTb";
            this.UidTb.PasswordChar = '\0';
            this.UidTb.SelectedText = "";
            this.UidTb.SelectionLength = 0;
            this.UidTb.SelectionStart = 0;
            this.UidTb.Size = new System.Drawing.Size(267, 28);
            this.UidTb.TabIndex = 4;
            this.UidTb.UseSystemPasswordChar = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Label1.Location = new System.Drawing.Point(185, 66);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(161, 43);
            this.Label1.TabIndex = 5;
            this.Label1.Text = "Userd ID";
            // 
            // PassTb
            // 
            this.PassTb.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.PassTb.Depth = 0;
            this.PassTb.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PassTb.Hint = "";
            this.PassTb.Location = new System.Drawing.Point(372, 140);
            this.PassTb.MouseState = MaterialSkin.MouseState.HOVER;
            this.PassTb.Name = "PassTb";
            this.PassTb.PasswordChar = '\0';
            this.PassTb.SelectedText = "";
            this.PassTb.SelectionLength = 0;
            this.PassTb.SelectionStart = 0;
            this.PassTb.Size = new System.Drawing.Size(267, 28);
            this.PassTb.TabIndex = 6;
            this.PassTb.UseSystemPasswordChar = false;
            this.PassTb.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(185, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 43);
            this.label2.TabIndex = 7;
            this.label2.Text = "Userd ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(433, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(185, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 49);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 282);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.UidTb);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField UidTb;
        private System.Windows.Forms.Label Label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField PassTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}