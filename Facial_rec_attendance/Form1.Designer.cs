namespace Facial_rec_attendance
{
    partial class Form1
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
            this.picDetect = new System.Windows.Forms.PictureBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.btndetect = new System.Windows.Forms.Button();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.picDetected = new System.Windows.Forms.PictureBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.picdetectedimg1 = new System.Windows.Forms.PictureBox();
            this.picdetectedimg2 = new System.Windows.Forms.PictureBox();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnhelp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnx = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDetect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdetectedimg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdetectedimg2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picDetect
            // 
            this.picDetect.Location = new System.Drawing.Point(5, 6);
            this.picDetect.Name = "picDetect";
            this.picDetect.Size = new System.Drawing.Size(503, 376);
            this.picDetect.TabIndex = 0;
            this.picDetect.TabStop = false;
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.Location = new System.Drawing.Point(159, 388);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(112, 50);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "1. Capture";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btndetect
            // 
            this.btndetect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btndetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetect.Location = new System.Drawing.Point(627, 140);
            this.btndetect.Name = "btndetect";
            this.btndetect.Size = new System.Drawing.Size(123, 40);
            this.btndetect.TabIndex = 2;
            this.btndetect.Text = "3. Detect Faces";
            this.btndetect.UseVisualStyleBackColor = false;
            this.btndetect.Click += new System.EventHandler(this.btnDetectFaces_Click);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(559, 46);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(122, 20);
            this.txtfirstname.TabIndex = 3;
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(604, 423);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(52, 23);
            this.btnTrain.TabIndex = 5;
            this.btnTrain.Text = "5. Train Images";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Visible = false;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnRecognize
            // 
            this.btnRecognize.Location = new System.Drawing.Point(627, 423);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(15, 23);
            this.btnRecognize.TabIndex = 6;
            this.btnRecognize.Text = "5. Recognize Persons";
            this.btnRecognize.UseVisualStyleBackColor = true;
            this.btnRecognize.Visible = false;
            this.btnRecognize.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // picDetected
            // 
            this.picDetected.Location = new System.Drawing.Point(637, 186);
            this.picDetected.Name = "picDetected";
            this.picDetected.Size = new System.Drawing.Size(123, 123);
            this.picDetected.TabIndex = 7;
            this.picDetected.TabStop = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(637, 341);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(123, 41);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "4. Add Person";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // picdetectedimg1
            // 
            this.picdetectedimg1.Location = new System.Drawing.Point(604, 423);
            this.picdetectedimg1.Name = "picdetectedimg1";
            this.picdetectedimg1.Size = new System.Drawing.Size(53, 15);
            this.picdetectedimg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picdetectedimg1.TabIndex = 10;
            this.picdetectedimg1.TabStop = false;
            this.picdetectedimg1.Visible = false;
            // 
            // picdetectedimg2
            // 
            this.picdetectedimg2.Location = new System.Drawing.Point(604, 423);
            this.picdetectedimg2.Name = "picdetectedimg2";
            this.picdetectedimg2.Size = new System.Drawing.Size(53, 15);
            this.picdetectedimg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picdetectedimg2.TabIndex = 10;
            this.picdetectedimg2.TabStop = false;
            this.picdetectedimg2.Visible = false;
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(559, 106);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(122, 20);
            this.txtsurname.TabIndex = 11;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(692, 46);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(49, 16);
            this.lblname.TabIndex = 12;
            this.lblname.Text = "Name";
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsurname.Location = new System.Drawing.Point(691, 106);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(69, 16);
            this.lblsurname.TabIndex = 13;
            this.lblsurname.Text = "Surname";
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(695, 400);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(93, 38);
            this.btnclose.TabIndex = 14;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnhelp
            // 
            this.btnhelp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnhelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhelp.Location = new System.Drawing.Point(559, 400);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(75, 38);
            this.btnhelp.TabIndex = 15;
            this.btnhelp.Text = "Help";
            this.btnhelp.UseVisualStyleBackColor = false;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnx);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(79, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 247);
            this.panel1.TabIndex = 16;
            this.panel1.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Step 1) Press the capture button to open the camera",
            "Step 2) Enter the student name and surname",
            "Step 3) Detect the face by pressing detectbutton",
            "Step4) Add the student to the database",
            "Step5) Close the page"});
            this.listBox1.Location = new System.Drawing.Point(3, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(268, 199);
            this.listBox1.TabIndex = 0;
            // 
            // btnx
            // 
            this.btnx.Location = new System.Drawing.Point(274, 3);
            this.btnx.Name = "btnx";
            this.btnx.Size = new System.Drawing.Size(30, 23);
            this.btnx.TabIndex = 17;
            this.btnx.Text = "X";
            this.btnx.UseVisualStyleBackColor = true;
            this.btnx.Click += new System.EventHandler(this.btnx_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnhelp);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lblsurname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtsurname);
            this.Controls.Add(this.picdetectedimg2);
            this.Controls.Add(this.picdetectedimg1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.picDetected);
            this.Controls.Add(this.btnRecognize);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.btndetect);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.picDetect);
            this.Name = "Form1";
            this.Text = "Facial recognition app";
            ((System.ComponentModel.ISupportInitialize)(this.picDetect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdetectedimg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdetectedimg2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDetect;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Button btndetect;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.PictureBox picDetected;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.PictureBox picdetectedimg1;
        private System.Windows.Forms.PictureBox picdetectedimg2;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnhelp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnx;
    }
}

