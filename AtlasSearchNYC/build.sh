#!/bin/bash

source .env
echo "Using args ${MDBCONNSTR}"
echo "Using args ${OPENAIAPIKEY}"

echo
echo "+================================"
echo "| START: Atlas Search for .LOCAL NYC"
echo "+================================"
echo

datehash=`date | md5sum | cut -d" " -f1`
abbrvhash=${datehash: -8}

echo 
echo "AS: Building container"
echo
docker build -t graboskyc/atlassearchfornyc:latest -t graboskyc/atlassearchfornyc:${abbrvhash} .

EXITCODE=$?

echo 
echo "AS: Starting container"
echo

if [ $EXITCODE -eq 0 ]
    then

    docker stop atlassearchfornyc
    docker rm atlassearchfornyc
    docker run -t -i -d -p 9999:80 --name atlassearchfornyc -e "MDBCONNSTR=${MDBCONNSTR}" -e "OPENAIAPIKEY=${OPENAIAPIKEY}" -e "OPENAIDEPLOYMENT=${OPENAIDEPLOYMENT}" -e "OPENAIENDPOINT=${OPENAIENDPOINT}" --restart unless-stopped graboskyc/atlassearchfornyc:latest
    echo "Tagged latest and ${abbrvhash}"

    echo
    echo "+================================"
    echo "| END: Atlas Search for .LOCAL NYC"
    echo "+================================"
    echo

else
    echo
    echo "+================================"
    echo "| ERROR: Build failed"
    echo "+================================"
    echo
fi
