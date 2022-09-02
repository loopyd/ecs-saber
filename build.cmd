@echo off

if exist ./ecs-saber (
    del /s /q ecs-saber
)
if exist ./LeoEcsSaber (
    del /s /q LeoEcsSaber
)
git clone https://github.com/loopyd/ecs-saber.git
cd ./ecs-saber
git checkout master
git clean -dxf
xcopy "./LeoEcsSaber" "../LeoEcsSaber" /a /e /k
cd ../
del /s /q ecs-saber
dotnet restore
dotnet build --configuration "Debug"
del /s /q LeoEcsSaber
