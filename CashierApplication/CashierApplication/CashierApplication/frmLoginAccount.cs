using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{

    public partial class frmLoginAccount : Form
    {
        private Cashier cashier;
        private Cashier cashier2;
        public frmLoginAccount()
        {
            InitializeComponent();

            textBox2.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cashier = new Cashier("Genesis Oswell", "BSCS", "CEOGenesis", "ReynoldSuperGod");
            cashier2 = new Cashier("Reynold Ardena", "BSCS", "CEOReynold", "OswellGodKing");

            string username = textBox1.Text; string pass = textBox2.Text;

            if (cashier.ValidateLogin(username, pass))
            {
                MessageBox.Show($"Welcome, boss {cashier.getFullName()} of {cashier.getDepartment()} course!");

                Form1 cash = new Form1(cashier);
                cash.Show();

                this.Hide();
            }
            else if (cashier2.ValidateLogin(username, pass))
            {
                MessageBox.Show($"Welcome, boss {cashier2.getFullName()} of {cashier2.getDepartment()} course!");

                Form1 cash = new Form1(cashier2);
                cash.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void accsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"1st: Username: CEOGenesis||Password: ReynoldSuperGod");
            MessageBox.Show($"2nd: Username: CEOReynold||Password: OswellGodKing");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
