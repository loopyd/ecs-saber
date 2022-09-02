@echo off

if exist ./ecs-saber (
    del /s /q ecs-saber
)
if exist ./LeoEcsSaber (
    del /s /q LeoEcsSaber
)
git clone https://github.com/loopyd/ecs-saber.git
xcopy "./ecs-saber/LeoEcsSaber" "./LeoEcsSaber" /e