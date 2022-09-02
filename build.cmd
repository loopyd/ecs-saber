@echo off

if exist ./ecs-saber (
    rmdir /s /q ecs-saber
)
if exist ./LeoEcsSaber (
    rmdir /s /q LeoEcsSaber
)
git clone https://github.com/loopyd/ecs-saber.git
cd ./ecs-saber
git checkout master
git clean -dxf
xcopy "./LeoEcsSaber" "../LeoEcsSaber" /a /e /k /i /y
cd ../
rmdir /s /q ecs-saber
dotnet restore
dotnet build --configuration "Debug"
rmdir /s /q LeoEcsSaber
