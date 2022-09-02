#!/bin/bash

CONFIGURATION="$1"
SRC_BRANCH="$2"
REPO_ORG="$3"
REPO_PROJECT="$4"
LIBRARY_NAME="$5"

[ -d "./${REPO_PROJECT}" ] && rm -rfv ./${REPO_PROJECT}
[ -d "./${LIBRARY_NAME}" ] && rm -rfv ./${LIBRARY_NAME}
git clone https://github.com/${REPO_ORG}/${REPO_PROJECT}.git
cd ./${REPO_PROJECT}
git checkout ${SRC_BRANCH}
git clean -dxf
mkdir ../${LIBRARY_NAME}
cp -rfv ./${LIBRARY_NAME}/* ../${LIBRARY_NAME}/
cd ../
rm -rfv ./${REPO_PROJECT}
dotnet restore
dotnet build --configuration "${CONFIGURATION}"
rm -rfv ./${LIBRARY_NAME}