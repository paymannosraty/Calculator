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
			string monitorCurrentText = monitorListBox.;
			System.Windows.Forms.MessageBox.Show(monitorCurrentText);
			monitorListBox.Items.Add(currentButton.Text);
		}
	}
}
