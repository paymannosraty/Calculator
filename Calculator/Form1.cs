namespace Calculator
{
	public partial class Form1 : System.Windows.Forms.Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void NumberButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.Button currentButton = (System.Windows.Forms.Button)sender;
			if (monitorTextBox.Text == "0")
			{
				monitorTextBox.Clear();
			}
			monitorTextBox.Text = monitorTextBox.Text + currentButton.Text;
		}

		private void ClearMonitorButton_Click(object sender, System.EventArgs e)
		{
			monitorTextBox.Text = "0";
		}
	}
}
