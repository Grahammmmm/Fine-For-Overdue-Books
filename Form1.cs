using System.Drawing.Text;

namespace Fine_For_Overdue_Books
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

                int books = Convert.ToInt32(textBox1.Text);
                int days = Convert.ToInt32(textBox2.Text);
                double charge = DisplayLibraryFine(books, days);
                label3.Text = string.Format("My charge is {0}", charge.ToString("C"));

             static double DisplayLibraryFine(int books, int days)
            {
                double charge;
                if (days >= 7)
                {
                    charge = books * days * .2;
                }
                else
                {
                    charge = books * days * .1;
                }
                return charge;
            }

        }
        
    }
}
