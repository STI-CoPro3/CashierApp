using UserAccountNamespace;
namespace CashierApplication
{
    public partial class Form1 : Form
    {
        private Cashier cashier;
        public Form1(Cashier cashier)
        {
            InitializeComponent();
            this.cashier = cashier;

            LoginAs.Text = ($"Logged in as {cashier.getFullName()}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = textBox1.Text;
                double price = Convert.ToDouble(textBox2.Text);
                double discount = Convert.ToDouble(textBox4.Text);
                int quantity = Convert.ToInt32(textBox3.Text);

                DiscountedItem discountedItem = new DiscountedItem(itemName, price, quantity, discount);

                double totalAmount = discountedItem.getTotalPrice();

                label5.Text = $"Total Amount: {totalAmount.ToString()}";
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = textBox1.Text;
                double price = Convert.ToDouble(textBox2.Text);
                double discount = Convert.ToDouble(textBox4.Text);
                int quantity = Convert.ToInt32(textBox3.Text);
                double payment = Convert.ToDouble(textBox5.Text);

                DiscountedItem discountedItem = new DiscountedItem(itemName, price, quantity, discount);

                discountedItem.setPayment(payment);
                double change = discountedItem.getChange();

                label7.Text = $"Total Change: {change.ToString()}";
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginAccount loginForm = new frmLoginAccount();
            loginForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            
        }
    }
}
