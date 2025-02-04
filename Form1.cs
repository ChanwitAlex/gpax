namespace gpax
{
    public partial class Form1 : Form
    {
        GPACalculator GPACalculator;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            if (double.TryParse(this.tblnputGPAx.Text, out double input))
            {
                if (input >= 0.00 && input <= 4.00)
                {
                    this.tbGPAx.Text = GPACalculator.getGPAX().ToString();
                    this.tbGPAmax.Text = GPACalculator.getGPAX().ToString();
                    this.tbGPAmin.Text = GPACalculator.getGPAX().ToString();

                    this.tblnputGPAx.Text = GPACalculator.getGPAX().ToString();
                }
                else
                {
                    MessageBox.Show("??????????? GPA ???????? 0.00 - 4.00");
                    this.tblnputGPAx.Clear();
                }
            }
            else
            {
                MessageBox.Show("????????????????????????????????");
                this.tblnputGPAx.Clear();
            }   
        }
    }
}
