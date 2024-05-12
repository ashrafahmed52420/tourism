namespace WindowsFormsApp1
{
    partial class homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logoutbtn = new System.Windows.Forms.Button();
            this.myprobtn = new System.Windows.Forms.Button();
            this.shylbtn = new System.Windows.Forms.Button();
            this.sajekbtn = new System.Windows.Forms.Button();
            this.sainntbn = new System.Windows.Forms.Button();
            this.chitabtn = new System.Windows.Forms.Button();
            this.coxsbtn = new System.Windows.Forms.Button();
            this.bandarbanbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 64);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.logoutbtn);
            this.panel2.Controls.Add(this.myprobtn);
            this.panel2.Controls.Add(this.shylbtn);
            this.panel2.Controls.Add(this.sajekbtn);
            this.panel2.Controls.Add(this.sainntbn);
            this.panel2.Controls.Add(this.chitabtn);
            this.panel2.Controls.Add(this.coxsbtn);
            this.panel2.Controls.Add(this.bandarbanbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 483);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // logoutbtn
            // 
            this.logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logoutbtn.Location = new System.Drawing.Point(0, 434);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(160, 36);
            this.logoutbtn.TabIndex = 7;
            this.logoutbtn.Text = "Logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.button8_Click);
            // 
            // myprobtn
            // 
            this.myprobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myprobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myprobtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.myprobtn.Location = new System.Drawing.Point(0, 392);
            this.myprobtn.Name = "myprobtn";
            this.myprobtn.Size = new System.Drawing.Size(160, 36);
            this.myprobtn.TabIndex = 6;
            this.myprobtn.Text = "My Profile";
            this.myprobtn.UseVisualStyleBackColor = true;
            this.myprobtn.Click += new System.EventHandler(this.button7_Click);
            // 
            // shylbtn
            // 
            this.shylbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shylbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shylbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.shylbtn.Location = new System.Drawing.Point(1, 223);
            this.shylbtn.Name = "shylbtn";
            this.shylbtn.Size = new System.Drawing.Size(160, 36);
            this.shylbtn.TabIndex = 5;
            this.shylbtn.Text = "Dhaka - Shylet";
            this.shylbtn.UseVisualStyleBackColor = true;
            this.shylbtn.Click += new System.EventHandler(this.shylbtn_Click);
            // 
            // sajekbtn
            // 
            this.sajekbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sajekbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sajekbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sajekbtn.Location = new System.Drawing.Point(0, 174);
            this.sajekbtn.Name = "sajekbtn";
            this.sajekbtn.Size = new System.Drawing.Size(160, 36);
            this.sajekbtn.TabIndex = 4;
            this.sajekbtn.Text = "Dhaka - Sajek";
            this.sajekbtn.UseVisualStyleBackColor = true;
            this.sajekbtn.Click += new System.EventHandler(this.sajekbtn_Click);
            // 
            // sainntbn
            // 
            this.sainntbn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sainntbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sainntbn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sainntbn.Location = new System.Drawing.Point(0, 132);
            this.sainntbn.Name = "sainntbn";
            this.sainntbn.Size = new System.Drawing.Size(160, 36);
            this.sainntbn.TabIndex = 3;
            this.sainntbn.Text = "Dhaka - Saintmartin";
            this.sainntbn.UseVisualStyleBackColor = true;
            this.sainntbn.Click += new System.EventHandler(this.button4_Click);
            // 
            // chitabtn
            // 
            this.chitabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chitabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chitabtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chitabtn.Location = new System.Drawing.Point(0, 90);
            this.chitabtn.Name = "chitabtn";
            this.chitabtn.Size = new System.Drawing.Size(160, 36);
            this.chitabtn.TabIndex = 2;
            this.chitabtn.Text = "Dhaka - Chittagang";
            this.chitabtn.UseVisualStyleBackColor = true;
            this.chitabtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // coxsbtn
            // 
            this.coxsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coxsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coxsbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.coxsbtn.Location = new System.Drawing.Point(0, 48);
            this.coxsbtn.Name = "coxsbtn";
            this.coxsbtn.Size = new System.Drawing.Size(160, 36);
            this.coxsbtn.TabIndex = 1;
            this.coxsbtn.Text = "Dhaka - Coxsbazar";
            this.coxsbtn.UseVisualStyleBackColor = true;
            this.coxsbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // bandarbanbtn
            // 
            this.bandarbanbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bandarbanbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bandarbanbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bandarbanbtn.Location = new System.Drawing.Point(0, 6);
            this.bandarbanbtn.Name = "bandarbanbtn";
            this.bandarbanbtn.Size = new System.Drawing.Size(160, 36);
            this.bandarbanbtn.TabIndex = 0;
            this.bandarbanbtn.Text = "Dhaka - Bandarban";
            this.bandarbanbtn.UseVisualStyleBackColor = true;
            this.bandarbanbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(539, 64);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(383, 229);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(158, 293);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(384, 254);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(539, 293);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(382, 253);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 547);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "homepage";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button coxsbtn;
        private System.Windows.Forms.Button bandarbanbtn;
        private System.Windows.Forms.Button sainntbn;
        private System.Windows.Forms.Button chitabtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Button myprobtn;
        private System.Windows.Forms.Button shylbtn;
        private System.Windows.Forms.Button sajekbtn;
    }
}