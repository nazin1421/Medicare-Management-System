namespace euhdw
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserame = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCreateAC = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 119);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(859, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            this.label3.MouseEnter += new System.EventHandler(this.Label3_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.Label3_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Login";
            // 
            // textBoxUserame
            // 
            this.textBoxUserame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserame.Location = new System.Drawing.Point(342, 171);
            this.textBoxUserame.Multiline = true;
            this.textBoxUserame.Name = "textBoxUserame";
            this.textBoxUserame.Size = new System.Drawing.Size(374, 46);
            this.textBoxUserame.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(342, 271);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(374, 39);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(100, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Name";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable3.Location = new System.Drawing.Point(100, 271);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(204, 46);
            this.lable3.TabIndex = 7;
            this.lable3.Text = "Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Aqua;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(516, 370);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(200, 62);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.Button1_Click);
            // 
            // buttonCreateAC
            // 
            this.buttonCreateAC.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonCreateAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAC.Location = new System.Drawing.Point(28, 370);
            this.buttonCreateAC.Name = "buttonCreateAC";
            this.buttonCreateAC.Size = new System.Drawing.Size(212, 62);
            this.buttonCreateAC.TabIndex = 9;
            this.buttonCreateAC.Text = "Create Account";
            this.buttonCreateAC.UseVisualStyleBackColor = false;
            this.buttonCreateAC.Click += new System.EventHandler(this.ButtonCreateAC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(890, 543);
            this.Controls.Add(this.buttonCreateAC);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.lable3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserame);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserame;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreateAC;
    }
}

