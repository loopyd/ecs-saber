#!/bin/bash

[ -d ./ecs-saber ] && rm -rfv ./ecs-saber
[ -d ./LeoEcsSaber ] && rm -rfv ./LeoEcsSaber
git clone https://github.com/loopyd/ecs-saber.git
cd ./ecs-saber
git checkout master
git clean -dxf
mkdir ../LeoEcsSaber
cp -rfv ./LeoEcsSaber/* ../LeoEcsSaber/
cd ../
rm -rfv ./ecs-saber
dotnet restore
dotnet build --configuration "Debug"
rm -rfv ./LeoEcsSaber