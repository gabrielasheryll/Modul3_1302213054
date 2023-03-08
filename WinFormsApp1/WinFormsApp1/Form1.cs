namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numb;
        int sum;

        private void button26_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "1";
        }

        private void angka2_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "2";
        }

        private void angka3_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "3";
        }

        private void angka4_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "4";
        }

        private void angka5_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "5";
        }

        private void angka6_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "6";
        }

        private void angka7_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "7";
        }

        private void angka8_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "8";
        }

        private void angka9_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "9";
        }

        private void angka0_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            numb = int.Parse(label2.Text);
            label2.Text = label2.Text + "+";
            label2.Text = "";
        }

        private void samadengan_Click(object sender, EventArgs e)
        {
            sum = numb + int.Parse(label2.Text);
            label2.Text = sum.ToString();
        }
    }
}