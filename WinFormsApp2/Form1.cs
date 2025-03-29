using System.CodeDom;

namespace WinFormsApp2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double n1 = 0, n2 = 0;
        public bool operatore = false;
        public int operaz = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
             if (operatore = true)
            {

                textBox1.Text = "" + 0;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 0;
            }

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            if (operatore = true)
            {

                textBox1.Text = "" + 1;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 1;
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (operatore = true)
            {

                textBox1.Text = "" + 2;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 2;
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (operatore = true)
            {

                textBox1.Text = "" + 3;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 3;
            }

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (operatore = true)
            {

                textBox1.Text = "" + 4;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 4;
            }

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (operatore = true)
            {

                textBox1.Text = "" + 5;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 5;
            }

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (operatore = true)
            {

                textBox1.Text = "" + 6;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 6;
            }

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (operatore = true)
            {

                textBox1.Text = "" + 7;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 7;
            }

        }

        private void btn8_Click(object sender, EventArgs e)
        {

            if (operatore = true)
            {

                textBox1.Text = "" + 8;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 8;
            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {

            if (operatore = true)
            {

                textBox1.Text = "" + 9;
                operatore = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + 9;
            }

        }

        private void btnplus_Click(object sender, EventArgs e)
        {

            if (n1 == 0)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(n1);
                operatore = true;
                operaz = 1;

            }
            else
            {
                n2 = Convert.ToDouble(textBox1.Text);
                n1 += n2;
                textBox1.Text = Convert.ToString(n1);
                operatore = true;
                operaz = 1;
            }
            n1 = Convert.ToDouble(textBox1.Text);
            n1 += n2;
            textBox1.Text = Convert.ToString(n1);




        }

        private void btnUguale_Click(object sender, EventArgs e)
        {
            switch (operaz)
            {
                case 1:
                    n2 = Convert.ToDouble(textBox1.Text);
                    n1 += n2;
                    textBox1.Text = Convert.ToString(n1);
                    n1 = 0;
                    n2 = 0;
                    operatore = true;break;
                    case 2:
                    n2 = Convert.ToDouble(textBox1.Text);
                    n1 -= n2;
                    textBox1.Text = Convert.ToString(n1);
                    n1 = 0;
                    n2 = 0;
                    operatore = true; break;
            }
         
       }


        private void btnMeno_Click(object sender, EventArgs e)
        {
            if (n1 == 0)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(n1);
                operatore = true;
                operaz = 2;

            }
            else
            {
                n2 = Convert.ToDouble(textBox1.Text);
                n1 -= n2;
                textBox1.Text = Convert.ToString(n1);
                operatore = true;
                operaz = 2;
            }
            n1 = Convert.ToDouble(textBox1.Text);
            n1 -= n2;
            textBox1.Text = Convert.ToString(n1);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            operatore = false;
            operaz = 0;
            textBox1.Text = "";
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

       
    }
}
