#### [LeoEcsSaber](index.md 'index')
### [Saber7ooth.LeoEcsSaber](Saber7ooth.LeoEcsSaber.md 'Saber7ooth.LeoEcsSaber')

## EcsWorld Class

```csharp
public class EcsWorld
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EcsWorld

| Constructors | |
| :--- | :--- |
| [EcsWorld(Config)](EcsWorld.EcsWorld(Config).md 'Saber7ooth.LeoEcsSaber.EcsWorld.EcsWorld(Saber7ooth.LeoEcsSaber.EcsWorld.Config)') | |

| Fields | |
| :--- | :--- |
| [_allFilters](EcsWorld._allFilters.md 'Saber7ooth.LeoEcsSaber.EcsWorld._allFilters') | |
| [_destroyed](EcsWorld._destroyed.md 'Saber7ooth.LeoEcsSaber.EcsWorld._destroyed') | |
| [_entitiesCount](EcsWorld._entitiesCount.md 'Saber7ooth.LeoEcsSaber.EcsWorld._entitiesCount') | |
| [_eventListeners](EcsWorld._eventListeners.md 'Saber7ooth.LeoEcsSaber.EcsWorld._eventListeners') | |
| [_filtersByExcludedComponents](EcsWorld._filtersByExcludedComponents.md 'Saber7ooth.LeoEcsSaber.EcsWorld._filtersByExcludedComponents') | |
| [_filtersByIncludedComponents](EcsWorld._filtersByIncludedComponents.md 'Saber7ooth.LeoEcsSaber.EcsWorld._filtersByIncludedComponents') | |
| [_hashedFilters](EcsWorld._hashedFilters.md 'Saber7ooth.LeoEcsSaber.EcsWorld._hashedFilters') | |
| [_leakedEntities](EcsWorld._leakedEntities.md 'Saber7ooth.LeoEcsSaber.EcsWorld._leakedEntities') | |
| [_masks](EcsWorld._masks.md 'Saber7ooth.LeoEcsSaber.EcsWorld._masks') | |
| [_masksCount](EcsWorld._masksCount.md 'Saber7ooth.LeoEcsSaber.EcsWorld._masksCount') | |
| [_poolDenseSize](EcsWorld._poolDenseSize.md 'Saber7ooth.LeoEcsSaber.EcsWorld._poolDenseSize') | |
| [_poolHashes](EcsWorld._poolHashes.md 'Saber7ooth.LeoEcsSaber.EcsWorld._poolHashes') | |
| [_poolRecycledSize](EcsWorld._poolRecycledSize.md 'Saber7ooth.LeoEcsSaber.EcsWorld._poolRecycledSize') | |
| [_pools](EcsWorld._pools.md 'Saber7ooth.LeoEcsSaber.EcsWorld._pools') | |
| [_poolsCount](EcsWorld._poolsCount.md 'Saber7ooth.LeoEcsSaber.EcsWorld._poolsCount') | |
| [_recycledEntities](EcsWorld._recycledEntities.md 'Saber7ooth.LeoEcsSaber.EcsWorld._recycledEntities') | |
| [_recycledEntitiesCount](EcsWorld._recycledEntitiesCount.md 'Saber7ooth.LeoEcsSaber.EcsWorld._recycledEntitiesCount') | |
| [Entities](EcsWorld.Entities.md 'Saber7ooth.LeoEcsSaber.EcsWorld.Entities') | |

| Methods | |
| :--- | :--- |
| [AddEventListener(IEcsWorldEventListener)](EcsWorld.AddEventListener(IEcsWorldEventListener).md 'Saber7ooth.LeoEcsSaber.EcsWorld.AddEventListener(Saber7ooth.LeoEcsSaber.IEcsWorldEventListener)') | |
| [CheckForLeakedEntities()](EcsWorld.CheckForLeakedEntities().md 'Saber7ooth.LeoEcsSaber.EcsWorld.CheckForLeakedEntities()') | |
| [DelEntity(int)](EcsWorld.DelEntity(int).md 'Saber7ooth.LeoEcsSaber.EcsWorld.DelEntity(int)') | |
| [Destroy()](EcsWorld.Destroy().md 'Saber7ooth.LeoEcsSaber.EcsWorld.Destroy()') | |
| [Filter&lt;T&gt;()](EcsWorld.Filter_T_().md 'Saber7ooth.LeoEcsSaber.EcsWorld.Filter<T>()') | |
| [GetAllEntities(int[])](EcsWorld.GetAllEntities(int[]).md 'Saber7ooth.LeoEcsSaber.EcsWorld.GetAllEntities(int[])') | |
| [GetAllocatedEntitiesCount()](EcsWorld.GetAllocatedEntitiesCount().md 'Saber7ooth.LeoEcsSaber.EcsWorld.GetAllocatedEntitiesCount()') | |
| [GetAllPools(IEcsPool[])](EcsWorld.GetAllPools(IEcsPool[]).md 'Saber7ooth.LeoEcsSaber.EcsWorld.GetAllPools(Saber7ooth.LeoEcsSaber.IEcsPool[])') | |
| [GetComponents(int, object[])](EcsWorld.GetComponents(int,object[]).md 'Saber7ooth.LeoEcsSaber.EcsWorld.GetComponents(int, object[])') | |
| [GetComponentsCount(int)](EcsWorld.GetComponentsCount(int).md 'Saber7ooth.LeoEcsSaber.EcsWorld.GetComponentsCount(int)') | |
| [GetComponentTypes(int, Type[])](EcsWorld.GetComponentTypes(int,Type[]).md 'Saber7ooth.LeoEcsSaber.EcsWorld.GetComponentTypes(int, System.Type[])') | |
| [GetEntitiesCount()](EcsWorld.GetEntitiesCount().md 'Saber7ooth.LeoEcsSaber.EcsWorld.GetEntitiesCount()') | |
| [GetEntityGen(int)](EcsWorld.GetEntityGen(int).md 'Saber7ooth.LeoEcsSaber.EcsWorld.GetEntityGen(int)') | |
| [GetFilterInternal(Mask, int)](EcsWorld.GetFilterInternal(Mask,int).md 'Saber7ooth.LeoEcsSaber.EcsWorld.GetFilterInternal(Saber7ooth.LeoEcsSaber.EcsWorld.Mask, int)') | |
| [GetPool&lt;T&gt;()](EcsWorld.GetPool_T_().md 'Saber7ooth.LeoEcsSaber.EcsWorld.GetPool<T>()') | |
| [GetPoolById(int)](EcsWorld.GetPoolById(int).md 'Saber7ooth.LeoEcsSaber.EcsWorld.GetPoolById(int)') | |
| [GetPoolByType(Type)](EcsWorld.GetPoolByType(Type).md 'Saber7ooth.LeoEcsSaber.EcsWorld.GetPoolByType(System.Type)') | |
| [GetPoolsCount()](EcsWorld.GetPoolsCount().md 'Saber7ooth.LeoEcsSaber.EcsWorld.GetPoolsCount()') | |
| [GetRawEntities()](EcsWorld.GetRawEntities().md 'Saber7ooth.LeoEcsSaber.EcsWorld.GetRawEntities()') | |
| [GetWorldSize()](EcsWorld.GetWorldSize().md 'Saber7ooth.LeoEcsSaber.EcsWorld.GetWorldSize()') | |
| [IsAlive()](EcsWorld.IsAlive().md 'Saber7ooth.LeoEcsSaber.EcsWorld.IsAlive()') | |
| [IsEntityAliveInternal(int)](EcsWorld.IsEntityAliveInternal(int).md 'Saber7ooth.LeoEcsSaber.EcsWorld.IsEntityAliveInternal(int)') | |
| [IsMaskCompatible(Mask, int)](EcsWorld.IsMaskCompatible(Mask,int).md 'Saber7ooth.LeoEcsSaber.EcsWorld.IsMaskCompatible(Saber7ooth.LeoEcsSaber.EcsWorld.Mask, int)') | |
| [IsMaskCompatibleWithout(Mask, int, int)](EcsWorld.IsMaskCompatibleWithout(Mask,int,int).md 'Saber7ooth.LeoEcsSaber.EcsWorld.IsMaskCompatibleWithout(Saber7ooth.LeoEcsSaber.EcsWorld.Mask, int, int)') | |
| [NewEntity()](EcsWorld.NewEntity().md 'Saber7ooth.LeoEcsSaber.EcsWorld.NewEntity()') | |
| [OnEntityChangeInternal(int, int, bool)](EcsWorld.OnEntityChangeInternal(int,int,bool).md 'Saber7ooth.LeoEcsSaber.EcsWorld.OnEntityChangeInternal(int, int, bool)') | |
| [RaiseEntityChangeEvent(int)](EcsWorld.RaiseEntityChangeEvent(int).md 'Saber7ooth.LeoEcsSaber.EcsWorld.RaiseEntityChangeEvent(int)') | |
| [RemoveEventListener(IEcsWorldEventListener)](EcsWorld.RemoveEventListener(IEcsWorldEventListener).md 'Saber7ooth.LeoEcsSaber.EcsWorld.RemoveEventListener(Saber7ooth.LeoEcsSaber.IEcsWorldEventListener)') | |
