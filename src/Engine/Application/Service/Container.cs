namespace Engine.Application.Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    public class Container
    {
        // Maps interface/service type -> implementation type
        private readonly Dictionary<Type, Type> registrations = new Dictionary<Type, Type>();
        private readonly Dictionary<Type, object> singletons = new Dictionary<Type, object>();


        // Register mapping: interface/service -> concrete implementation
        public void Register<TService, TImplementation>()
            where TImplementation : TService
        {
            registrations[typeof(TService)] = typeof(TImplementation);
        }

        // Resolve an instance of TService
        public TService Resolve<TService>()
        {
            return (TService)Resolve(typeof(TService));
        }

        private object Resolve(Type serviceType)
        {
            if (singletons.TryGetValue(serviceType, out var existing))
                return existing;

            if (!registrations.TryGetValue(serviceType, out var implementationType))
            {
                if (!serviceType.IsAbstract)
                    implementationType = serviceType;
                else
                    throw new InvalidOperationException($"No registration for {serviceType.FullName}");
            }

            var constructor = implementationType
                .GetConstructors()
                .OrderByDescending(c => c.GetParameters().Length)
                .FirstOrDefault();

            if (constructor == null)
                throw new InvalidOperationException($"No public constructor found for {implementationType.FullName}");

            var parameters = constructor.GetParameters()
                .Select(p => Resolve(p.ParameterType))
                .ToArray();

            var instance = Activator.CreateInstance(implementationType, parameters);

            singletons[serviceType] = instance;  // Cache for singleton

            return instance;
        }
    }
}