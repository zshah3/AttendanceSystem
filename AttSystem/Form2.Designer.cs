namespace AttSystem
{
    partial class Form2
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
            this.LogOut = new System.Windows.Forms.Button();
            this.course1 = new System.Windows.Forms.Button();
            this.course2 = new System.Windows.Forms.Button();
            this.course3 = new System.Windows.Forms.Button();
            this.course6 = new System.Windows.Forms.Button();
            this.course4 = new System.Windows.Forms.Button();
            this.course5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(315, 12);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 23);
            this.LogOut.TabIndex = 0;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // course1
            // 
            this.course1.Location = new System.Drawing.Point(12, 22);
            this.course1.Name = "course1";
            this.course1.Size = new System.Drawing.Size(135, 38);
            this.course1.TabIndex = 1;
            this.course1.Text = "Database Technology";
            this.course1.UseVisualStyleBackColor = true;
            this.course1.Click += new System.EventHandler(this.course1_Click);
            // 
            // course2
            // 
            this.course2.Location = new System.Drawing.Point(12, 71);
            this.course2.Name = "course2";
            this.course2.Size = new System.Drawing.Size(135, 38);
            this.course2.TabIndex = 2;
            this.course2.Text = "System Development Project";
            this.course2.UseVisualStyleBackColor = true;
            this.course2.Click += new System.EventHandler(this.course2_Click);
            // 
            // course3
            // 
            this.course3.Location = new System.Drawing.Point(12, 117);
            this.course3.Name = "course3";
            this.course3.Size = new System.Drawing.Size(135, 39);
            this.course3.TabIndex = 3;
            this.course3.Text = "Information Analysis";
            this.course3.UseVisualStyleBackColor = true;
            // 
            // course6
            // 
            this.course6.Location = new System.Drawing.Point(166, 117);
            this.course6.Name = "course6";
            this.course6.Size = new System.Drawing.Size(135, 39);
            this.course6.TabIndex = 4;
            this.course6.Text = "Application And Web development";
            this.course6.UseVisualStyleBackColor = true;
            // 
            // course4
            // 
            this.course4.Location = new System.Drawing.Point(166, 22);
            this.course4.Name = "course4";
            this.course4.Size = new System.Drawing.Size(135, 38);
            this.course4.TabIndex = 5;
            this.course4.Text = "Principles Of Security";
            this.course4.UseVisualStyleBackColor = true;
            // 
            // course5
            // 
            this.course5.Location = new System.Drawing.Point(166, 71);
            this.course5.Name = "course5";
            this.course5.Size = new System.Drawing.Size(135, 38);
            this.course5.TabIndex = 6;
            this.course5.Text = "Principles Of Security";
            this.course5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.course5);
            this.groupBox1.Controls.Add(this.course4);
            this.groupBox1.Controls.Add(this.course6);
            this.groupBox1.Controls.Add(this.course3);
            this.groupBox1.Controls.Add(this.course2);
            this.groupBox1.Controls.Add(this.course1);
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 176);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please select a course";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AttSystem.Properties.Resources.comp;
            this.pictureBox1.Location = new System.Drawing.Point(2, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AttSystem.Properties.Resources.uog_logo;
            this.pictureBox2.Location = new System.Drawing.Point(12, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::AttSystem.Properties.Resources.banner_title;
            this.pictureBox3.Location = new System.Drawing.Point(178, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(135, 92);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 353);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LogOut);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button course1;
        private System.Windows.Forms.Button course2;
        private System.Windows.Forms.Button course3;
        private System.Windows.Forms.Button course6;
        private System.Windows.Forms.Button course4;
        private System.Windows.Forms.Button course5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}