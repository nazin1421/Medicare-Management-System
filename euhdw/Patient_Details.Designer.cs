namespace euhdw
{
    partial class Patient_Details
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
            this.BTN_SEARCH_Click = new System.Windows.Forms.Button();
            this.dataGridViewPatient = new System.Windows.Forms.DataGridView();
            this.textBoxValueToSearch = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_SEARCH_Click
            // 
            this.BTN_SEARCH_Click.BackColor = System.Drawing.Color.GreenYellow;
            this.BTN_SEARCH_Click.Location = new System.Drawing.Point(514, 7);
            this.BTN_SEARCH_Click.Name = "BTN_SEARCH_Click";
            this.BTN_SEARCH_Click.Size = new System.Drawing.Size(119, 51);
            this.BTN_SEARCH_Click.TabIndex = 0;
            this.BTN_SEARCH_Click.Text = "Search";
            this.BTN_SEARCH_Click.UseVisualStyleBackColor = false;
            this.BTN_SEARCH_Click.Click += new System.EventHandler(this.BTN_SEARCH_Click_Click);
            // 
            // dataGridViewPatient
            // 
            this.dataGridViewPatient.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatient.Location = new System.Drawing.Point(3, 64);
            this.dataGridViewPatient.Name = "dataGridViewPatient";
            this.dataGridViewPatient.RowHeadersWidth = 62;
            this.dataGridViewPatient.RowTemplate.Height = 28;
            this.dataGridViewPatient.Size = new System.Drawing.Size(1189, 423);
            this.dataGridViewPatient.TabIndex = 1;
            // 
            // textBoxValueToSearch
            // 
            this.textBoxValueToSearch.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValueToSearch.Location = new System.Drawing.Point(294, 12);
            this.textBoxValueToSearch.Multiline = true;
            this.textBoxValueToSearch.Name = "textBoxValueToSearch";
            this.textBoxValueToSearch.Size = new System.Drawing.Size(200, 46);
            this.textBoxValueToSearch.TabIndex = 36;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonBack.Location = new System.Drawing.Point(1066, 7);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(119, 51);
            this.buttonBack.TabIndex = 37;
            this.buttonBack.Text = "Home";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "Enter the cabin NO:";
            // 
            // Patient_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 710);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxValueToSearch);
            this.Controls.Add(this.dataGridViewPatient);
            this.Controls.Add(this.BTN_SEARCH_Click);
            this.Name = "Patient_Details";
            this.Text = "Patient_Details";
            this.Load += new System.EventHandler(this.Patient_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_SEARCH_Click;
        private System.Windows.Forms.DataGridView dataGridViewPatient;
        private System.Windows.Forms.TextBox textBoxValueToSearch;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label2;
    }
}