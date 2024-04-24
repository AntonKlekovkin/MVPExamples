namespace TemperatureConverter
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
            tbCelsius = new TextBox();
            tbFarenheit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // tbCelsius
            // 
            tbCelsius.Location = new Point(12, 37);
            tbCelsius.Name = "tbCelsius";
            tbCelsius.Size = new Size(100, 23);
            tbCelsius.TabIndex = 1;
            tbCelsius.TextChanged += tbCelsius_TextChanged;
            // 
            // tbFarenheit
            // 
            tbFarenheit.Location = new Point(146, 37);
            tbFarenheit.Name = "tbFarenheit";
            tbFarenheit.Size = new Size(100, 23);
            tbFarenheit.TabIndex = 2;
            tbFarenheit.TextChanged += tbFarenheit_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 19);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Celcius";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 19);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Farenheit";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 81);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(234, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 110);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(234, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 154);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbFarenheit);
            Controls.Add(tbCelsius);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbCelsius;
        private TextBox tbFarenheit;
        private Label label1;
        private Label label2;
        private Button btnClear;
        private Button btnExit;
    }
}
