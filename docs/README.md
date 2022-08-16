# The fork with big teeth!
The main changes on this fork of the LeoEcs engine framework include:  

* Declaring independency from MIT license via extensive modification of code, additional documentation and taking on of community support for this fork.
* Full Russian to English translation for documentation
* XML documentation of every method and property to make things more friendly to Visual Studio [Code] users.
* Git Docs powered by jeckyll and API markdown auto-generation.

> ** IMPORTANT!** Do not forget use `DEBUG`- version builds for development and `RELEASE`- versions builds for releases: all domestic checks / exceptions will work only in `DEBUG` versions and removed for increased performance in `RELEASE` versions of this fork.

# Content
* [ Social resources ](#Social-resources)
* [ Installation ](#Installation)
* * [ As a git submodule ](#as-submodule)

* [ License ](#License)
* [ FAQ ](#FAQ)

# Social Links
[![twitter](https://www.twitter.com/saber7ooth)

# Installation

## As a git submodule

### Step 1 - Add the submodule
Add this repository as a submodule to your existing project repository by first issuing the ``git submodule`` command in the following way:

```bash
cd myProjectRootDir
git submodule add "https://github.com/loopyd/ecs-saber"
```
### Step 2 - Reference the project
You will then need to reference this project's ``ecslite.csproj`` in your main project's ``.csproj`` file.  You can do so by adding the following lines:

```xml
  <ItemGroup>
    <ProjectReference Include="..\ecslite\ecslite.csproj" />
  </ItemGroup>
```

If you put the submodule somewhere else, please make sure that this matches the relative installation directory of the submodule.

### Step 3 - Rebuild your project's solution

You can do this via your IDE.  The ``ecslite.csproj`` included with the repository will automatically instruct the MSBuild compiler to build the ECS engine as a dynamic-link library (dll) file, and statically link it to your project.

**You're done!**

# Basic types

## Entity
Herself on yourself nothing not means not _ exists , is exclusively container for components . Implemented as `int`:
``` c#
// Create new essence in the world .
int entity = _world.NewEntity ();

// Any essence maybe to be removed , when this first all Components will automatically removed and only after entity will be reckon destroyed .
world.DelEntity (entity);
```

> ** IMPORTANT!* * Entities not may exist without components and will automatically be destroyed at removal last component on the them .

## Component
Is container for data user and not must contain logic ( allowed minimal helpers , but not pieces basic logic ):
``` c#
struct Component1 {
public int Id;
public stringName ;
}
```
Components may to be added , requested or removed via [ component pools ]( #ecspool).

## System
Is container for basic logic for processing filtered entities . Exists in the form custom class that implements how minimum one from ` IEcsInitSystem `, ` IEcsDestroySystem `, ` IEcsRunSystem ` (and other supported ) interfaces :
```c#
class UserSystem : IEcsPreInitSystem, IEcsInitSystem, IEcsRunSystem, IEcsDestroySystem, IEcsPostDestroySystem {
    public void PreInit (IEcsSystems systems) {
// Will called one once a moment work IEcsSystems.Init () and before triggering IEcsInitSystem.Init ().
}
    
public void Init( IEcsSystems systems) {
// Will called one once a moment work IEcsSystems.Init () and after triggering IEcsPreInitSystem.PreInit ().
}
    
public void Run( IEcsSystems systems) {
// Will called one once a moment work IEcsSystems.Run ().
}

public void Destroy( IEcsSystems systems) {
// Will called one once a moment work IEcsSystems.Destroy () and before triggering IEcsPostDestroySystem.PostDestroy ().
}
    
public void PostDestroy ( IEcsSystems systems) {
// Will called one once a moment work IEcsSystems.Destroy () and after triggering IEcsDestroySystem.Destroy ().
}
}
```

# Joint usage data
instance any custom type ( class ) can to be simultaneously connected to everyone systems :
``` c#
class SharedData {
public string PrefabsPath ;
}
...
SharedData sharedData = new SharedData { PrefabsPath = "Items/{0}" };
IEcsSystems systems = new EcsSystems (world, sharedData);
systems
    .Add (new TestSystem1 ())
    .Init ();
...
class TestSystem1 : IEcsInitSystem {
    public void Init(IEcsSystems systems) {
        SharedData shared = systems.GetShared < SharedData >();
string prefabPath = string.Format ( shared.PrefabsPath , 123);
// prefabPath = "Items/123" to this moment .
}
}
```

# Special types

## EcsPool
Is container for components , provides api for add / request / delete components on the entities :
``` c#
int entity = world.NewEntity ();
EcsPool <Component1>pool = world.GetPool <Component1>();

// Add( ) adds component to entity . If a component already exists - will be abandoned exception in DEBUG version .
ref Component1 c1 = ref pool.Add (entity);

// Has( ) checks Availability component on the entities .
bool c1Exists = pool.Has (entity);

// Get( ) returns existing on the entities component . If a component not exists - will be abandoned exception in DEBUG version .
ref Component1 c1 = ref pool.Get (entity);

// Del( ) removes component from entity . If a component not was - none mistakes not will be . If a this is was last component - entity will be removed automatically .
pool.Del (entity);
```

> ** IMPORTANT!* * After delete , component will be placed in a pool for subsequent reuse . All fields component will reset to values on default automatically .

## EcsFilter
Is container for storage filtered entities on availability or absence certain components :
``` c#
class WeaponSystem : IEcsInitSystem , IEcsRunSystem {
public void Init( IEcsSystems systems) {
// Get copy peace on default .
        EcsWorld world = systems.GetWorld ();
        
// Create new essence .
        int entity = world.NewEntity ();
        
        // И добавляем к ней компонент "Weapon".
        var weapons = world.GetPool<Weapon>();
        weapons.Add (entity);
    }

    public void Run (IEcsSystems systems) {
        EcsWorld world = systems.GetWorld ();
// We want get all entities with and without the "Weapon" component component "Health".
// Filter maybe going to dynamically each times , maybe to be cached somewhere .
var filter = world.Filter <Weapon>(). Exc <Health>().End();
        
// Filter stores only entities , themselves data lie in the pool "Weapon" components .
// Pool So same maybe to be cached somewhere .
        var weapons = world.GetPool<Weapon>();
        
        foreach (int entity in filter) {
            ref Weapon weapon = ref weapons.Get (entity);
            weapon.Ammo = System.Math.Max (0, weapon.Ammo - 1);
        }
    }
}
```

Additional filtering requirements _ entities may to be added through methods `Inc< >( )` / ` Exc <>()`.

> ** IMPORTANT!* * Filters support any amount component requirements , but _ one and the same same component not maybe be in the "include" and "exclude" lists .

## Ecs World
Is container for all entities , components pools and filters , data everyone instance unique and isolated from others worlds .

> ** IMPORTANT!* * Required call ` EcsWorld.Destroy ()` on an instance peace if he more not need .

## EcsSystems
Is container for systems that _ will be handle ` EcsWorld ` -instance world :
``` c#
class Startup : MonoBehavior {
    EcsWorld_world ; _
    IEcsSystems_systems ; _

void Start() {
// Create environment , connect systems .
_world = new EcsWorld ( );
_systems = new EcsSystems (_world );
_systems
            .Add (new WeaponSystem ())
            .init ();
}
    
void Update() {
// Execute all connected systems .
_systems ?. run ();
}

void OnDestroy () {
// Destroy connected systems .
if (_ systems ! = null) {
_systems.Destroy ( );
_systems = null;
}
// Clear environment .
if (_ world ! = null) {
_world.destroy ( );
_world = null;
}
}
}
```

> ** IMPORTANT!* * Required call ` IEcsSystems.Destroy ()` on an instance groups systems if he more not need .

# Integration with engines

## Unity
> Checked on Unity 2020.3 ( not depends from it ) and contains asmdef descriptions for compilation in the form individual assemblies and reduction time recompilation main project .

[ Unity editor integration ]( https://github.com/Leopotam/ecslite-unityeditor) contains templates code , as well same provides monitoring states peace .

## custom engine
> For use framework requires C#7.3 or above .

Each part example below must to be correctly integrated into the right place fulfillment code engine :
``` c#
using Leopotam. EcsLite ;

class EcsStartup {
    EcsWorld_world ; _
    IEcsSystems_systems ; _

// initialization environment .
void Init() {
_world = new EcsWorld ( );
_systems = new EcsSystems (_world );
_systems
// Additional instances worlds
// must to be registered here .
/ / . AddWorld ( customWorldInstance , "events")
            
// Systems with primary logic must
// be registered here .
// .Add (new TestSystem1())
// .Add (new TestSystem2())
            
            .init ();
}

// Method must to be called from
// main update- loop engine .
void UpdateLoop () {
        _systems?.Run ();
    }

    // Очистка окружения.
    void Destroy () {
        if (_systems != null) {
            _systems.Destroy ();
            _systems = null;
        }
        if (_world != null) {
            _world.Destroy ();
            _world = null;
        }
    }
}
```

# Articles

* [" Creating a dungeon crawler with LeoECS Lite. Part 1 "]( https://habr.com/ru/post/661085/)
  [![ ](https://habrastorage.org/r/w1560/getpro/habr/upload_files/372/b1c/ad3/372b1cad308788dac56f8db1ea16b9c9.png)](https://habr.com/ru/post/661085/)
* [" Creating a dungeon crawler with LeoECS Lite. Part 2 "]( https://habr.com/en/post/673926/)
  [![ ](https://habrastorage.org/r/w1560/getpro/habr/upload_files/63f/3ef/c47/63f3efc473664fdaaf1a249f258e2486.png)](https://habr.com/ru/post/673926/)
* [" All what need know about ECS "]( https://habr.com/ru/post/665276/)
  [![ ](https://habrastorage.org/r/w1560/getpro/habr/upload_files/3fd/5bc/544/3fd5bc5442b03a20d52a8003576056d4.png)](https://habr.com/ru/post/665276/)

# Projects using _ LeoECS Lite
## С исходниками
* ["3D Platformer"](https://github.com/supremestranger/3D-Platformer-Lite)

  [![](https://camo.githubusercontent.com/dcd2f525130d73f4688c1f1cfb12f6e37d166dae23a1c6fac70e5b7873c3ab21/68747470733a2f2f692e6962622e636f2f686d374c726d342f506c6174666f726d65722e706e67)](https://github.com/supremestranger/3D-Platformer-Lite)


* ["SharpPhysics2D"](https://github.com/7Bpencil/sharpPhysics)

  [![](https://github.com/7Bpencil/sharpPhysics/raw/master/pictures/preview.png)](https://github.com/7Bpencil/sharpPhysics)


* ["YourVostok"](https://github.com/7Bpencil/YourVostok)

  [![ ](https://github.com/7Bpencil/YourVostok/raw/master/Previews/preview.gif)](https://github.com/7Bpencil/YourVostok)


# Extensions
* [ Injection dependencies ]( https://github.com/Leopotam/ecslite-di)
* [ Extended systems ]( https://github.com/Leopotam/ecslite-extendedsystems)
* [ Support multithreading ]( https://github.com/Leopotam/ecslite-threads)
* [Интеграция в редактор Unity](https://github.com/Leopotam/ecslite-unityeditor)
* [Поддержка Unity uGui](https://github.com/Leopotam/ecslite-unity-ugui)
* [UniLeo - Unity scene data converter](https://github.com/voody2506/UniLeo-Lite)
* [Unity Physx events support](https://github.com/supremestranger/leoecs-lite-physics)
* [Multiple Shared injection](https://github.com/GoodCatGames/ecslite-multiple-shared)
* [ EasyEvents ](https://github.com/7Bpencil/ecslite-easyevents)
* [Entity command buffer]( https://github.com/JimboA/EcsLiteEntityCommandBuffer)

# License
framework issued under two licenses , [ details here ]( ./LICENSE.md).

In cases licensing on MIT-Red conditions are not costs count on the
personal consultations or any guarantee .

# FAQ

### What difference from old versions LeoECS ?

I prefer call their ` lite ` ( ecs -lite) and ` classic ` ( leoecs ). Main the differences between ` light ` are as follows :
* Code base framework decreased by 2 times _ became easier support and expand .
* Absence any static data in the kernel .
* Absence caches components in filters is _ reduces consumption memory and increase speed shifting entities on filters .
* Fast access to any component on the any entity ( not only filtered and through cache filter ).
* No restrictions on the amount requirements / restrictions on components for filters .
* General linear performance close to ` classic` , but access to components , rearrangement entities on filters became disproportionately faster .
* Scope on the usage multiworlds - several copies worlds along with the division on him data for optimization consumption memory .
* Absence reflections in the kernel , perhaps usage aggressive cutting out unused code compiler (code stripping, dead code elimination).
* Joint usage general data between systems going on without reflections ( if she is allowed , then recommended use extension ` ecslite -di` from list extensions ).
* Implementation entities returned to normal type `int`, this reduced consumption memory . If a entities need save somewhere - them still need pack in special structure .
* Small core , whole additional functional implemented through connection optional extensions .
* Whole new functional will be go out only to ` light ` - version , ` classic ` switched to support on the correction errors .

### I want one system call in ` MonoBehaviour.Update ()` , and the other in ` MonoBehaviour.FixedUpdate ()`. How can I this is to do ?

For separation systems on the basis different methods from ` MonoBehaviour ` is necessary create under each method separate ` IEcsSystems ` group :
``` c#
IEcsSystems _update;
IEcsSystems _fixedUpdate;

void Start () {
    EcsWorld world = new EcsWorld ();
    _update = new EcsSystems (world);
    _update
        .Add (new UpdateSystem ())
        .Init ();
    _fixedUpdate = new EcsSystems (world);
    _fixedUpdate
        .Add (new FixedUpdateSystem ())
        .Init ();
}

void Update () {
    _update?.Run ();
}

void FixedUpdate () {
    _fixedUpdate?.Run ();
}
```

### Me not suit values on default for fields components . How can I this is set up ?

Components support custom setting values through implementation interface ` IEcsAutoReset <>`:
``` c#
struct MyComponent : IEcsAutoReset < MyComponent > {
public int Id;
public object LinkToAnotherComponent ;

    public void AutoReset (ref MyComponent c) {
        c.Id = 2;
        c.LinkToAnotherComponent = null;
    }
}
```
This method will be automatically be called for all new components , as well same for all only what remote , up to premises them to the pool .
> ** IMPORTANT!* * In case of applications of ` IEcsAutoReset ` all additional cleaning / checking fields component turn off that maybe lead to leaks memory . A responsibility lies on the user !

### I want save link on the entity in the component . How can I this is to do ?

For conservation links on the essence her necessary pack in one from special containers (` EcsPackedEntity ` or ` EcsPackedEntityWithWorld `):
``` c#
EcsWorld world = new EcsWorld ();
int entity = world.NewEntity ();
EcsPackedEntity packed = world.PackEntity (entity);
EcsPackedEntityWithWorld packedWithWorld = world.PackEntityWithWorld (entity);
...
// At the moment unpacking we check - alive this essence or already no .
if ( packed. Unpack (world, out int unpacked)) {
// "unpacked" is valid essence and we Can her use .
}

// At the moment unpacking we check - alive this essence or already no .
if ( packedWithWorld. Unpack (out EcsWorld unpackedWorld , out int unpackedWithWorld )) {
// " unpackedWithWorld " is valid essence and we Can her use .
}
```

### I want add reactivity and process developments changes in the world yourself . How can I do is it ?

> ** IMPORTANT!* * So do not recommended due to fall performance .

For activation this functionality should add `LEOECSLITE_WORLD_EVENTS` to the list directives compiler and then add _ listener events :

``` c#
class TestWorldEventListener : IEcsWorldEventListener {
public void OnEntityCreated (int entity) {
// Entity created - method will be called at the moment call world.NewEntity ().
}

public void OnEntityChanged (int entity) {
// Entity changed - method will be called at the moment call pool.Add () / pool.Del ().
}

public void OnEntityDestroyed (int entity) {
// Entity destroyed - method will be called at the moment call world.DelEntity () or at moment removal last component .
}

public void OnFilterCreated ( EcsFilter filter) {
// Filter created - method will be called at the moment call world.Filter ().End() if filter not existed before .
}

public void OnWorldResized (int newSize ) {
// World changed dimensions - method will be called in case changes sizes caches under essence at the moment call world.NewEntity ().
}

public void OnWorldDestroyed ( EcsWorld world) {
// World destroyed - method will be called at the moment call world.Destroy ().
}
}
...
= new EcsWorld ( );
var listener = new TestWorldEventListener ( );
world.AddEventListener (listener);
```

### I want add reactivity and processing developments changes filters . How can I this is to do ?

> ** IMPORTANT!* * So do not recommended due to fall performance .

For activation this functionality should add `LEOECSLITE_FILTER_EVENTS` to the list directives compiler and then add _ listener events :

``` c#
class TestFilterEventListener : IEcsFilterEventListener {
public void OnEntityAdded (int entity) {
// Entity added to filter .
}

public void OnEntityRemoved (int entity) {
// Entity deleted from filter .
}
}
...
= new EcsWorld ( );
var filter = world.Filter <C1>().End();
var listener = new TestFilterEventListener ( );
filter.AddEventListener (listener);
```
