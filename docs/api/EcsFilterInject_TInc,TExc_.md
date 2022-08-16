#### [LeoEcsSaber](index.md 'index')
### [Saber7ooth.LeoEcsSaber.Extensions.Di](Saber7ooth.LeoEcsSaber.Extensions.Di.md 'Saber7ooth.LeoEcsSaber.Extensions.Di')

## EcsFilterInject<TInc,TExc> Struct

```csharp
public struct EcsFilterInject<TInc,TExc> :
Saber7ooth.LeoEcsSaber.Extensions.Di.IEcsDataInject
    where TInc : struct, Saber7ooth.LeoEcsSaber.Extensions.Di.IEcsInclude, System.ValueType, System.ValueType
    where TExc : struct, Saber7ooth.LeoEcsSaber.Extensions.Di.IEcsExclude, System.ValueType, System.ValueType
```
#### Type parameters

<a name='Saber7ooth.LeoEcsSaber.Extensions.Di.EcsFilterInject_TInc,TExc_.TInc'></a>

`TInc`

<a name='Saber7ooth.LeoEcsSaber.Extensions.Di.EcsFilterInject_TInc,TExc_.TExc'></a>

`TExc`

Implements [IEcsDataInject](IEcsDataInject.md 'Saber7ooth.LeoEcsSaber.Extensions.Di.IEcsDataInject')

| Fields | |
| :--- | :--- |
| [_worldName](EcsFilterInject_TInc,TExc_._worldName.md 'Saber7ooth.LeoEcsSaber.Extensions.Di.EcsFilterInject<TInc,TExc>._worldName') | |
| [Pools](EcsFilterInject_TInc,TExc_.Pools.md 'Saber7ooth.LeoEcsSaber.Extensions.Di.EcsFilterInject<TInc,TExc>.Pools') | |
| [Value](EcsFilterInject_TInc,TExc_.Value.md 'Saber7ooth.LeoEcsSaber.Extensions.Di.EcsFilterInject<TInc,TExc>.Value') | |

| Operators | |
| :--- | :--- |
| [implicit operator EcsFilterInject&lt;TInc,TExc&gt;(string)](EcsFilterInject_TInc,TExc_.implicitoperatorEcsFilterInject_TInc,TExc_(string).md 'Saber7ooth.LeoEcsSaber.Extensions.Di.EcsFilterInject<TInc,TExc>.op_Implicit Saber7ooth.LeoEcsSaber.Extensions.Di.EcsFilterInject<TInc,TExc>(string)') | |

| Explicit Interface Implementations | |
| :--- | :--- |
| [Saber7ooth.LeoEcsSaber.Extensions.Di.IEcsDataInject.Fill(IEcsSystems)](EcsFilterInject_TInc,TExc_.Saber7ooth.LeoEcsSaber.Extensions.Di.IEcsDataInject.Fill(IEcsSystems).md 'Saber7ooth.LeoEcsSaber.Extensions.Di.EcsFilterInject<TInc,TExc>.Saber7ooth.LeoEcsSaber.Extensions.Di.IEcsDataInject.Fill(Saber7ooth.LeoEcsSaber.IEcsSystems)') | |
