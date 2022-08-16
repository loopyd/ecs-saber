#### [LeoEcsSaber](index.md 'index')
### [Saber7ooth.LeoEcsSaber.Extensions.ECB](Saber7ooth.LeoEcsSaber.Extensions.ECB.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB').[EntityCommandBuffer](EntityCommandBuffer.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer')

## EntityCommandBuffer.CreateCommand<TComponent>(int, CommandType, EcsPool<TComponent>, EcbPool<TComponent>) Method

```csharp
internal int CreateCommand<TComponent>(int entity, Saber7ooth.LeoEcsSaber.Extensions.ECB.CommandType type, Saber7ooth.LeoEcsSaber.EcsPool<TComponent> sourcePool, out Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbPool<TComponent> ecbPool)
    where TComponent : struct, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.CreateCommand_TComponent_(int,Saber7ooth.LeoEcsSaber.Extensions.ECB.CommandType,Saber7ooth.LeoEcsSaber.EcsPool_TComponent_,Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbPool_TComponent_).TComponent'></a>

`TComponent`
#### Parameters

<a name='Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.CreateCommand_TComponent_(int,Saber7ooth.LeoEcsSaber.Extensions.ECB.CommandType,Saber7ooth.LeoEcsSaber.EcsPool_TComponent_,Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbPool_TComponent_).entity'></a>

`entity` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.CreateCommand_TComponent_(int,Saber7ooth.LeoEcsSaber.Extensions.ECB.CommandType,Saber7ooth.LeoEcsSaber.EcsPool_TComponent_,Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbPool_TComponent_).type'></a>

`type` [CommandType](CommandType.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.CommandType')

<a name='Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.CreateCommand_TComponent_(int,Saber7ooth.LeoEcsSaber.Extensions.ECB.CommandType,Saber7ooth.LeoEcsSaber.EcsPool_TComponent_,Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbPool_TComponent_).sourcePool'></a>

`sourcePool` [Saber7ooth.LeoEcsSaber.EcsPool&lt;](EcsPool_T_.md 'Saber7ooth.LeoEcsSaber.EcsPool<T>')[TComponent](EntityCommandBuffer.CreateCommand_TComponent_(int,CommandType,EcsPool_TComponent_,EcbPool_TComponent_).md#Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.CreateCommand_TComponent_(int,Saber7ooth.LeoEcsSaber.Extensions.ECB.CommandType,Saber7ooth.LeoEcsSaber.EcsPool_TComponent_,Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbPool_TComponent_).TComponent 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.CreateCommand<TComponent>(int, Saber7ooth.LeoEcsSaber.Extensions.ECB.CommandType, Saber7ooth.LeoEcsSaber.EcsPool<TComponent>, Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbPool<TComponent>).TComponent')[&gt;](EcsPool_T_.md 'Saber7ooth.LeoEcsSaber.EcsPool<T>')

<a name='Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.CreateCommand_TComponent_(int,Saber7ooth.LeoEcsSaber.Extensions.ECB.CommandType,Saber7ooth.LeoEcsSaber.EcsPool_TComponent_,Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbPool_TComponent_).ecbPool'></a>

`ecbPool` [Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbPool&lt;](EcbPool_TComponent_.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbPool<TComponent>')[TComponent](EntityCommandBuffer.CreateCommand_TComponent_(int,CommandType,EcsPool_TComponent_,EcbPool_TComponent_).md#Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.CreateCommand_TComponent_(int,Saber7ooth.LeoEcsSaber.Extensions.ECB.CommandType,Saber7ooth.LeoEcsSaber.EcsPool_TComponent_,Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbPool_TComponent_).TComponent 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EntityCommandBuffer.CreateCommand<TComponent>(int, Saber7ooth.LeoEcsSaber.Extensions.ECB.CommandType, Saber7ooth.LeoEcsSaber.EcsPool<TComponent>, Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbPool<TComponent>).TComponent')[&gt;](EcbPool_TComponent_.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbPool<TComponent>')

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')