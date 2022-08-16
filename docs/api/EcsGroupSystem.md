#### [LeoEcsSaber](index.md 'index')
### [Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems](Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems.md 'Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems')

## EcsGroupSystem Class

```csharp
public class EcsGroupSystem :
Saber7ooth.LeoEcsSaber.IEcsPreInitSystem,
Saber7ooth.LeoEcsSaber.IEcsSystem,
Saber7ooth.LeoEcsSaber.IEcsInitSystem,
Saber7ooth.LeoEcsSaber.IEcsRunSystem,
Saber7ooth.LeoEcsSaber.IEcsDestroySystem,
Saber7ooth.LeoEcsSaber.IEcsPostDestroySystem
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EcsGroupSystem

Implements [IEcsPreInitSystem](IEcsPreInitSystem.md 'Saber7ooth.LeoEcsSaber.IEcsPreInitSystem'), [IEcsSystem](IEcsSystem.md 'Saber7ooth.LeoEcsSaber.IEcsSystem'), [IEcsInitSystem](IEcsInitSystem.md 'Saber7ooth.LeoEcsSaber.IEcsInitSystem'), [IEcsRunSystem](IEcsRunSystem.md 'Saber7ooth.LeoEcsSaber.IEcsRunSystem'), [IEcsDestroySystem](IEcsDestroySystem.md 'Saber7ooth.LeoEcsSaber.IEcsDestroySystem'), [IEcsPostDestroySystem](IEcsPostDestroySystem.md 'Saber7ooth.LeoEcsSaber.IEcsPostDestroySystem')

| Constructors | |
| :--- | :--- |
| [EcsGroupSystem(string, bool, string, IEcsSystem[])](EcsGroupSystem.EcsGroupSystem(string,bool,string,IEcsSystem[]).md 'Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems.EcsGroupSystem.EcsGroupSystem(string, bool, string, Saber7ooth.LeoEcsSaber.IEcsSystem[])') | |

| Fields | |
| :--- | :--- |
| [_allSystems](EcsGroupSystem._allSystems.md 'Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems.EcsGroupSystem._allSystems') | |
| [_eventsWorldName](EcsGroupSystem._eventsWorldName.md 'Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems.EcsGroupSystem._eventsWorldName') | |
| [_filter](EcsGroupSystem._filter.md 'Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems.EcsGroupSystem._filter') | |
| [_name](EcsGroupSystem._name.md 'Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems.EcsGroupSystem._name') | |
| [_pool](EcsGroupSystem._pool.md 'Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems.EcsGroupSystem._pool') | |
| [_runSystems](EcsGroupSystem._runSystems.md 'Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems.EcsGroupSystem._runSystems') | |
| [_runSystemsCount](EcsGroupSystem._runSystemsCount.md 'Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems.EcsGroupSystem._runSystemsCount') | |
| [_state](EcsGroupSystem._state.md 'Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems.EcsGroupSystem._state') | |

| Methods | |
| :--- | :--- |
| [Destroy(IEcsSystems)](EcsGroupSystem.Destroy(IEcsSystems).md 'Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems.EcsGroupSystem.Destroy(Saber7ooth.LeoEcsSaber.IEcsSystems)') | |
| [GetNestedSystems()](EcsGroupSystem.GetNestedSystems().md 'Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems.EcsGroupSystem.GetNestedSystems()') | |
| [Init(IEcsSystems)](EcsGroupSystem.Init(IEcsSystems).md 'Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems.EcsGroupSystem.Init(Saber7ooth.LeoEcsSaber.IEcsSystems)') | |
| [PostDestroy(IEcsSystems)](EcsGroupSystem.PostDestroy(IEcsSystems).md 'Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems.EcsGroupSystem.PostDestroy(Saber7ooth.LeoEcsSaber.IEcsSystems)') | |
| [PreInit(IEcsSystems)](EcsGroupSystem.PreInit(IEcsSystems).md 'Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems.EcsGroupSystem.PreInit(Saber7ooth.LeoEcsSaber.IEcsSystems)') | |
| [Run(IEcsSystems)](EcsGroupSystem.Run(IEcsSystems).md 'Saber7ooth.LeoEcsSaber.Extensions.ExtendedSystems.EcsGroupSystem.Run(Saber7ooth.LeoEcsSaber.IEcsSystems)') | |
