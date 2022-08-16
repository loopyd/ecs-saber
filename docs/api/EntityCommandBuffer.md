#### [LeoEcsSaber](index.md 'index')
### [Saber7ooth.LeoEcsSaber.Extensions.ECB](Saber7ooth.LeoEcsSaber.Extensions.ECB.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB')

## EntityCommandBuffer Class

```csharp
public class EntityCommandBuffer
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EntityCommandBuffer

| Constructors | |
| :--- | :--- |
| [EntityCommandBuffer(EcsWorld, Config)](EntityCommandBuffer.EntityCommandBuffer(EcsWorld,Config).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.EntityCommandBuffer(Saber7ooth.LeoEcsSaber.EcsWorld, Saber7ooth.LeoEcsSaber.EcsWorld.Config)') | |

| Fields | |
| :--- | :--- |
| [_bufferWorld](EntityCommandBuffer._bufferWorld.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer._bufferWorld') | |
| [_sourceWorld](EntityCommandBuffer._sourceWorld.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer._sourceWorld') | |
| [_sparseEntities](EntityCommandBuffer._sparseEntities.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer._sparseEntities') | |
| [CommandPool](EntityCommandBuffer.CommandPool.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.CommandPool') | |
| [Commands](EntityCommandBuffer.Commands.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.Commands') | |
| [CommandsSequencePool](EntityCommandBuffer.CommandsSequencePool.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.CommandsSequencePool') | |
| [Map](EntityCommandBuffer.Map.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.Map') | |
| [Pools](EntityCommandBuffer.Pools.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.Pools') | |
| [Sequences](EntityCommandBuffer.Sequences.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.Sequences') | |

| Properties | |
| :--- | :--- |
| [GetBufferWorld](EntityCommandBuffer.GetBufferWorld.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.GetBufferWorld') | |
| [GetWorld](EntityCommandBuffer.GetWorld.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.GetWorld') | |
| [Length](EntityCommandBuffer.Length.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.Length') | |

| Methods | |
| :--- | :--- |
| [ClearAll()](EntityCommandBuffer.ClearAll().md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.ClearAll()') | |
| [CreateCommand&lt;TComponent&gt;(int, CommandType, EcsPool&lt;TComponent&gt;, EcbPool&lt;TComponent&gt;)](EntityCommandBuffer.CreateCommand_TComponent_(int,CommandType,EcsPool_TComponent_,EcbPool_TComponent_).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.CreateCommand<TComponent>(int, Saber7ooth.LeoEcsSaber.Extensions.ECB.CommandType, Saber7ooth.LeoEcsSaber.EcsPool<TComponent>, Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbPool<TComponent>)') | |
| [CreateCommand&lt;TComponent&gt;(int, CommandType, EcbPool&lt;TComponent&gt;)](EntityCommandBuffer.CreateCommand_TComponent_(int,CommandType,EcbPool_TComponent_).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.CreateCommand<TComponent>(int, Saber7ooth.LeoEcsSaber.Extensions.ECB.CommandType, Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbPool<TComponent>)') | |
| [CreateCommandEntity(CommandType, int, int)](EntityCommandBuffer.CreateCommandEntity(CommandType,int,int).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.CreateCommandEntity(Saber7ooth.LeoEcsSaber.Extensions.ECB.CommandType, int, int)') | |
| [Destroy(Type)](EntityCommandBuffer.Destroy(Type).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.Destroy(System.Type)') | |
| [ExecuteAll(bool)](EntityCommandBuffer.ExecuteAll(bool).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.ExecuteAll(bool)') | |
| [ExecuteCommandsOnEntity(int, bool)](EntityCommandBuffer.ExecuteCommandsOnEntity(int,bool).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.ExecuteCommandsOnEntity(int, bool)') | |
| [ExecutePackedCommandEntity(EcsPackedEntity, bool)](EntityCommandBuffer.ExecutePackedCommandEntity(EcsPackedEntity,bool).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.ExecutePackedCommandEntity(Saber7ooth.LeoEcsSaber.EcsPackedEntity, bool)') | |
| [ExecuteSequenceStep(int)](EntityCommandBuffer.ExecuteSequenceStep(int).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.ExecuteSequenceStep(int)') | |
| [ExecuteStep(int)](EntityCommandBuffer.ExecuteStep(int).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.ExecuteStep(int)') | |
| [GetCommandsEntity(int)](EntityCommandBuffer.GetCommandsEntity(int).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.GetCommandsEntity(int)') | |
| [GetEcbPool&lt;TComponent&gt;(int, EcsPool&lt;TComponent&gt;)](EntityCommandBuffer.GetEcbPool_TComponent_(int,EcsPool_TComponent_).md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.GetEcbPool<TComponent>(int, Saber7ooth.LeoEcsSaber.EcsPool<TComponent>)') | |
