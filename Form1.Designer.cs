namespace Clock
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("DS-Digital", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LawnGreen;
            label1.Location = new Point(46, 67);
            label1.Name = "label1";
            label1.Size = new Size(619, 118);
            label1.TabIndex = 0;
            label1.Text = "00:00:00:00";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 205, 151);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Tahoma", 15F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(61, 221);
            button1.Name = "button1";
            button1.Size = new Size(128, 57);
            button1.TabIndex = 1;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(247, 86, 91);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Tahoma", 15F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(291, 221);
            button2.Name = "button2";
            button2.Size = new Size(128, 57);
            button2.TabIndex = 1;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(25, 130, 196);
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Tahoma", 15F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(500, 221);
            button3.Name = "button3";
            button3.Size = new Size(128, 57);
            button3.TabIndex = 1;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 38, 48);
            ClientSize = new Size(707, 290);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
