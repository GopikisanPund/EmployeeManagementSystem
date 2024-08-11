using System;

namespace EmployeeManagementSystem
{
    partial class SignUp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.NumFiled = new System.Windows.Forms.NumericUpDown();
            this.txtrpass = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.Lable_7 = new System.Windows.Forms.Label();
            this.lable_6 = new System.Windows.Forms.Label();
            this.Lable_5 = new System.Windows.Forms.Label();
            this.lable_4 = new System.Windows.Forms.Label();
            this.lable_3 = new System.Windows.Forms.Label();
            this.lable_1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFiled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnreset);
            this.groupBox1.Controls.Add(this.btnsubmit);
            this.groupBox1.Controls.Add(this.NumFiled);
            this.groupBox1.Controls.Add(this.txtrpass);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.Lable_7);
            this.groupBox1.Controls.Add(this.lable_6);
            this.groupBox1.Controls.Add(this.Lable_5);
            this.groupBox1.Controls.Add(this.lable_4);
            this.groupBox1.Controls.Add(this.lable_3);
            this.groupBox1.Controls.Add(this.lable_1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Black;
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreset.Location = new System.Drawing.Point(229, 417);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 37);
            this.btnreset.TabIndex = 8;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Black;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsubmit.Location = new System.Drawing.Point(108, 417);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 37);
            this.btnsubmit.TabIndex = 7;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // NumFiled
            // 
            this.NumFiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumFiled.Location = new System.Drawing.Point(23, 184);
            this.NumFiled.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NumFiled.Name = "NumFiled";
            this.NumFiled.Size = new System.Drawing.Size(281, 24);
            this.NumFiled.TabIndex = 3;
            this.NumFiled.ValueChanged += new System.EventHandler(this.NumFiled_ValueChanged);
            this.NumFiled.Leave += new System.EventHandler(this.NumFiled_Leave);
            // 
            // txtrpass
            // 
            this.txtrpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrpass.Location = new System.Drawing.Point(20, 369);
            this.txtrpass.Name = "txtrpass";
            this.txtrpass.Size = new System.Drawing.Size(284, 24);
            this.txtrpass.TabIndex = 6;
            this.txtrpass.UseSystemPasswordChar = true;
            this.txtrpass.Leave += new System.EventHandler(this.txtrpass_Leave);
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(20, 311);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(284, 24);
            this.txtpass.TabIndex = 5;
            this.txtpass.UseSystemPasswordChar = true;
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(20, 244);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(284, 24);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(20, 125);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(284, 24);
            this.txtName.TabIndex = 2;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(20, 67);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(284, 24);
            this.txtID.TabIndex = 0;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // Lable_7
            // 
            this.Lable_7.AutoSize = true;
            this.Lable_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lable_7.Location = new System.Drawing.Point(20, 353);
            this.Lable_7.Name = "Lable_7";
            this.Lable_7.Size = new System.Drawing.Size(104, 15);
            this.Lable_7.TabIndex = 6;
            this.Lable_7.Text = "ConfirmPassword";
            // 
            // lable_6
            // 
            this.lable_6.AutoSize = true;
            this.lable_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lable_6.Location = new System.Drawing.Point(20, 295);
            this.lable_6.Name = "lable_6";
            this.lable_6.Size = new System.Drawing.Size(61, 15);
            this.lable_6.TabIndex = 5;
            this.lable_6.Text = "Password";
            // 
            // Lable_5
            // 
            this.Lable_5.AutoSize = true;
            this.Lable_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Lable_5.Location = new System.Drawing.Point(20, 228);
            this.Lable_5.Name = "Lable_5";
            this.Lable_5.Size = new System.Drawing.Size(39, 15);
            this.Lable_5.TabIndex = 4;
            this.Lable_5.Text = "Email";
            // 
            // lable_4
            // 
            this.lable_4.AutoSize = true;
            this.lable_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lable_4.Location = new System.Drawing.Point(20, 167);
            this.lable_4.Name = "lable_4";
            this.lable_4.Size = new System.Drawing.Size(37, 15);
            this.lable_4.TabIndex = 3;
            this.lable_4.Text = "Class";
            // 
            // lable_3
            // 
            this.lable_3.AutoSize = true;
            this.lable_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lable_3.Location = new System.Drawing.Point(17, 108);
            this.lable_3.Name = "lable_3";
            this.lable_3.Size = new System.Drawing.Size(41, 15);
            this.lable_3.TabIndex = 2;
            this.lable_3.Text = "Name";
            // 
            // lable_1
            // 
            this.lable_1.AutoSize = true;
            this.lable_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lable_1.Location = new System.Drawing.Point(20, 51);
            this.lable_1.Name = "lable_1";
            this.lable_1.Size = new System.Drawing.Size(19, 15);
            this.lable_1.TabIndex = 1;
            this.lable_1.Text = "ID";
            this.lable_1.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(115, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(405, 499);
            this.Controls.Add(this.groupBox1);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumFiled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);

        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtrpass;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label Lable_7;
        private System.Windows.Forms.Label lable_6;
        private System.Windows.Forms.Label Lable_5;
        private System.Windows.Forms.Label lable_4;
        private System.Windows.Forms.Label lable_3;
        private System.Windows.Forms.Label lable_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.NumericUpDown NumFiled;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
    }
}