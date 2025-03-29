namespace WinFormsApp2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            int num = 0;
            label2.Text += num.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int num = 1;
            label2.Text += num.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int num = 2;
            label2.Text += num.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int num = 3;
            label2.Text += num.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int num = 4;
            label2.Text += num.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int num = 5;
            label2.Text += num.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int num = 6;
            label2.Text += num.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int num = 7;
            label2.Text += num.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            int num = 8;
            int somma = 0;
           
            label2.Text += num.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {

            int num = 9;
            int somma = 0;
          
            label2.Text += num.ToString();
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            string ope = "+";
            label2.Text += ope;
        }

        private void btnUguale_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMeno_Click(object sender, EventArgs e)
        {
            string ope = "-";
            label2.Text += ope;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            label2.Text = "";
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            string ope = "x";
            label2.Text += ope;
        }

       
    }
}
