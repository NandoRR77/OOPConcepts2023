namespace OOPConcepts.UserImterface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtYear = new TextBox();
            txtMonth = new TextBox();
            txtDay = new TextBox();
            btnValidate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 74);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Year:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 120);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Month:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 162);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 2;
            label3.Text = "Day:";
            // 
            // txtYear
            // 
            txtYear.Location = new Point(99, 71);
            txtYear.Name = "txtYear";
            txtYear.PlaceholderText = "Enter the year";
            txtYear.Size = new Size(138, 23);
            txtYear.TabIndex = 3;
            // 
            // txtMonth
            // 
            txtMonth.Location = new Point(99, 117);
            txtMonth.Name = "txtMonth";
            txtMonth.PlaceholderText = "Enter the month";
            txtMonth.Size = new Size(138, 23);
            txtMonth.TabIndex = 4;
            // 
            // txtDay
            // 
            txtDay.Location = new Point(99, 159);
            txtDay.Name = "txtDay";
            txtDay.PlaceholderText = "Enter the day";
            txtDay.Size = new Size(138, 23);
            txtDay.TabIndex = 5;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(99, 210);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(138, 23);
            btnValidate.TabIndex = 6;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 297);
            Controls.Add(btnValidate);
            Controls.Add(txtDay);
            Controls.Add(txtMonth);
            Controls.Add(txtYear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Date Validator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtYear;
        private TextBox txtMonth;
        private TextBox txtDay;
        private Button btnValidate;
    }
}