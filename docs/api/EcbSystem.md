#### [LeoEcsSaber](index.md 'index')
### [Saber7ooth.LeoEcsSaber.Extensions.ECB](Saber7ooth.LeoEcsSaber.Extensions.ECB.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB')

## EcbSystem Class

```csharp
public abstract class EcbSystem :
Saber7ooth.LeoEcsSaber.IEcsPostDestroySystem,
Saber7ooth.LeoEcsSaber.IEcsSystem
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EcbSystem

Implements [IEcsPostDestroySystem](IEcsPostDestroySystem.md 'Saber7ooth.LeoEcsSaber.IEcsPostDestroySystem'), [IEcsSystem](IEcsSystem.md 'Saber7ooth.LeoEcsSaber.IEcsSystem')

| Constructors | |
| :--- | :--- |
| [EcbSystem(EcsWorld, Config)](EcbSystem.EcbSystem(EcsWorld,Config).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbSystem.EcbSystem(Saber7ooth.LeoEcsSaber.EcsWorld, Saber7ooth.LeoEcsSaber.EcsWorld.Config)') | |

| Fields | |
| :--- | :--- |
| [_cachedType](EcbSystem._cachedType.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbSystem._cachedType') | |
| [CommandBuffer](EcbSystem.CommandBuffer.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbSystem.CommandBuffer') | |

| Methods | |
| :--- | :--- |
| [ClearCommandBuffer()](EcbSystem.ClearCommandBuffer().md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbSystem.ClearCommandBuffer()') | Manually clear Command Buffer |
| [ExecuteAll(bool)](EcbSystem.ExecuteAll(bool).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbSystem.ExecuteAll(bool)') | Execute all commands |
| [ExecuteCommandsOnEntity(int, bool)](EcbSystem.ExecuteCommandsOnEntity(int,bool).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbSystem.ExecuteCommandsOnEntity(int, bool)') | Execute all commands that belong to the entity. |
| [ExecutePackedCommand(EcsPackedEntity, bool)](EcbSystem.ExecutePackedCommand(EcsPackedEntity,bool).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbSystem.ExecutePackedCommand(Saber7ooth.LeoEcsSaber.EcsPackedEntity, bool)') | Execute concrete packed command. |
| [ExecuteSequenceStep(int)](EcbSystem.ExecuteSequenceStep(int).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbSystem.ExecuteSequenceStep(int)') | Execute one custom sequences step in Command Buffer at index. You can use it in for loop with your custom logic |
| [ExecuteStep(int)](EcbSystem.ExecuteStep(int).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbSystem.ExecuteStep(int)') | Execute one Command Buffer step at index. You can use it in for loop with your custom logic. |
| [PostDestroy(IEcsSystems)](EcbSystem.PostDestroy(IEcsSystems).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbSystem.PostDestroy(Saber7ooth.LeoEcsSaber.IEcsSystems)') | |
