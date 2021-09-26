namespace Facial_rec_attendance
{
    partial class HomePage
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddnewstudent = new System.Windows.Forms.Button();
            this.btnattendance = new System.Windows.Forms.Button();
            this.btnschedule = new System.Windows.Forms.Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnext = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddnewstudent);
            this.panel1.Controls.Add(this.btnattendance);
            this.panel1.Controls.Add(this.btnschedule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 3;
            // 
            // btnAddnewstudent
            // 
            this.btnAddnewstudent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddnewstudent.FlatAppearance.BorderSize = 0;
            this.btnAddnewstudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddnewstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnewstudent.Image = global::Facial_rec_attendance.Properties.Resources.icons8_id_verified_64;
            this.btnAddnewstudent.Location = new System.Drawing.Point(0, 3);
            this.btnAddnewstudent.Name = "btnAddnewstudent";
            this.btnAddnewstudent.Size = new System.Drawing.Size(194, 106);
            this.btnAddnewstudent.TabIndex = 0;
            this.btnAddnewstudent.Text = "Add new Student";
            this.btnAddnewstudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddnewstudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddnewstudent.UseVisualStyleBackColor = false;
            this.btnAddnewstudent.Click += new System.EventHandler(this.btnAddnewstudent_Click);
            // 
            // btnattendance
            // 
            this.btnattendance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnattendance.FlatAppearance.BorderSize = 0;
            this.btnattendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnattendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnattendance.Image = global::Facial_rec_attendance.Properties.Resources.icons8_attendance_48;
            this.btnattendance.Location = new System.Drawing.Point(0, 170);
            this.btnattendance.Name = "btnattendance";
            this.btnattendance.Size = new System.Drawing.Size(191, 106);
            this.btnattendance.TabIndex = 2;
            this.btnattendance.Text = "Take Register";
            this.btnattendance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnattendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnattendance.UseVisualStyleBackColor = false;
            this.btnattendance.Click += new System.EventHandler(this.btnattendance_Click);
            // 
            // btnschedule
            // 
            this.btnschedule.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnschedule.FlatAppearance.BorderSize = 0;
            this.btnschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnschedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnschedule.Image = global::Facial_rec_attendance.Properties.Resources.icons8_create_48;
            this.btnschedule.Location = new System.Drawing.Point(0, 341);
            this.btnschedule.Name = "btnschedule";
            this.btnschedule.Size = new System.Drawing.Size(194, 106);
            this.btnschedule.TabIndex = 1;
            this.btnschedule.Text = "View Schedule";
            this.btnschedule.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnschedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnschedule.UseVisualStyleBackColor = false;
            this.btnschedule.Click += new System.EventHandler(this.btnschedule_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(682, 9);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(43, 20);
            this.lbltime.TabIndex = 4;
            this.lbltime.Text = "time";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(562, 9);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(45, 20);
            this.lbldate.TabIndex = 5;
            this.lbldate.Text = "date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnext
            // 
            this.btnext.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnext.Location = new System.Drawing.Point(686, 400);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(88, 38);
            this.btnext.TabIndex = 6;
            this.btnext.Text = "Exit";
            this.btnext.UseVisualStyleBackColor = false;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddnewstudent;
        private System.Windows.Forms.Button btnschedule;
        private System.Windows.Forms.Button btnattendance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnext;
    }
}