using System;
using System.Collections.Concurrent;

namespace EventAggregatorLibrary
{
	public class EventAggregator : Singleton<EventAggregator>
	{
		readonly ConcurrentDictionary<Type, IEvent> _events
			= new ConcurrentDictionary<Type, IEvent>();

		public TEvent Get<TEvent>() where TEvent : IEvent, new()
		{
			var key = typeof(TEvent);

			if (_events.TryGetValue(key, out var ev))
				return (TEvent)ev;

			var newEvent = new TEvent();
			_events[key] = newEvent;

			return newEvent;
		}
	}
}
