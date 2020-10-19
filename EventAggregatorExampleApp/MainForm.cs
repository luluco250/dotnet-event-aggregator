using System;
using System.Windows.Forms;
using EventAggregatorExampleCore;
using EventAggregatorExampleEvents;
using EventAggregatorLibrary;

namespace EventAggregatorExampleApp
{
	public sealed partial class MainForm : Form
	{
		readonly NotificationEvent _notificationEvent;

		public MainForm()
		{
			_notificationEvent = EventAggregator
				.Instance
				.Get<NotificationEvent>();

			InitializeComponent();
			SetupEvents();
		}

		void SetupEvents()
		{
			_notificationEvent.Subscribe(NotificationHandler);
			
			_helloWorldButton.Click += HelloWorldButtonOnClick;
			_doWorkButton.Click += DoWorkButtonOnClick;
		}

		void NotificationHandler(string message)
		{
			Invoke(new Action(() => _notificationLog.Log(message)));
		}

		void HelloWorldButtonOnClick(object sender, EventArgs e)
		{
			_notificationEvent.Publish("Hello World!");
		}

		static async void DoWorkButtonOnClick(object sender, EventArgs e)
		{
			await ExampleWorker.Instance.DoWorkAsync();
		}
	}
}
