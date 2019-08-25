using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace ServiceRegistrator
{
    public class ServiceRegistry
    {
        private static ServiceRegistry instance = null;
        private static ConcurrentDictionary<Type, Func<object>> registry = registry = new ConcurrentDictionary<Type, Func<object>>();
        private ServiceRegistry()
        {
        }

        public static ServiceRegistry GetCurrent()
        {
            if(instance == null)
            {
                instance = new ServiceRegistry();
            }
            return instance;
        }

        public void Register<TKey, TInstance>()
        {
            registry.TryAdd(typeof(TKey), () => Activator.CreateInstance(typeof(TInstance)));
        }

        public void Register(Type type, object instance)
        {
            registry.TryAdd(type, () => instance);
        }

        public T GetService<T>()
        {
            if(!registry.TryGetValue(typeof(T), out Func<object> typeInstance))
            {
                throw new Exception(string.Format("This type not found on Service Registry. Type: {0}", nameof(T)));
            }
            return (T)typeInstance.Invoke();
        }
    }
}
