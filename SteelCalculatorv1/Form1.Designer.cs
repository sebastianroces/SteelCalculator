namespace SteelCalculatorv1
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
            this.calendarDateDue = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calendarEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRentAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDaysBetween = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRentOwed = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarDateDue
            // 
            this.calendarDateDue.Location = new System.Drawing.Point(45, 174);
            this.calendarDateDue.Name = "calendarDateDue";
            this.calendarDateDue.Size = new System.Drawing.Size(200, 20);
            this.calendarDateDue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Date Due";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 114);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Date";
            // 
            // calendarEndDate
            // 
            this.calendarEndDate.Location = new System.Drawing.Point(43, 231);
            this.calendarEndDate.Name = "calendarEndDate";
            this.calendarEndDate.Size = new System.Drawing.Size(200, 20);
            this.calendarEndDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rent/Price per day (Format: XX.xx)";
            // 
            // txtRentAmount
            // 
            this.txtRentAmount.Location = new System.Drawing.Point(437, 190);
            this.txtRentAmount.Name = "txtRentAmount";
            this.txtRentAmount.Size = new System.Drawing.Size(78, 20);
            this.txtRentAmount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Days between beginning and end";
            // 
            // txtDaysBetween
            // 
            this.txtDaysBetween.Location = new System.Drawing.Point(424, 247);
            this.txtDaysBetween.Name = "txtDaysBetween";
            this.txtDaysBetween.Size = new System.Drawing.Size(100, 20);
            this.txtDaysBetween.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Amount of rent owed";
            // 
            // txtRentOwed
            // 
            this.txtRentOwed.Location = new System.Drawing.Point(268, 330);
            this.txtRentOwed.Name = "txtRentOwed";
            this.txtRentOwed.Size = new System.Drawing.Size(100, 20);
            this.txtRentOwed.TabIndex = 12;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(99, 375);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(443, 59);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 470);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtRentOwed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDaysBetween);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRentAmount);
            this.Controls.Add(this.calendarEndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calendarDateDue);
            this.Name = "Form1";
            this.Text = "Steel Calculator version 1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker calendarDateDue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker calendarEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRentAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDaysBetween;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRentOwed;
        private System.Windows.Forms.Button btnCalculate;
    }
}

