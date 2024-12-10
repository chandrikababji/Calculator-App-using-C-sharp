using System;
using System.Windows.Forms;
using System.Data;
using System.Linq.Expressions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private double result = 0;
        private string operation = "";
        private bool isOperationClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // For numeric buttons
        {
            Button button = (Button)sender;

            if (isOperationClicked)
            {
                // When an operator is clicked, preserve the operation part and append the new number
                textBox2.Text = operation + button.Text;
                isOperationClicked = false; // Reset the flag to avoid appending number twice
            }
            else
            {
                // Append the number normally
                textBox2.Text += button.Text;
            }

            // Update the operation string
            operation = textBox2.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e) // +/- button
        {
            double currentValue = double.Parse(textBox2.Text);
            currentValue = -currentValue; // Toggle sign
            textBox2.Text = currentValue.ToString();
        }

        private void button13_Click(object sender, EventArgs e) // "=" Button
        {
            try
            {
                
                var result = new DataTable().Compute(operation, null);
                textBox1.Text = $" = {result}";
                operation = result.ToString(); 
            }
            catch (Exception)
            {
                // Handle invalid expression (e.g., division by zero, etc.)
                textBox1.Text = "Error";
                textBox2.Text = "Invalid Operation";
                operation = ""; // Reset Operation
            }
        }

        private void button17_Click(object sender, EventArgs e) // "Clear" Button
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            result = 0;
            operation = "";
        }

        private void button14_Click(object sender, EventArgs e) // "*" Button
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                operation = textBox2.Text + " * "; // Store the current value and operator
                textBox2.Text = operation; // Update display
                isOperationClicked = true; // Set flag to indicate that an operator was clicked
            }
        }

        private void button15_Click(object sender, EventArgs e) // "+" Button
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                operation = textBox2.Text + " + "; // Store the current value and operator
                textBox2.Text = operation; // Update display
                isOperationClicked = true; // Set flag to indicate that an operator was clicked
            }
        }

        private void button16_Click(object sender, EventArgs e) // "-" Button
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                operation = textBox2.Text + " - "; // Store the current value and operator
                textBox2.Text = operation; // Update display
                isOperationClicked = true; // Set flag to indicate that an operator was clicked
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        // Additional numeric buttons (other than button2) for 0-9
        private void button1_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }
    }
}






