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
            int num1, num2, result=0;
            try
            {
                num1 = Int32.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                textBox1.Text = "FORMAT1 ERROR";
                return;
            }
            try
            {
                num2 = Int32.Parse(textBox2.Text);
            }
            catch (FormatException)
            {
                textBox1.Text = "FORMAT2 ERROR";
                return;
            }
            catch (DivideByZeroException)
            {
                textBox1.Text = "DIV ZERO";
                return;
            }
          


            textBox1.Text = "result = " + result.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            doSomething();
        }
    }
}
