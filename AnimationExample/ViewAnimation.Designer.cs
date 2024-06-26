﻿namespace AnimationExample
{
    partial class ViewAnimation
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
            components = new System.ComponentModel.Container();
            btnStep = new Button();
            pbField = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbField).BeginInit();
            SuspendLayout();
            // 
            // btnStep
            // 
            btnStep.Location = new Point(12, 12);
            btnStep.Name = "btnStep";
            btnStep.Size = new Size(75, 23);
            btnStep.TabIndex = 0;
            btnStep.Text = "Step";
            btnStep.UseVisualStyleBackColor = true;
            btnStep.Click += btnStep_Click;
            // 
            // pbField
            // 
            pbField.BackColor = Color.White;
            pbField.Location = new Point(12, 41);
            pbField.Name = "pbField";
            pbField.Size = new Size(100, 50);
            pbField.TabIndex = 1;
            pbField.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // ViewAnimation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(pbField);
            Controls.Add(btnStep);
            Name = "ViewAnimation";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbField).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStep;
        private PictureBox pbField;
        private System.Windows.Forms.Timer timer1;
    }
}
