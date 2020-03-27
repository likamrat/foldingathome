#!/bin/bash

sudo apt-get update

# export VERSION="v7.5"

# sudo mkdir -p /opt/fahclient && \
#     # download and untar
# sudo apt-get install -y wget bzip2 && \
# sudo wget https://download.foldingathome.org/releases/public/release/fahclient/debian-stable-64bit/${VERSION}/latest.tar.bz2 -O /tmp/fahclient.tar.bz2 && \
# sudo tar -xjf /tmp/fahclient.tar.bz2 -C /opt/fahclient --strip-components=1 && \
#     # fix permissions
# sudo chown -R folding:folding /opt/fahclient && \
#     # cleanup
# sudo rm -rf /tmp/fahclient.tar.bz2 && \
# sudo apt-get purge -y wget bzip2 && \
# sudo apt-get clean autoclean && \
# sudo apt-get autoremove --yes && \
# sudo rm -rf /var/lib/apt/lists/*

# curl -l https://github.com/likamrat/foldingathome/blob/master/deploy/azure/config.xml -o config.xml
# sudo cp config.xml /opt/fahclient && /
#     cd /opt/fahclient && /
#     ./FAHClient
