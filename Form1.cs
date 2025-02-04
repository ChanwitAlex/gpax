namespace gpax
{
    public partial class Form1 : Form
    {
        GPACalculator GPACalculator;
        public Form1()
        {
            InitializeComponent();
            GPACalculator = new GPACalculator();
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            
                try
                {
                    double input = double.Parse(this.tblnputGPAx.Text);
                    GPACalculator.setGPA(input);
                    UpdateUI();

                    this.tbGPAx.Text = GPACalculator.getGPAX().ToString("F2");
                    this.tbGPAmax.Text = GPACalculator.getMaxGPA().ToString("F2");
                    this.tbGPAmin.Text = GPACalculator.getMinGPA().ToString("F2");




                    this.tblnputGPAx.Text = string.Empty;
                }
                catch (Exception)
                {
                    MessageBox.Show("WRONG");
                    this.tblnputGPAx.Text = string.Empty;
                }

            
        }




        private void btclear_Click(object sender, EventArgs e)
        {
            this.tblnputGPAx.Text = string.Empty;
            this.tbGPAx.Text = string.Empty;
            this.tbGPAmax.Text = string.Empty;
            this.tbGPAmin.Text = string.Empty;
            UpdateUI();
        }




        private void UpdateUI()
        {
            this.tbGPAx.Text = GPACalculator.getGPAX().ToString("F2");
            this.tbGPAmax.Text = GPACalculator.getMaxGPA().ToString("F2");
            this.tbGPAmin.Text = GPACalculator.getMinGPA().ToString("F2");
            this.tbSTD.Text = GPACalculator.getStudentCount().ToString();
        }



    }
}

       