namespace euhdw
{
    partial class DataShowTForm
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
            this.dataGridViewCabin = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCabin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCabin
            // 
            this.dataGridViewCabin.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewCabin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCabin.Location = new System.Drawing.Point(241, 4);
            this.dataGridViewCabin.Name = "dataGridViewCabin";
            this.dataGridViewCabin.RowHeadersWidth = 62;
            this.dataGridViewCabin.RowTemplate.Height = 28;
            this.dataGridViewCabin.Size = new System.Drawing.Size(849, 669);
            this.dataGridViewCabin.TabIndex = 0;
            this.dataGridViewCabin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCabin_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSalmon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSalmon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(104, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Sign Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // DataShowTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1102, 685);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewCabin);
            this.Name = "DataShowTForm";
            this.Text = "DataShowTForm";
            this.Load += new System.EventHandler(this.DataShowTForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCabin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCabin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}