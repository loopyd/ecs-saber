#### [LeoEcsSaber](index.md 'index')
### [Saber7ooth.LeoEcsSaber.Extensions.ECB](Saber7ooth.LeoEcsSaber.Extensions.ECB.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB').[EcbSystem](EcbSystem.md 'Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbSystem')

## EcbSystem.ExecutePackedCommand(EcsPackedEntity, bool) Method

Execute concrete packed command.

```csharp
protected void ExecutePackedCommand(ref Saber7ooth.LeoEcsSaber.EcsPackedEntity sequence, bool autoClear=true);
```
#### Parameters

<a name='Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbSystem.ExecutePackedCommand(Saber7ooth.LeoEcsSaber.EcsPackedEntity,bool).sequence'></a>

`sequence` [EcsPackedEntity](EcsPackedEntity.md 'Saber7ooth.LeoEcsSaber.EcsPackedEntity')

<a name='Saber7ooth.LeoEcsSaber.Extensions.ECB.EcbSystem.ExecutePackedCommand(Saber7ooth.LeoEcsSaber.EcsPackedEntity,bool).autoClear'></a>

`autoClear` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Set false if you want to clear Command Buffer manually. True by default