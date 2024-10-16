namespace CashierApplication
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            LoginAs = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 11.25F);
            textBox1.Location = new Point(12, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 25);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 11.25F);
            textBox2.Location = new Point(54, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 25);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 11.25F);
            textBox3.Location = new Point(356, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(59, 25);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 11.25F);
            textBox4.Location = new Point(297, 44);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(118, 25);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Times New Roman", 11.25F);
            textBox5.Location = new Point(135, 228);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(193, 25);
            textBox5.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 11.25F);
            button1.Location = new Point(334, 228);
            button1.Name = "button1";
            button1.Size = new Size(82, 23);
            button1.TabIndex = 5;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 11.25F);
            button2.Location = new Point(135, 137);
            button2.Name = "button2";
            button2.Size = new Size(82, 23);
            button2.TabIndex = 6;
            button2.Text = "Compute";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(82, 17);
            label1.TabIndex = 7;
            label1.Text = "Item Name: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F);
            label2.Location = new Point(297, 26);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 8;
            label2.Text = "Discount(%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F);
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 9;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F);
            label4.Location = new Point(297, 102);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 10;
            label4.Text = "Quantity:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F);
            label5.Location = new Point(135, 174);
            label5.Name = "label5";
            label5.Size = new Size(90, 17);
            label5.TabIndex = 11;
            label5.Text = "Total Amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11.25F);
            label6.Location = new Point(12, 231);
            label6.Name = "label6";
            label6.Size = new Size(126, 17);
            label6.TabIndex = 12;
            label6.Text = "Payment Recieved: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11.25F);
            label7.Location = new Point(135, 256);
            label7.Name = "label7";
            label7.Size = new Size(100, 17);
            label7.TabIndex = 13;
            label7.Text = "Total Change: 0";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlDark;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(428, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { logoutToolStripMenuItem, exitToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(112, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(112, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // LoginAs
            // 
            LoginAs.AutoSize = true;
            LoginAs.Font = new Font("Times New Roman", 11.25F);
            LoginAs.Location = new Point(12, 288);
            LoginAs.Name = "LoginAs";
            LoginAs.Size = new Size(0, 17);
            LoginAs.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(428, 314);
            Controls.Add(LoginAs);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "CashierApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label LoginAs;
    }
}
