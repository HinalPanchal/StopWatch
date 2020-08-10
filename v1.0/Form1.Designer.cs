namespace v1._0
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
            this.components = new System.ComponentModel.Container();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblsec = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lblMicro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.Color.Red;
            this.lblHour.Location = new System.Drawing.Point(147, 87);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(78, 55);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "00";
            this.lblHour.Click += new System.EventHandler(this.lblHour_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.Red;
            this.lblMin.Location = new System.Drawing.Point(328, 87);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(78, 55);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "00";
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsec.ForeColor = System.Drawing.Color.Red;
            this.lblsec.Location = new System.Drawing.Point(492, 87);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(78, 55);
            this.lblsec.TabIndex = 3;
            this.lblsec.Text = "00";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(171, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(351, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "PAUSE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(538, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 44);
            this.button3.TabIndex = 6;
            this.button3.Text = "STOP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(252, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(434, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 55);
            this.label2.TabIndex = 8;
            this.label2.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(586, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 55);
            this.label3.TabIndex = 9;
            this.label3.Text = ":";
            // 
            // lblMicro
            // 
            this.lblMicro.AutoSize = true;
            this.lblMicro.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMicro.ForeColor = System.Drawing.Color.Red;
            this.lblMicro.Location = new System.Drawing.Point(629, 87);
            this.lblMicro.Name = "lblMicro";
            this.lblMicro.Size = new System.Drawing.Size(78, 55);
            this.lblMicro.TabIndex = 10;
            this.lblMicro.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "StopWatch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMicro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblsec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblHour);
            this.Name = "Form1";
            this.Text = "StopWatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMicro;
        private System.Windows.Forms.Label label4;
    }
}

