﻿// ----------------------------------------------------------------------------
// The Proprietary or MIT-Red License
// Copyright (c) 2012-2022 Leopotam <leopotam@yandex.ru>
//
// Code modified to work independently of repository by Robert Smith <nightwintertooth@gmail.com>
// ----------------------------------------------------------------------------

namespace Saber7ooth.LeoEcsSaber.Extensions.ECB
{
    internal interface IEcbPool
    {
        void AddToSourceEntity(int bufferEntity, int sourceEntity);
        void SetToSourceEntity(int bufferEntity, int sourceEntity);
        void SetOrAddToSourceEntity(int bufferEntity, int sourceEntity);
        void Del(int sourceEntity);
    }

    internal class EcbPool<TComponent> : IEcbPool where TComponent : struct
    {
        public readonly EcsPool<TComponent> SourcePool;
        public readonly EcsPool<TComponent> BufferPool;

        public EcbPool(EcsWorld sourceWorld, EcsWorld bufferWorld)
        {
            SourcePool = sourceWorld.GetPool<TComponent>();
            BufferPool = bufferWorld.GetPool<TComponent>();
        }

        public EcbPool(EcsWorld bufferWorld, EcsPool<TComponent> sourcePool)
        {
            SourcePool = sourcePool;
            BufferPool = bufferWorld.GetPool<TComponent>();
        }

        public void AddToSourceEntity(int bufferEntity, int sourceEntity)
        {
            ref var sourceComponent = ref SourcePool.Add(sourceEntity);
            ref var bufferComponent = ref BufferPool.Get(bufferEntity);
            sourceComponent = bufferComponent;
        }

        public void SetToSourceEntity(int bufferEntity, int sourceEntity)
        {
            ref var sourceComponent = ref SourcePool.Get(sourceEntity);
            ref var bufferComponent = ref BufferPool.Get(bufferEntity);
            sourceComponent = bufferComponent;
        }

        public void SetOrAddToSourceEntity(int bufferEntity, int sourceEntity)
        {
            ref var sourceComponent = ref SourcePool.GetOrAdd(sourceEntity);
            ref var bufferComponent = ref BufferPool.Get(bufferEntity);
            sourceComponent = bufferComponent;
        }

        public void Del(int sourceEntity)
        {
            SourcePool.Del(sourceEntity);
        }
    }
}