#### [LeoEcsSaber](index.md 'index')
### [Saber7ooth.LeoEcsSaber.Extensions.Threading](Saber7ooth.LeoEcsSaber.Extensions.Threading.md 'Saber7ooth.LeoEcsSaber.Extensions.Threading')

## EcsThreadSystem<TThread,T1> Class

```csharp
public abstract class EcsThreadSystem<TThread,T1> : Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystemBase,
Saber7ooth.LeoEcsSaber.IEcsRunSystem,
Saber7ooth.LeoEcsSaber.IEcsSystem
    where TThread : struct, Saber7ooth.LeoEcsSaber.Extensions.Threading.IEcsThread<T1>, System.ValueType, System.ValueType
    where T1 : struct, System.ValueType, System.ValueType
```
#### Type parameters

<a name='Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem_TThread,T1_.TThread'></a>

`TThread`

<a name='Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem_TThread,T1_.T1'></a>

`T1`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [EcsThreadSystemBase](EcsThreadSystemBase.md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystemBase') &#129106; EcsThreadSystem<TThread,T1>

Implements [IEcsRunSystem](IEcsRunSystem.md 'Saber7ooth.LeoEcsSaber.IEcsRunSystem'), [IEcsSystem](IEcsSystem.md 'Saber7ooth.LeoEcsSaber.IEcsSystem')

| Fields | |
| :--- | :--- |
| [_filter](EcsThreadSystem_TThread,T1_._filter.md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1>._filter') | |
| [_pool1](EcsThreadSystem_TThread,T1_._pool1.md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1>._pool1') | |
| [_thread](EcsThreadSystem_TThread,T1_._thread.md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1>._thread') | |
| [_worker](EcsThreadSystem_TThread,T1_._worker.md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1>._worker') | |

| Methods | |
| :--- | :--- |
| [Execute(int, int)](EcsThreadSystem_TThread,T1_.Execute(int,int).md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1>.Execute(int, int)') | |
| [Run(IEcsSystems)](EcsThreadSystem_TThread,T1_.Run(IEcsSystems).md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1>.Run(Saber7ooth.LeoEcsSaber.IEcsSystems)') | |
| [SetData(IEcsSystems, TThread)](EcsThreadSystem_TThread,T1_.SetData(IEcsSystems,TThread).md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1>.SetData(Saber7ooth.LeoEcsSaber.IEcsSystems, TThread)') | |
