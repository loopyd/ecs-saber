# Building from source code

1.  Clone the repository to a subfolder of your project root directory.
3.  Add the project solution to your project's solution by running ``dotnet sln add .\LeoEcsSaber\LeoEcsSaber.sln`` in the project root.  This will append the solution included in the project to yours.

## In Visual Studio Code

The project works out of the box with Visual Studio code, and includes a ``.vscode`` subdirectory with a ``tasks.json`` file.

### Debug Configuration

2.  Open the project folder in Visual Studio Code:  ``code .``
3.  Press ``Ctrl + P`` to bring up the command panel and select ``Run Task``, then select the ``[debug] leoecssaber-build`` task.
4.  Output is produced in ``LeoEcsSaber/bin/Debug/netcoreapp3.1/LeoEcsSaber.dll``.  You can include a ``<PackageReference>`` in your ``.csproj``

### Release Configuration

2.  Open the project folder in Visual Studio Code:  ``code .``
3.  Press ``ctrl + P`` to bring up the command panel and select ``Run Task``, then select the ``[debug] leoecssaber-build`` task.

## In Visual Studio IDE

Becuase of the way I have structured the project by dropping dependency references manually into ``.csproj`` for it, it will work in both IDEs.   In Visual Studio, you'll simply right-click your solution after merging with the dotnet tools, with the target set to ``Debug | Any CPU`` or ``Release | Any CPU``, respectively.

### Initial fixups

You need to include a ``<ProjectReference>`` in your ``.csproj`` in an ``<ItemGroup>`` that ignores target framework version: ``<SkipGetTargetFrameworkProperties>true</SkipGetTargetFrameworkProperties>``, and ``<ReferenceOutputAssembly>false</ReferenceOutputAssembly>`` to work around an MsBuild bug when using Visual Studio IDE at all.  Then you can ``<PackageReference>`` the DLL directly.  This stops a string of confusing build erorrs within Visual Studio IDE by defining the symbols in your project, but never actually referencing a project from a different .NET build target directly.

As the LeoEcsSaber project works fundamentally on core data types available in all of ``.NET`` targets, it is safe to do this inside of Visual Studio, but not outside.   Visual Studio IDE will perform the appropriate retargetting automatically at built time, and generate appropriate ``.targets`` files.  This stops that functionality from interfering with MsBuild's in the IDE and producing a ton of incomprehensable gobbledegook errors when trying to use this library.

### Debug Configuration

2.  Open your Solution File in Visual Studio 2022
3.  Right click the solution file for your project and open Solution Properties, change the build target in the properties page for LeoEcs solution underneath your project's "Debug" target to "Debug".
4.  Select "Debug" and "Any CPU" as your solution's base target from the IDE's toolbar.
5.  Build your solution.
6.  Output is produced in ``LeoEcsSaber/bin/Debug/netcoreapp3.1/LeoEcsSaber.dll`` in a seperate MsBuild task, and is referenced in your project when it goes to build correctly.

### Release Configuration

2.  Open your Solution File in Visual Studio 2022
3.  Right click the solution file for your project and open Solution Properties, change the build target in the properties page for LeoEcs solution underneath your project's "Release" target to "Release".
4.  Select "Release" and "Any CPU" as your solution's base target from the IDE's toolbar.
5.  Build your solution.
6.  Output is produced in ``LeoEcsSaber/bin/Debug/netcoreapp3.1/LeoEcsSaber.dll`` in a seperate MsBuild task, and is referenced in your project when it goes to build correctly.