namespace DatesWork
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPay = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownWorkWeek = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkWeek)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.Location = new System.Drawing.Point(131, 25);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBegin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Begin";
            // 
            // numericUpDownPay
            // 
            this.numericUpDownPay.Location = new System.Drawing.Point(131, 113);
            this.numericUpDownPay.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownPay.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            -2147483648});
            this.numericUpDownPay.Name = "numericUpDownPay";
            this.numericUpDownPay.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownPay.TabIndex = 8;
            this.numericUpDownPay.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Days After End";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Week Length";
            // 
            // numericUpDownWorkWeek
            // 
            this.numericUpDownWorkWeek.Location = new System.Drawing.Point(131, 77);
            this.numericUpDownWorkWeek.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numericUpDownWorkWeek.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownWorkWeek.Name = "numericUpDownWorkWeek";
            this.numericUpDownWorkWeek.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownWorkWeek.TabIndex = 10;
            this.numericUpDownWorkWeek.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(357, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(339, 449);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(36, 157);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Add Payday Month Count";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 479);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownWorkWeek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerBegin);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Work Week Pay Period";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkWeek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownWorkWeek;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

