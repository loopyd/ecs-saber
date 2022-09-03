// ----------------------------------------------------------------------------
// The Proprietary or MIT-Red License
// Copyright (c) 2012-2022 Leopotam <leopotam@yandex.ru>
//
// Code modified to work independently of repository by Robert Smith <nightwintertooth@gmail.com>
// ----------------------------------------------------------------------------

namespace Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems
{
    public struct EcsGroupSystemState
    {
        public string Name;
        public bool State;
    }

    public static class Extensions
    {
        public static IEcsSystems AddGroup(this IEcsSystems systems, string groupName, bool defaultState, string eventWorldName, params IEcsSystem[] nestedSystems)
        {
            return systems.Add(new EcsGroupSystem(groupName, defaultState, eventWorldName, nestedSystems));
        }
        public static IEcsSystems DelHere<T>(this IEcsSystems systems, string worldName = null) where T : struct
        {
#if DEBUG
            if (systems.GetWorld(worldName) == null) { throw new System.Exception($"Requested world \"{(string.IsNullOrEmpty(worldName) ? "[default]" : worldName)}\" not found."); }
#endif
            return systems.Add(new DelHereSystem<T>(systems.GetWorld(worldName)));
        }
    }

    public sealed class DelHereSystem<T> : IEcsRunSystem where T : struct
    {
        readonly EcsFilter _filter;
        readonly EcsPool<T> _pool;

        public DelHereSystem(EcsWorld world)
        {
            _filter = world.Filter<T>().End();
            _pool = world.GetPool<T>();
        }

        public void Run(IEcsSystems systems)
        {
            foreach (var entity in _filter)
            {
                _pool.Del(entity);
            }
        }
    }

    public class EcsGroupSystem :
    IEcsPreInitSystem,
    IEcsInitSystem,
    IEcsRunSystem,
    IEcsDestroySystem,
    IEcsPostDestroySystem
    {
        readonly IEcsSystem[] _allSystems;
        readonly IEcsRunSystem[] _runSystems;
        readonly int _runSystemsCount;
        readonly string _eventsWorldName;
        readonly string _name;
        EcsFilter _filter;
        EcsPool<EcsGroupSystemState> _pool;
        bool _state;

        protected IEcsSystem[] GetNestedSystems()
        {
            return _allSystems;
        }

        public EcsGroupSystem(string name, bool defaultState, string eventsWorldName, params IEcsSystem[] systems)
        {
#if DEBUG
            if (string.IsNullOrEmpty(name)) { throw new System.Exception("Group name cant be null or empty."); }
            if (systems == null || systems.Length == 0) { throw new System.Exception("Systems list cant be null or empty."); }
#endif
            _name = name;
            _state = defaultState;
            _eventsWorldName = eventsWorldName;
            _allSystems = systems;
            _runSystemsCount = 0;
            _runSystems = new IEcsRunSystem[_allSystems.Length];
            for (var i = 0; i < _allSystems.Length; i++)
            {
                if (_allSystems[i] is IEcsRunSystem runSystem)
                {
                    _runSystems[_runSystemsCount++] = runSystem;
                }
            }
        }

        public void PreInit(IEcsSystems systems)
        {
            var world = systems.GetWorld(_eventsWorldName);
            _pool = world.GetPool<EcsGroupSystemState>();
            _filter = world.Filter<EcsGroupSystemState>().End();
            for (var i = 0; i < _allSystems.Length; i++)
            {
                if (_allSystems[i] is IEcsPreInitSystem preInitSystem)
                {
                    preInitSystem.PreInit(systems);
#if DEBUG
                    var worldName = EcsSystems.CheckForLeakedEntities(systems);
                    if (worldName != null) { throw new System.Exception($"Empty entity detected in world \"{worldName}\" after {preInitSystem.GetType().Name}.PreInit()."); }
#endif
                }
            }
        }

        public void Init(IEcsSystems systems)
        {
            for (var i = 0; i < _allSystems.Length; i++)
            {
                if (_allSystems[i] is IEcsInitSystem initSystem)
                {
                    initSystem.Init(systems);
#if DEBUG
                    var worldName = EcsSystems.CheckForLeakedEntities(systems);
                    if (worldName != null) { throw new System.Exception($"Empty entity detected in world \"{worldName}\" after {initSystem.GetType().Name}.Init()."); }
#endif
                }
            }
        }

        public void Run(IEcsSystems systems)
        {
            foreach (var entity in _filter)
            {
                ref var evt = ref _pool.Get(entity);
                if (evt.Name == _name)
                {
                    _state = evt.State;
                    _pool.Del(entity);
                }
            }
            if (_state)
            {
                for (var i = 0; i < _runSystemsCount; i++)
                {
                    _runSystems[i].Run(systems);
#if DEBUG
                    var worldName = EcsSystems.CheckForLeakedEntities(systems);
                    if (worldName != null) { throw new System.Exception($"Empty entity detected in world \"{worldName}\" after {_runSystems[i].GetType().Name}.Run()."); }
#endif
                }
            }
        }

        public void Destroy(IEcsSystems systems)
        {
            for (var i = _allSystems.Length - 1; i >= 0; i--)
            {
                if (_allSystems[i] is IEcsDestroySystem destroySystem)
                {
                    destroySystem.Destroy(systems);
#if DEBUG
                    var worldName = EcsSystems.CheckForLeakedEntities(systems);
                    if (worldName != null) { throw new System.Exception($"Empty entity detected in world \"{worldName}\" after {destroySystem.GetType().Name}.Destroy()."); }
#endif
                }
            }
        }

        public void PostDestroy(IEcsSystems systems)
        {
            for (var i = _allSystems.Length - 1; i >= 0; i--)
            {
                if (_allSystems[i] is IEcsPostDestroySystem postDestroySystem)
                {
                    postDestroySystem.PostDestroy(systems);
#if DEBUG
                    var worldName = EcsSystems.CheckForLeakedEntities(systems);
                    if (worldName != null) { throw new System.Exception($"Empty entity detected in world \"{worldName}\" after {postDestroySystem.GetType().Name}.PostDestroy()."); }
#endif
                }
            }
        }
    }
}