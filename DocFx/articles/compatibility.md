# Compatibility Notes

## IDE Compatibility

**Visual Studio Code** is recommended to work with and build LeoEcsSaber fork.  I do not offer support for full installations of Visual Studio, but I __have__ provided a compatible solution file that will work out of the box in Visual Studio with the Debug and Release configurations nessecary included.

## Game Engine Compatibility

If this is a question you have, you probably shouldn't be touching LeoEcsSaber-- as your Game Engine already includes an ECS Framework.  An Engine usually includes a bunch of other frameworks, like this one.  The work in most modern game engines is done.  If you are however, customizing your own Game Engine, this is going to be a good choice for you.

I will provide the breakdown of which Game **Frameworks** this project applies to, and which **Game Engines** you shouldn't consider importinng this project into:

### Invalid Game Engine Choices for LeoEcsSaber

- **Unity** - Your available ECS is DOTS.  DOTS provides a highly optimized ECS framework maintained by Unity Engine developers themselfs.  You should consider using DOTS instead if you are working with Unity.
- **Unreal Engine** - Your available ECS is the default AActor (Entity)/UComponent (Component)/UObject (System) Model).  ECS is a fundamental part of the Unreal Engine, by the design of the UOM (Unreal Object Model).  You do not need to consider adding an independent framework and should not.
- **GoDot** - Nodes are fundamentally ECS structures and are handled the same way by GoDot's object model.  You have no need to use LeoEcsSaber if you use the GoDot Game Engine.

### Valid Game Framework Choices for LeoEcsSaber

- **Simple DirectMedia Layer 2 (SDL2)** - Doesn't include an ECS as is a core graphics framework, would benefit from one with a wrapper around the DLL symbols in LeoEcsSaber's case.
- **libgdx-dev** - Absolutely would benefit from the inclusion of an ECS framework like LeoEcsSaber.
- **MonoGame** - Where ``MonoGame.Extensions.Entities`` is an inferior approach to ECS lacking CPU cache abuse and entity pooling via a world object model, and would benefit from a better one like this.
- **Cocos2DX** - Is a core game frameowrk and will benefit from one as like MonoGame's, its lacks efficiency.
- **PyGLUT** / **PyGame** - It is of great benefit to import an ECS coming from a more efficient language.  Static compilation and wrapping in a pyc DLL wrapper will provide good results rather than having to implement the entire thing in an interpreted language like python.

