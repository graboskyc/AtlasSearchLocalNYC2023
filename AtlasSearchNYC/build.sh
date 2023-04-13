#!/bin/bash

source .env
echo "Using args ${MDBCONNSTR}"

echo
echo "+================================"
echo "| START: Atlas Search for .LOCAL NYC"
echo "+================================"
echo

echo 
echo "AS: Building container"
echo
docker build -t graboskyc/atlassearchfornyc:latest .

echo 
echo "AS: Starting container"
echo

docker stop atlassearchfornyc
docker rm atlassearchfornyc
docker run -t -i -d -p 9999:80 --name atlassearchfornyc -e "MDBCONNSTR=${MDBCONNSTR}" --restart unless-stopped graboskyc/atlassearchfornyc:latest

echo
echo "+================================"
echo "| END: Atlas Search for .LOCAL NYC"
echo "+================================"
echo
