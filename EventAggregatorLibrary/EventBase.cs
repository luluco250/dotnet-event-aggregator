using System;
using System.Collections.Generic;

namespace EventAggregatorLibrary
{
	/// <summary>
	/// Empty utility to describe an event that takes no parameters.
	/// </summary>
	public readonly struct Unit
	{
		/// <summary>
		/// Static readonly instance of <see cref="Unit"/>.
		/// </summary>
		public static readonly Unit Instance = new Unit();
	}

	/// <summary>
	/// Interface for aggregating both <see cref="EventBase"/> instances with
	/// arguments and without in collections.
	/// </summary>
	public interface IEvent
	{
		Type ParameterType { get; }
	}

	public static class EventExtensions
	{
		public static bool HasParameter(this IEvent e)
			=> e.ParameterType != typeof(Unit);
	}

	public abstract class EventBase<TParameter> : IEvent
	{
		protected virtual ICollection<Delegate> Subscribers { get; }
			= new HashSet<Delegate>();

		Type IEvent.ParameterType => typeof(TParameter);

		public void Subscribe(Action<TParameter> handler)
			=> Subscribe((Delegate)handler);

		public void Unsubscribe(Action<TParameter> handler)
			=> Unsubscribe((Delegate)handler);

		/// <summary>
		/// Goes through the subscriber collection and invokes each one with
		/// <paramref name="parameter"/> as the argument.
		/// </summary>
		public virtual void Publish(TParameter parameter)
		{
			foreach (var sub in Subscribers)
				InvokeSubscriber(sub, parameter);
		}

		/// <summary>
		/// Adds a subscriber handler to the subscriber collection.
		/// </summary>
		protected virtual void Subscribe(Delegate handler)
			=> Subscribers.Add(handler);

		/// <summary>
		/// Removes a subscriber handler to the subscriber collection.
		/// </summary>
		protected virtual void Unsubscribe(Delegate handler)
			=> Subscribers.Remove(handler);

		/// <summary>
		/// Invokes a subscriber handler.
		/// </summary>
		/// <remarks>
		/// This method is used to cast the subscriber delegate to an appropriate
		/// <see cref="Action"/> type, which may not have parameters in the case
		/// of non-generic <see cref="EventBase"/> subscribers.
		/// </remarks>
		protected virtual void InvokeSubscriber(Delegate subscriber, TParameter parameter)
			=> ((Action<TParameter>)subscriber)(parameter);
	}

	public abstract class EventBase : EventBase<Unit>, IEvent
	{
		Type IEvent.ParameterType => typeof(Unit);

		public void Subscribe(Action handler)
			=> Subscribe((Delegate)handler);

		public void Unsubscribe(Action handler)
			=> Unsubscribe((Delegate)handler);

		public void Publish()
			=> Publish(Unit.Instance);

		/// <summary>
		/// Invokes a subscriber handler.
		/// </summary>
		/// <remarks>
		/// Casts the subscriber to an <see cref="Action"/> and calls it,
		/// discarding the <see cref="Unit"/> argument.
		/// </remarks>
		protected override void InvokeSubscriber(Delegate subscriber, Unit _)
			=> ((Action)subscriber)();
	}
}
