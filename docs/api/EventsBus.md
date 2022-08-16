#### [LeoEcsSaber](index.md 'index')
### [Saber7ooth.LeoEcsSaber.Extensions.Events](Saber7ooth.LeoEcsSaber.Extensions.Events.md 'Saber7ooth.LeoEcsSaber.Extensions.Events')

## EventsBus Class

```csharp
public class EventsBus
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; EventsBus

| Constructors | |
| :--- | :--- |
| [EventsBus(int, int)](EventsBus.EventsBus(int,int).md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.EventsBus(int, int)') | |

| Fields | |
| :--- | :--- |
| [cachedFilters](EventsBus.cachedFilters.md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.cachedFilters') | |
| [eventsWorld](EventsBus.eventsWorld.md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.eventsWorld') | |
| [singletonEntities](EventsBus.singletonEntities.md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.singletonEntities') | |

| Methods | |
| :--- | :--- |
| [Destroy()](EventsBus.Destroy().md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.Destroy()') | |
| [DestroyEvents&lt;T&gt;()](EventsBus.DestroyEvents_T_().md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.DestroyEvents<T>()') | |
| [DestroyEventSingleton&lt;T&gt;()](EventsBus.DestroyEventSingleton_T_().md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.DestroyEventSingleton<T>()') | |
| [GetDestroyEventsSystem(int)](EventsBus.GetDestroyEventsSystem(int).md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.GetDestroyEventsSystem(int)') | |
| [GetEventBodies&lt;T&gt;(EcsPool&lt;T&gt;)](EventsBus.GetEventBodies_T_(EcsPool_T_).md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.GetEventBodies<T>(Saber7ooth.LeoEcsSaber.EcsPool<T>)') | |
| [GetEventBodySingleton&lt;T&gt;()](EventsBus.GetEventBodySingleton_T_().md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.GetEventBodySingleton<T>()') | |
| [GetEventsWorld()](EventsBus.GetEventsWorld().md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.GetEventsWorld()') | External modification of events world can lead to Unforeseen Consequences |
| [GetFilter&lt;T&gt;()](EventsBus.GetFilter_T_().md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.GetFilter<T>()') | |
| [HasEvents&lt;T&gt;()](EventsBus.HasEvents_T_().md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.HasEvents<T>()') | |
| [HasEventSingleton&lt;T&gt;()](EventsBus.HasEventSingleton_T_().md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.HasEventSingleton<T>()') | |
| [HasEventSingleton&lt;T&gt;(T)](EventsBus.HasEventSingleton_T_(T).md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.HasEventSingleton<T>(T)') | Returns by value, use GetEventBodySingleton to get event body by ref |
| [NewEvent&lt;T&gt;()](EventsBus.NewEvent_T_().md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.NewEvent<T>()') | |
| [NewEventSingleton&lt;T&gt;()](EventsBus.NewEventSingleton_T_().md 'Saber7ooth.LeoEcsSaber.Extensions.Events.EventsBus.NewEventSingleton<T>()') | |
