using System;
using System.Windows.Forms;

namespace EventAggregatorExampleApp
{
	public partial class NotificationLogControl : UserControl
	{
		public NotificationLogControl()
		{
			InitializeComponent();
		}

		public void Log(string message)
		{
			// It shouldn't be necessary to use Environment.NewLine, but the
			// TextBox control seems to not add new lines without carriage return.
			_textBox.AppendText(message + Environment.NewLine);
		}
	}
}
