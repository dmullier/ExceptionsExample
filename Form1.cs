namespace ExceptionsExample
{
    /// <summary>
    /// Exception handling example
    /// The original commit has no exceptions handled, so look back at that to see the additions.  
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void doSomething()
        {
            int num1, num2, result;
            try
            {
                num1 = Int32.Parse(textBox1.Text);
                num2 = Int32.Parse(textBox2.Text);
            }
            catch (FormatException)
            {
                textBox1.Text = "Input format is incorrect. Please enter valid integers.";
                return;
            }
           
            result = num1 / num2;

            textBox1.Text = "result = " + result.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            doSomething();
        }
    }
}
