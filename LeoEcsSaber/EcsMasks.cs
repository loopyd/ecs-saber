// ----------------------------------------------------------------------------
// The Proprietary or MIT-Red License
// Copyright (c) 2012-2022 Leopotam <leopotam@yandex.ru>
// ----------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;

namespace Saber7ooth.LeoEcsSaber
{

    public interface IEcsMask
    {
        EcsFilter End(int capacity = 512);
        EcsMask Exc<T>() where T : struct;
        EcsMask Inc<T>() where T : struct;
    }

    public class EcsMask : IEcsMask
    {
        readonly EcsWorld _world;
        internal int[] Include;
        internal int[] Exclude;
        internal int IncludeCount;
        internal int ExcludeCount;
        internal int Hash;
#if DEBUG
        bool _built;
#endif

        internal EcsMask(EcsWorld world)
        {
            _world = world;
            Include = new int[8];
            Exclude = new int[2];
            Reset();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Reset()
        {
            IncludeCount = 0;
            ExcludeCount = 0;
            Hash = 0;
#if DEBUG
            _built = false;
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EcsMask Inc<T>() where T : struct
        {
            var poolId = _world.GetPool<T>().GetId();
#if DEBUG
            if (_built) { throw new Exception("Cant change built mask."); }
            if (Array.IndexOf(Include, poolId, 0, IncludeCount) != -1) { throw new Exception($"{typeof(T).Name} already in constraints list."); }
            if (Array.IndexOf(Exclude, poolId, 0, ExcludeCount) != -1) { throw new Exception($"{typeof(T).Name} already in constraints list."); }
#endif
            if (IncludeCount == Include.Length) { Array.Resize(ref Include, IncludeCount << 1); }
            Include[IncludeCount++] = poolId;
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EcsMask Exc<T>() where T : struct
        {
            var poolId = _world.GetPool<T>().GetId();
#if DEBUG
            if (_built) { throw new Exception("Cant change built mask."); }
            if (Array.IndexOf(Include, poolId, 0, IncludeCount) != -1) { throw new Exception($"{typeof(T).Name} already in constraints list."); }
            if (Array.IndexOf(Exclude, poolId, 0, ExcludeCount) != -1) { throw new Exception($"{typeof(T).Name} already in constraints list."); }
#endif
            if (ExcludeCount == Exclude.Length) { Array.Resize(ref Exclude, ExcludeCount << 1); }
            Exclude[ExcludeCount++] = poolId;
            return this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public EcsFilter End(int capacity = 512)
        {
#if DEBUG
            if (_built) { throw new Exception("Cant change built mask."); }
            _built = true;
#endif
            Array.Sort(Include, 0, IncludeCount);
            Array.Sort(Exclude, 0, ExcludeCount);
            // calculate hash.
            Hash = IncludeCount + ExcludeCount;
            for (int i = 0, iMax = IncludeCount; i < iMax; i++)
            {
                Hash = unchecked(Hash * 314159 + Include[i]);
            }
            for (int i = 0, iMax = ExcludeCount; i < iMax; i++)
            {
                Hash = unchecked(Hash * 314159 - Exclude[i]);
            }
            var (filter, isNew) = _world.GetFilterInternal(this, capacity);
            if (!isNew) { Recycle(); }
            return filter;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Recycle()
        {
            Reset();
            if (_world._masksCount == _world._masks.Length)
            {
                Array.Resize(ref _world._masks, _world._masksCount << 1);
            }
            _world._masks[_world._masksCount++] = this;
        }
    }
}