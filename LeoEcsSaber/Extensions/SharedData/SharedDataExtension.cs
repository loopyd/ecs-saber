// ----------------------------------------------------------------------------
// The Proprietary or MIT-Red License
// Copyright (c) 2012-2022 Leopotam <leopotam@yandex.ru>
//
// Code modified to work independently of repository by Robert Smith <nightwintertooth@gmail.com>
// ----------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Saber7ooth.LeoEcsSaber.Extensions.Shared
{
    public static class shared
    {
        private const string SharedFieldNameInEcsSystems = "_shared";
        private static readonly Type SharedAttrType = typeof(EcsInjectAttribute);

        public static IEcsSystems InjectShared<T>(this IEcsSystems systems, T instance)
        {
            var sharedObject = systems.GetShared<object>();

            Shared shared = null;
            if (sharedObject == null)
            {
                var fieldShared = systems.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                .FirstOrDefault(fieldInfo => fieldInfo.Name == SharedFieldNameInEcsSystems);
                shared = new Shared();
                // ReSharper disable once PossibleNullReferenceException
                fieldShared.SetValue(systems, shared);
            }
            else if (sharedObject is not Shared)
            {
                throw new Exception(
                $"You cannot use InjectShared() when the Shared object has already been used in EcsSystems ({sharedObject.GetType().Name}), it should be: new EcsSystems(world);");
            }
            else
            {
                shared = (Shared)sharedObject;
            }

            // ReSharper disable once PossibleNullReferenceException
            shared.Set(instance);
            return systems;
        }

        public static IEcsSystems InitShared(this IEcsSystems systems)
        {
            var shared = systems.GetShared<Shared>();
            foreach (IEcsSystem system in systems.GetAllSystems())
            {
                foreach (FieldInfo fieldInfo in system.GetType()
                .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
                {
                    SetFieldValue(shared, system, fieldInfo);
                }
            }
            return systems;
        }

        private static void SetFieldValue(Shared shared, IEcsSystem system, FieldInfo fieldInfo)
        {
            if (shared != null && Attribute.IsDefined(fieldInfo, SharedAttrType))
            {
                var value = shared.Get(fieldInfo.FieldType);
                fieldInfo.SetValue(system, value);
            }
        }

        public class Shared
        {
            private readonly Dictionary<Type, object> _dictionary = new Dictionary<Type, object>();

            public void Set<T>(T instance)
            {
                _dictionary[typeof(T)] = instance;
            }

            public T Get<T>() => (T)Get(typeof(T));

            public object Get(Type type)
            {
#if DEBUG
                if (!_dictionary.TryGetValue(type, out object value))
                {
                    throw new Exception(
                    $"The instance of type {type.Name} has not been injected using the InjectShared(...) method!");
                }
#endif
                return _dictionary[type];
            }
        }
    }

    public class EcsInjectAttribute : Attribute
    {
    }
}