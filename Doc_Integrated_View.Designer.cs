namespace Clinical
{
    partial class Doc_Integrated_View
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
            this.patp = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.patm = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // patp
            // 
            this.patp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patp.Location = new System.Drawing.Point(143, 143);
            this.patp.Name = "patp";
            this.patp.Size = new System.Drawing.Size(536, 210);
            this.patp.TabIndex = 196;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(162, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 197;
            this.label1.Text = "Patient ID";
            // 
            // patm
            // 
            this.patm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patm.Location = new System.Drawing.Point(143, 395);
            this.patm.Name = "patm";
            this.patm.Size = new System.Drawing.Size(536, 210);
            this.patm.TabIndex = 199;
            this.patm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patm_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "View Patient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 135);
            this.pictureBox1.TabIndex = 200;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(773, 608);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 203;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(246, 25);
            this.maskedTextBox2.Mask = "00000000000000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(152, 20);
            this.maskedTextBox2.TabIndex = 261;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(842, 534);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 262;
            this.button3.Text = "Lab Results";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(697, 534);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 34);
            this.button4.TabIndex = 263;
            this.button4.Text = "Xray View";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Doc_Integrated_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(32)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(966, 668);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.patm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.patp);
            this.Name = "Doc_Integrated_View";
            this.Text = "Doc_Integrated_View";
            this.Load += new System.EventHandler(this.Doc_Integrated_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView patp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView patm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}