namespace PracticeCast1
{
    public partial class Casting : Form
    {
        public Casting()
        {
            InitializeComponent();
        }

        private void IntToDouble_Click(object sender, EventArgs e)
        {
            int num = 10;
            double decimalNum = num;
            MessageBox.Show(decimalNum.ToString());
        }
    }
}