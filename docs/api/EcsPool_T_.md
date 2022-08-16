#### [LeoEcsSaber](index.md 'index')
### [Saber7ooth.LeoEcsSaber](Saber7ooth.LeoEcsSaber.md 'Saber7ooth.LeoEcsSaber')

## EcsPool<T> Class

```csharp
public sealed class EcsPool<T> :
Saber7ooth.LeoEcsSaber.IEcsPool
    where T : struct, System.ValueType, System.ValueType
```
#### Type parameters

<a name='Saber7ooth.LeoEcsSaber.EcsPool_T_.T'></a>

`T`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EcsPool<T>

Implements [IEcsPool](IEcsPool.md 'Saber7ooth.LeoEcsSaber.IEcsPool')

| Constructors | |
| :--- | :--- |
| [EcsPool(EcsWorld, int, int, int, int)](EcsPool_T_.EcsPool(EcsWorld,int,int,int,int).md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.EcsPool(Saber7ooth.LeoEcsSaber.EcsWorld, int, int, int, int)') | |

| Fields | |
| :--- | :--- |
| [_autoReset](EcsPool_T_._autoReset.md 'Saber7ooth.LeoEcsSaber.EcsPool<T>._autoReset') | |
| [_denseItems](EcsPool_T_._denseItems.md 'Saber7ooth.LeoEcsSaber.EcsPool<T>._denseItems') | |
| [_denseItemsCount](EcsPool_T_._denseItemsCount.md 'Saber7ooth.LeoEcsSaber.EcsPool<T>._denseItemsCount') | |
| [_id](EcsPool_T_._id.md 'Saber7ooth.LeoEcsSaber.EcsPool<T>._id') | |
| [_recycledItems](EcsPool_T_._recycledItems.md 'Saber7ooth.LeoEcsSaber.EcsPool<T>._recycledItems') | |
| [_recycledItemsCount](EcsPool_T_._recycledItemsCount.md 'Saber7ooth.LeoEcsSaber.EcsPool<T>._recycledItemsCount') | |
| [_sparseItems](EcsPool_T_._sparseItems.md 'Saber7ooth.LeoEcsSaber.EcsPool<T>._sparseItems') | |
| [_type](EcsPool_T_._type.md 'Saber7ooth.LeoEcsSaber.EcsPool<T>._type') | |
| [_world](EcsPool_T_._world.md 'Saber7ooth.LeoEcsSaber.EcsPool<T>._world') | |

| Methods | |
| :--- | :--- |
| [Add(int)](EcsPool_T_.Add(int).md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.Add(int)') | |
| [Del(int)](EcsPool_T_.Del(int).md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.Del(int)') | |
| [Get(int)](EcsPool_T_.Get(int).md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.Get(int)') | |
| [GetComponentType()](EcsPool_T_.GetComponentType().md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.GetComponentType()') | |
| [GetId()](EcsPool_T_.GetId().md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.GetId()') | |
| [GetRawDenseItems()](EcsPool_T_.GetRawDenseItems().md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.GetRawDenseItems()') | |
| [GetRawDenseItemsCount()](EcsPool_T_.GetRawDenseItemsCount().md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.GetRawDenseItemsCount()') | |
| [GetRawRecycledItems()](EcsPool_T_.GetRawRecycledItems().md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.GetRawRecycledItems()') | |
| [GetRawRecycledItemsCount()](EcsPool_T_.GetRawRecycledItemsCount().md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.GetRawRecycledItemsCount()') | |
| [GetRawSparseItems()](EcsPool_T_.GetRawSparseItems().md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.GetRawSparseItems()') | |
| [GetWorld()](EcsPool_T_.GetWorld().md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.GetWorld()') | |
| [Has(int)](EcsPool_T_.Has(int).md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.Has(int)') | |
| [ReflectionSupportHack()](EcsPool_T_.ReflectionSupportHack().md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.ReflectionSupportHack()') | |

| Explicit Interface Implementations | |
| :--- | :--- |
| [Saber7ooth.LeoEcsSaber.IEcsPool.AddRaw(int, object)](EcsPool_T_.Saber7ooth.LeoEcsSaber.IEcsPool.AddRaw(int,object).md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.Saber7ooth.LeoEcsSaber.IEcsPool.AddRaw(int, object)') | |
| [Saber7ooth.LeoEcsSaber.IEcsPool.GetRaw(int)](EcsPool_T_.Saber7ooth.LeoEcsSaber.IEcsPool.GetRaw(int).md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.Saber7ooth.LeoEcsSaber.IEcsPool.GetRaw(int)') | |
| [Saber7ooth.LeoEcsSaber.IEcsPool.Resize(int)](EcsPool_T_.Saber7ooth.LeoEcsSaber.IEcsPool.Resize(int).md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.Saber7ooth.LeoEcsSaber.IEcsPool.Resize(int)') | |
| [Saber7ooth.LeoEcsSaber.IEcsPool.SetRaw(int, object)](EcsPool_T_.Saber7ooth.LeoEcsSaber.IEcsPool.SetRaw(int,object).md 'Saber7ooth.LeoEcsSaber.EcsPool<T>.Saber7ooth.LeoEcsSaber.IEcsPool.SetRaw(int, object)') | |
