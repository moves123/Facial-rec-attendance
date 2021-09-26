namespace Facial_rec_attendance
{
    partial class register
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
            this.btntake = new System.Windows.Forms.Button();
            this.btnfacetake = new System.Windows.Forms.Button();
            this.txtPersonName = new System.Windows.Forms.TextBox();
            this.btntrain1 = new System.Windows.Forms.Button();
            this.btnidentify1 = new System.Windows.Forms.Button();
            this.btnadd1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnclose1 = new System.Windows.Forms.Button();
            this.picboox2 = new System.Windows.Forms.PictureBox();
            this.picboox1 = new System.Windows.Forms.PictureBox();
            this.picdect1 = new System.Windows.Forms.PictureBox();
            this.piccap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdect1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccap)).BeginInit();
            this.SuspendLayout();
            // 
            // btntake
            // 
            this.btntake.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btntake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntake.Location = new System.Drawing.Point(12, 388);
            this.btntake.Name = "btntake";
            this.btntake.Size = new System.Drawing.Size(108, 50);
            this.btntake.TabIndex = 1;
            this.btntake.Text = "1. Capture";
            this.btntake.UseVisualStyleBackColor = false;
            this.btntake.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // btnfacetake
            // 
            this.btnfacetake.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnfacetake.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfacetake.Location = new System.Drawing.Point(159, 388);
            this.btnfacetake.Name = "btnfacetake";
            this.btnfacetake.Size = new System.Drawing.Size(131, 50);
            this.btnfacetake.TabIndex = 2;
            this.btnfacetake.Text = "2. Detect Faces";
            this.btnfacetake.UseVisualStyleBackColor = false;
            this.btnfacetake.Click += new System.EventHandler(this.btnDetectFaces_Click);
            // 
            // txtPersonName
            // 
            this.txtPersonName.Location = new System.Drawing.Point(643, 388);
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.Size = new System.Drawing.Size(10, 20);
            this.txtPersonName.TabIndex = 3;
            this.txtPersonName.Visible = false;
            // 
            // btntrain1
            // 
            this.btntrain1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btntrain1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrain1.Location = new System.Drawing.Point(313, 388);
            this.btntrain1.Name = "btntrain1";
            this.btntrain1.Size = new System.Drawing.Size(125, 50);
            this.btntrain1.TabIndex = 5;
            this.btntrain1.Text = "3. Confirm Register";
            this.btntrain1.UseVisualStyleBackColor = false;
            this.btntrain1.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnidentify1
            // 
            this.btnidentify1.Location = new System.Drawing.Point(643, 388);
            this.btnidentify1.Name = "btnidentify1";
            this.btnidentify1.Size = new System.Drawing.Size(21, 23);
            this.btnidentify1.TabIndex = 6;
            this.btnidentify1.Text = "5. Recognize Persons";
            this.btnidentify1.UseVisualStyleBackColor = true;
            this.btnidentify1.Visible = false;
            this.btnidentify1.Click += new System.EventHandler(this.btnRecognize_Click);
            // 
            // btnadd1
            // 
            this.btnadd1.Location = new System.Drawing.Point(649, 388);
            this.btnadd1.Name = "btnadd1";
            this.btnadd1.Size = new System.Drawing.Size(15, 23);
            this.btnadd1.TabIndex = 9;
            this.btnadd1.Text = "3. Add Person";
            this.btnadd1.UseVisualStyleBackColor = true;
            this.btnadd1.Visible = false;
            this.btnadd1.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(483, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 61);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnclose1
            // 
            this.btnclose1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnclose1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose1.Location = new System.Drawing.Point(700, 388);
            this.btnclose1.Name = "btnclose1";
            this.btnclose1.Size = new System.Drawing.Size(88, 42);
            this.btnclose1.TabIndex = 12;
            this.btnclose1.Text = "Close";
            this.btnclose1.UseVisualStyleBackColor = false;
            this.btnclose1.Click += new System.EventHandler(this.btnclose1_Click);
            // 
            // picboox2
            // 
            this.picboox2.Location = new System.Drawing.Point(524, 12);
            this.picboox2.Name = "picboox2";
            this.picboox2.Size = new System.Drawing.Size(53, 68);
            this.picboox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboox2.TabIndex = 10;
            this.picboox2.TabStop = false;
            // 
            // picboox1
            // 
            this.picboox1.Location = new System.Drawing.Point(465, 12);
            this.picboox1.Name = "picboox1";
            this.picboox1.Size = new System.Drawing.Size(53, 68);
            this.picboox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboox1.TabIndex = 10;
            this.picboox1.TabStop = false;
            // 
            // picdect1
            // 
            this.picdect1.Location = new System.Drawing.Point(629, 398);
            this.picdect1.Name = "picdect1";
            this.picdect1.Size = new System.Drawing.Size(35, 10);
            this.picdect1.TabIndex = 7;
            this.picdect1.TabStop = false;
            this.picdect1.Visible = false;
            // 
            // piccap
            // 
            this.piccap.Location = new System.Drawing.Point(5, 6);
            this.piccap.Name = "piccap";
            this.piccap.Size = new System.Drawing.Size(433, 376);
            this.piccap.TabIndex = 0;
            this.piccap.TabStop = false;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclose1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.picboox2);
            this.Controls.Add(this.picboox1);
            this.Controls.Add(this.btnadd1);
            this.Controls.Add(this.picdect1);
            this.Controls.Add(this.btnidentify1);
            this.Controls.Add(this.btntrain1);
            this.Controls.Add(this.txtPersonName);
            this.Controls.Add(this.btnfacetake);
            this.Controls.Add(this.btntake);
            this.Controls.Add(this.piccap);
            this.Name = "register";
            this.Text = "Facial recognition app";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdect1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piccap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piccap;
        private System.Windows.Forms.Button btntake;
        private System.Windows.Forms.Button btnfacetake;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Button btntrain1;
        private System.Windows.Forms.Button btnidentify1;
        private System.Windows.Forms.PictureBox picdect1;
        private System.Windows.Forms.Button btnadd1;
        private System.Windows.Forms.PictureBox picboox1;
        private System.Windows.Forms.PictureBox picboox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnclose1;
    }
}

