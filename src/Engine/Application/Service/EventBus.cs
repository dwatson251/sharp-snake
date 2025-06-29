namespace Engine.Application.Service
{
    using IEvent = Engine.Domain.Entity;
    using System.Collections.Generic;
    using System;
    using System.Linq;

    public class EventBus
    {
        private readonly Dictionary<Type, List<Delegate>> _handlers;

        public void Subscribe<IEvent>(Action<IEvent> handler)
        {
            var eventType = typeof(IEvent);
            if (!_handlers.ContainsKey(eventType))
                _handlers[eventType] = new List<Delegate>();

            _handlers[eventType].Add(handler);
        }

        public void Publish<IEvent>(IEvent gameEvent)
        {
            var eventType = typeof(IEvent);
            if (_handlers.TryGetValue(eventType, out var delegates))
            {
                foreach (var handler in delegates.Cast<Action<IEvent>>())
                    handler(gameEvent);
            }
        }

        public void Unsubscribe<IEvent>(Action<IEvent> handler)
        {
            var eventType = typeof(IEvent);
            if (_handlers.TryGetValue(eventType, out var delegates))
                delegates.Remove(handler);
        }
    }
}
