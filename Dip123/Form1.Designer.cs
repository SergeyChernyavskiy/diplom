namespace Dip123
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
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(3, 115);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 46);
            this.button7.TabIndex = 10;
            this.button7.Text = "Пастила «Малиновая»";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(3, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Пастила «Клюквенная»";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(0, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 46);
            this.button3.TabIndex = 12;
            this.button3.Text = "Зефир «Сливочный»";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(3, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 46);
            this.button4.TabIndex = 13;
            this.button4.Text = "Зефир «Яблочный»";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(0, 421);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 42);
            this.button5.TabIndex = 14;
            this.button5.Text = "Зефир «Маршмеллоу»";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(0, 469);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(107, 46);
            this.button6.TabIndex = 15;
            this.button6.Text = "Зефир «В шоколаде»";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Location = new System.Drawing.Point(0, 320);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 43);
            this.button8.TabIndex = 16;
            this.button8.Text = "Зефир «Киевский»";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Location = new System.Drawing.Point(0, 369);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 46);
            this.button9.TabIndex = 17;
            this.button9.Text = "Зефир «Десертный»";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Welcome.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Welcome.Location = new System.Drawing.Point(3, 17);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(295, 24);
            this.Welcome.TabIndex = 18;
            this.Welcome.Text = "Выберите нужную продукцию";
            this.Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.Welcome);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 524);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(3, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Пастила «Двухслойная»";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 536);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

