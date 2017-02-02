namespace AttSystem
{
    partial class Form4
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
            this.viewBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.addText = new System.Windows.Forms.TextBox();
            this.dltButton = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.stuBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sesBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.ComboBox();
            this.attLogBtn = new System.Windows.Forms.Button();
            this.wekBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stuBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewBtn
            // 
            this.viewBtn.Location = new System.Drawing.Point(172, 315);
            this.viewBtn.Name = "viewBtn";
            this.viewBtn.Size = new System.Drawing.Size(75, 23);
            this.viewBtn.TabIndex = 22;
            this.viewBtn.Text = "View";
            this.viewBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(281, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Controls.Add(this.addText);
            this.groupBox1.Location = new System.Drawing.Point(290, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 71);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add a new student";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(21, 42);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add Student";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // addText
            // 
            this.addText.Location = new System.Drawing.Point(6, 19);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(105, 20);
            this.addText.TabIndex = 7;
            // 
            // dltButton
            // 
            this.dltButton.Location = new System.Drawing.Point(425, 91);
            this.dltButton.Name = "dltButton";
            this.dltButton.Size = new System.Drawing.Size(96, 23);
            this.dltButton.TabIndex = 18;
            this.dltButton.Text = "Delete Student";
            this.dltButton.UseVisualStyleBackColor = true;
            this.dltButton.Click += new System.EventHandler(this.dltButton_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(23, 315);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "Go Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // stuBox2
            // 
            this.stuBox2.FormattingEnabled = true;
            this.stuBox2.Location = new System.Drawing.Point(414, 67);
            this.stuBox2.Name = "stuBox2";
            this.stuBox2.Size = new System.Drawing.Size(121, 21);
            this.stuBox2.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.sesBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.codeBox);
            this.groupBox2.Controls.Add(this.attLogBtn);
            this.groupBox2.Controls.Add(this.wekBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.stuBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 190);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Please select a session";
            // 
            // sesBox
            // 
            this.sesBox.FormattingEnabled = true;
            this.sesBox.Location = new System.Drawing.Point(125, 89);
            this.sesBox.Name = "sesBox";
            this.sesBox.Size = new System.Drawing.Size(121, 21);
            this.sesBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Present/Absent";
            // 
            // codeBox
            // 
            this.codeBox.FormattingEnabled = true;
            this.codeBox.Location = new System.Drawing.Point(125, 122);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(121, 21);
            this.codeBox.TabIndex = 11;
            // 
            // attLogBtn
            // 
            this.attLogBtn.Location = new System.Drawing.Point(114, 161);
            this.attLogBtn.Name = "attLogBtn";
            this.attLogBtn.Size = new System.Drawing.Size(123, 23);
            this.attLogBtn.TabIndex = 4;
            this.attLogBtn.Text = "Log Attendence";
            this.attLogBtn.UseVisualStyleBackColor = true;
            this.attLogBtn.Click += new System.EventHandler(this.attLogBtn_Click);
            // 
            // wekBox
            // 
            this.wekBox.FormattingEnabled = true;
            this.wekBox.Location = new System.Drawing.Point(125, 62);
            this.wekBox.Name = "wekBox";
            this.wekBox.Size = new System.Drawing.Size(121, 21);
            this.wekBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please select a week";
            // 
            // stuBox
            // 
            this.stuBox.FormattingEnabled = true;
            this.stuBox.Location = new System.Drawing.Point(125, 28);
            this.stuBox.Name = "stuBox";
            this.stuBox.Size = new System.Drawing.Size(121, 21);
            this.stuBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 390);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.stuBox2);
            this.Controls.Add(this.viewBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dltButton);
            this.Controls.Add(this.backBtn);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox addText;
        private System.Windows.Forms.Button dltButton;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ComboBox stuBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sesBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox codeBox;
        private System.Windows.Forms.Button attLogBtn;
        private System.Windows.Forms.ComboBox wekBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox stuBox;
        private System.Windows.Forms.Label label1;
    }
}