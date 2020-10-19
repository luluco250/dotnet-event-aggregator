using System;
using System.Threading;
using System.Threading.Tasks;
using EventAggregatorExampleEvents;
using EventAggregatorLibrary;

namespace EventAggregatorExampleCore
{
    public class ExampleWorker : Singleton<ExampleWorker>
    {
		readonly NotificationEvent _notificationEvent;

	    public ExampleWorker()
	    {
		    _notificationEvent = EventAggregator.Instance.Get<NotificationEvent>();
	    }

	    public async Task DoWorkAsync()
	    {
		    await Task.Run(() =>
		    {
				var random = new Random();

				_notificationEvent.Publish("Starting work...");

				for (var i = 0; i < 3; ++i)
				{
					Thread.Sleep(random.Next(2000));
					_notificationEvent.Publish($"Step #{i + 1} finished.");
				}

				_notificationEvent.Publish("Work finished!");
		    });
	    }
    }
}
