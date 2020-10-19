using System;
using System.Windows.Forms;
using EventAggregatorExampleEvents;
using EventAggregatorLibrary;

namespace EventAggregatorExampleApp
{
	public sealed class NotificationSubscriber : Singleton<NotificationSubscriber>
	{
		public event Action<string> NotificationPublished;

		public NotificationSubscriber()
		{
			EventAggregator
				.Instance
				.Get<NotificationEvent>()
				.Subscribe(NotificationHandler);
		}

		void NotificationHandler(string message)
		{
			if (Application.OpenForms.Count < 1)
				return;

			Application.OpenForms[0].Invoke(new Action(() =>
				NotificationPublished?.Invoke(message)));
		}
	}
}
