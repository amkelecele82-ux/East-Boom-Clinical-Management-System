namespace MProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.aclabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lobutton = new System.Windows.Forms.Button();
            this.sebutton = new System.Windows.Forms.Button();
            this.acbutton = new System.Windows.Forms.Button();
            this.pabutton = new System.Windows.Forms.Button();
            this.dbbutton = new System.Windows.Forms.Button();
            this.apbutton = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.consultationTableAdapter1 = new MProject.DataSet1TableAdapters.ConsultationTableAdapter();
            this.sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(80)))), ((int)(((byte)(41)))));
            this.sidepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidepanel.Controls.Add(this.aclabel);
            this.sidepanel.Controls.Add(this.pictureBox1);
            this.sidepanel.Controls.Add(this.lobutton);
            this.sidepanel.Controls.Add(this.sebutton);
            this.sidepanel.Controls.Add(this.acbutton);
            this.sidepanel.Controls.Add(this.pabutton);
            this.sidepanel.Controls.Add(this.dbbutton);
            this.sidepanel.Controls.Add(this.apbutton);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 0);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(220, 721);
            this.sidepanel.TabIndex = 0;
            // 
            // aclabel
            // 
            this.aclabel.AutoSize = true;
            this.aclabel.ForeColor = System.Drawing.SystemColors.Control;
            this.aclabel.Location = new System.Drawing.Point(68, 651);
            this.aclabel.Name = "aclabel";
            this.aclabel.Size = new System.Drawing.Size(130, 16);
            this.aclabel.TabIndex = 0;
            this.aclabel.Text = "account@gmail.com";
            this.aclabel.Click += new System.EventHandler(this.aclabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 489);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lobutton
            // 
            this.lobutton.FlatAppearance.BorderSize = 0;
            this.lobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lobutton.ForeColor = System.Drawing.SystemColors.Control;
            this.lobutton.Location = new System.Drawing.Point(3, 670);
            this.lobutton.Name = "lobutton";
            this.lobutton.Size = new System.Drawing.Size(210, 38);
            this.lobutton.TabIndex = 5;
            this.lobutton.Text = "Logout";
            this.lobutton.UseVisualStyleBackColor = true;
            this.lobutton.Click += new System.EventHandler(this.lobutton_Click);
            // 
            // sebutton
            // 
            this.sebutton.FlatAppearance.BorderSize = 0;
            this.sebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sebutton.ForeColor = System.Drawing.SystemColors.Control;
            this.sebutton.Location = new System.Drawing.Point(5, 306);
            this.sebutton.Name = "sebutton";
            this.sebutton.Size = new System.Drawing.Size(210, 38);
            this.sebutton.TabIndex = 4;
            this.sebutton.Text = "Settings";
            this.sebutton.UseVisualStyleBackColor = true;
            this.sebutton.Click += new System.EventHandler(this.sebutton_Click);
            // 
            // acbutton
            // 
            this.acbutton.FlatAppearance.BorderSize = 0;
            this.acbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.acbutton.Location = new System.Drawing.Point(3, 245);
            this.acbutton.Name = "acbutton";
            this.acbutton.Size = new System.Drawing.Size(210, 38);
            this.acbutton.TabIndex = 3;
            this.acbutton.Text = "Account";
            this.acbutton.UseVisualStyleBackColor = true;
            // 
            // pabutton
            // 
            this.pabutton.FlatAppearance.BorderSize = 0;
            this.pabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pabutton.ForeColor = System.Drawing.SystemColors.Control;
            this.pabutton.Location = new System.Drawing.Point(5, 183);
            this.pabutton.Name = "pabutton";
            this.pabutton.Size = new System.Drawing.Size(210, 38);
            this.pabutton.TabIndex = 2;
            this.pabutton.Text = "Patient";
            this.pabutton.UseVisualStyleBackColor = true;
            this.pabutton.Click += new System.EventHandler(this.pabutton_Click);
            // 
            // dbbutton
            // 
            this.dbbutton.FlatAppearance.BorderSize = 0;
            this.dbbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dbbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.dbbutton.Location = new System.Drawing.Point(3, 65);
            this.dbbutton.Name = "dbbutton";
            this.dbbutton.Size = new System.Drawing.Size(212, 38);
            this.dbbutton.TabIndex = 1;
            this.dbbutton.Text = "Dashboard";
            this.dbbutton.UseVisualStyleBackColor = true;
            this.dbbutton.Click += new System.EventHandler(this.dbbutton_Click);
            // 
            // apbutton
            // 
            this.apbutton.FlatAppearance.BorderSize = 0;
            this.apbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.apbutton.Location = new System.Drawing.Point(3, 124);
            this.apbutton.Name = "apbutton";
            this.apbutton.Size = new System.Drawing.Size(210, 38);
            this.apbutton.TabIndex = 0;
            this.apbutton.Text = "Appointment";
            this.apbutton.UseVisualStyleBackColor = true;
            this.apbutton.Click += new System.EventHandler(this.apbutton_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(220, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1128, 721);
            this.mainpanel.TabIndex = 1;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // consultationTableAdapter1
            // 
            this.consultationTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.sidepanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button apbutton;
        private System.Windows.Forms.Button lobutton;
        private System.Windows.Forms.Button sebutton;
        private System.Windows.Forms.Button acbutton;
        private System.Windows.Forms.Button pabutton;
        private System.Windows.Forms.Button dbbutton;
        private DataSet1TableAdapters.ConsultationTableAdapter consultationTableAdapter1;
        private System.Windows.Forms.Label aclabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

