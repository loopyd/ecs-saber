#### [LeoEcsSaber](index.md 'index')
### [Saber7ooth.LeoEcsSaber.Extensions.Events](Saber7ooth.LeoEcsSaber.Extensions.Events.md 'Saber7ooth.LeoEcsSaber.Extensions.Events').[EventsBus](EventsBus.md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus')

## EventsBus.GetFilter<T>() Method

```csharp
private Saber7ooth.LeoEcsSaber.EcsFilter GetFilter<T>()
    where T : struct, Saber7ooth.LeoEcsSaber.Extensions.Events.IEventReplicant, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.GetFilter_T_().T'></a>

`T`

#### Returns
[EcsFilter](EcsFilter.md 'Saber7ooth.LeoEcsSaber.EcsFilter')