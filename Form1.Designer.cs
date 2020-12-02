namespace _1_uygulama
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
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.blogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmassege = new System.Windows.Forms.Label();
            this.cbremember = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(246, 145);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(405, 31);
            this.tbemail.TabIndex = 0;
            this.tbemail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(246, 182);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(405, 31);
            this.tbpassword.TabIndex = 1;
            this.tbpassword.UseSystemPasswordChar = true;
            this.tbpassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // blogin
            // 
            this.blogin.BackColor = System.Drawing.Color.PeachPuff;
            this.blogin.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blogin.ForeColor = System.Drawing.Color.Peru;
            this.blogin.Location = new System.Drawing.Point(491, 279);
            this.blogin.Name = "blogin";
            this.blogin.Size = new System.Drawing.Size(126, 47);
            this.blogin.TabIndex = 2;
            this.blogin.Text = "log in ";
            this.blogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.blogin.UseVisualStyleBackColor = false;
            this.blogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(143, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Ivory;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(109, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chocolate;
            this.label3.Location = new System.Drawing.Point(234, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 69);
            this.label3.TabIndex = 5;
            this.label3.Text = "Log In Here !";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblmassege
            // 
            this.lblmassege.AutoSize = true;
            this.lblmassege.Location = new System.Drawing.Point(246, 116);
            this.lblmassege.Name = "lblmassege";
            this.lblmassege.Size = new System.Drawing.Size(0, 24);
            this.lblmassege.TabIndex = 6;
            this.lblmassege.Click += new System.EventHandler(this.lblmassege_Click);
            // 
            // cbremember
            // 
            this.cbremember.AutoSize = true;
            this.cbremember.ForeColor = System.Drawing.Color.Peru;
            this.cbremember.Location = new System.Drawing.Point(246, 219);
            this.cbremember.Name = "cbremember";
            this.cbremember.Size = new System.Drawing.Size(169, 28);
            this.cbremember.TabIndex = 7;
            this.cbremember.Text = "remember me !";
            this.cbremember.UseVisualStyleBackColor = true;
            this.cbremember.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(655, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(655, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "*";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // bclear
            // 
            this.bclear.BackColor = System.Drawing.Color.PeachPuff;
            this.bclear.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bclear.ForeColor = System.Drawing.Color.Peru;
            this.bclear.Location = new System.Drawing.Point(623, 279);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(133, 47);
            this.bclear.TabIndex = 11;
            this.bclear.Text = "clear";
            this.bclear.UseVisualStyleBackColor = false;
            this.bclear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(782, 353);
            this.Controls.Add(this.bclear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbremember);
            this.Controls.Add(this.lblmassege);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.blogin);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.tbemail);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "log in ";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Button blogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmassege;
        private System.Windows.Forms.CheckBox cbremember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bclear;
    }
}

