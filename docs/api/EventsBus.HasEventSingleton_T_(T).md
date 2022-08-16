#### [LeoEcsSaber](index.md 'index')
### [Saber7ooth.LeoEcsSaber.Extensions.Events](Saber7ooth.LeoEcsSaber.Extensions.Events.md 'Saber7ooth.LeoEcsSaber.Extensions.Events').[EventsBus](EventsBus.md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus')

## EventsBus.HasEventSingleton<T>(T) Method

Returns by value, use GetEventBodySingleton to get event body by ref

```csharp
public bool HasEventSingleton<T>(out T eventBody)
    where T : struct, Saber7ooth.LeoEcsSaber.Extensions.Events.IEventSingleton, System.ValueType, System.ValueType;
```
#### Type parameters

<a name='Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.HasEventSingleton_T_(T).T'></a>

`T`
#### Parameters

<a name='Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.HasEventSingleton_T_(T).eventBody'></a>

`eventBody` [T](EventsBus.HasEventSingleton_T_(T).md#Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.HasEventSingleton_T_(T).T 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.HasEventSingleton<T>(T).T')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')