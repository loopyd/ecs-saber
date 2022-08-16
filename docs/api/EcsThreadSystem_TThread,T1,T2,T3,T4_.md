#### [LeoEcsSaber](index.md 'index')
### [Saber7ooth.LeoEcsSaber.Extensions.Threading](Saber7ooth.LeoEcsSaber.Extensions.Threading.md 'Saber7ooth.LeoEcsSaber.Extensions.Threading')

## EcsThreadSystem<TThread,T1,T2,T3,T4> Class

```csharp
public abstract class EcsThreadSystem<TThread,T1,T2,T3,T4> : Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystemBase,
Saber7ooth.LeoEcsSaber.IEcsRunSystem,
Saber7ooth.LeoEcsSaber.IEcsSystem
    where TThread : struct, Saber7ooth.LeoEcsSaber.Extensions.Threading.IEcsThread<T1, T2, T3, T4>, System.ValueType, System.ValueType
    where T1 : struct, System.ValueType, System.ValueType
    where T2 : struct, System.ValueType, System.ValueType
    where T3 : struct, System.ValueType, System.ValueType
    where T4 : struct, System.ValueType, System.ValueType
```
#### Type parameters

<a name='Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem_TThread,T1,T2,T3,T4_.TThread'></a>

`TThread`

<a name='Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem_TThread,T1,T2,T3,T4_.T1'></a>

`T1`

<a name='Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem_TThread,T1,T2,T3,T4_.T2'></a>

`T2`

<a name='Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem_TThread,T1,T2,T3,T4_.T3'></a>

`T3`

<a name='Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem_TThread,T1,T2,T3,T4_.T4'></a>

`T4`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [EcsThreadSystemBase](EcsThreadSystemBase.md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystemBase') &#129106; EcsThreadSystem<TThread,T1,T2,T3,T4>

Implements [IEcsRunSystem](IEcsRunSystem.md 'Saber7ooth.LeoEcsSaber.IEcsRunSystem'), [IEcsSystem](IEcsSystem.md 'Saber7ooth.LeoEcsSaber.IEcsSystem')

| Fields | |
| :--- | :--- |
| [_filter](EcsThreadSystem_TThread,T1,T2,T3,T4_._filter.md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1,T2,T3,T4>._filter') | |
| [_pool1](EcsThreadSystem_TThread,T1,T2,T3,T4_._pool1.md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1,T2,T3,T4>._pool1') | |
| [_pool2](EcsThreadSystem_TThread,T1,T2,T3,T4_._pool2.md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1,T2,T3,T4>._pool2') | |
| [_pool3](EcsThreadSystem_TThread,T1,T2,T3,T4_._pool3.md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1,T2,T3,T4>._pool3') | |
| [_pool4](EcsThreadSystem_TThread,T1,T2,T3,T4_._pool4.md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1,T2,T3,T4>._pool4') | |
| [_thread](EcsThreadSystem_TThread,T1,T2,T3,T4_._thread.md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1,T2,T3,T4>._thread') | |
| [_worker](EcsThreadSystem_TThread,T1,T2,T3,T4_._worker.md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1,T2,T3,T4>._worker') | |

| Methods | |
| :--- | :--- |
| [Execute(int, int)](EcsThreadSystem_TThread,T1,T2,T3,T4_.Execute(int,int).md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1,T2,T3,T4>.Execute(int, int)') | |
| [Run(IEcsSystems)](EcsThreadSystem_TThread,T1,T2,T3,T4_.Run(IEcsSystems).md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1,T2,T3,T4>.Run(Saber7ooth.LeoEcsSaber.IEcsSystems)') | |
| [SetData(IEcsSystems, TThread)](EcsThreadSystem_TThread,T1,T2,T3,T4_.SetData(IEcsSystems,TThread).md 'Saber7ooth.LeoEcsSaber.Extensions.Threading.EcsThreadSystem<TThread,T1,T2,T3,T4>.SetData(Saber7ooth.LeoEcsSaber.IEcsSystems, TThread)') | |
