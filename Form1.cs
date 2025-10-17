namespace ExceptionsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void doSomething()
        {
            int num1, num2, result;

            num1 = Int32.Parse(textBox1.Text);
            num2 = Int32.Parse(textBox2.Text);
            result = num1 / num2;

            textBox1.Text = "result = " + result.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            doSomething();
        }
    }
}
