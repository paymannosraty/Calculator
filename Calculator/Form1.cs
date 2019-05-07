namespace Calculator
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		decimal numberA;
		decimal numberB;
		decimal resault;
		bool operatorPressed = false;
		string operatorKey = "";

		public Form1()
		{
			InitializeComponent();
		}
		// power function
		public int Pow(int a, int b)
		{
			int resault = 0;
			for (int index = 0; index < b - 1; index++)
			{
				resault *= a;
			}
			return resault;
		}
		// when click on 0-9 button
		private void NumberButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Button currentButton = (System.Windows.Forms.Button)sender;
			// for refusing 000
			if (monitorTextBox.Text == "0")
			{
				monitorTextBox.Clear();
			}
			monitorTextBox.Text = monitorTextBox.Text + currentButton.Text;
		}
		// just clear the monitor
		private void ClearMonitorButton_Click(object sender, System.EventArgs e)
		{
			monitorTextBox.Text = "0";
		}

		// choosing and set the operator
		private void OperatorButton_Click(object sender, System.EventArgs e)
		{
			
			numberA = System.Convert.ToDecimal(monitorTextBox.Text);
			System.Windows.Forms.Button currentButton = (System.Windows.Forms.Button)sender;

			operatorPressed = true;

			operatorKey = currentButton.Text;

			monitorTextBox.Clear();

		}

		// press the equal button
		private void EqualButton_Click(object sender, System.EventArgs e)
		{
			if (operatorPressed is true)
			{
				
				numberB = System.Convert.ToDecimal(monitorTextBox.Text);

				switch (operatorKey)
				{
					case "+":
					resault = numberA + numberB;
					monitorTextBox.Text = resault.ToString();
					break;

					case "-":
					resault = numberA - numberB;
					monitorTextBox.Text = resault.ToString();
					break;

					case "x":
					resault = numberA * numberB;
					monitorTextBox.Text = resault.ToString();
					break;

					case "/":
					resault = numberA / numberB;
					monitorTextBox.Text = resault.ToString();
					break;

					/*case "^":
					resault = pow((numberA,numberB);
					monitorTextBox.Text = resault.ToString();
					break;*/
				}
				operatorPressed = false;
			}
		}
	}
}
