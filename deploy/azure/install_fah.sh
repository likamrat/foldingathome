#!/bin/bash

sudo apt-get update

sudo cat <<EOT >> config.xml
<config>
  <!-- User Information -->
  <user value="Anonymous"/> <!-- Enter your user name here -->
  <team value="999"/>         <!-- Your team number -->
  <passkey value=""/>       <!-- 32 hexadecimal characters if provided -->

  <power value="full"/>
  <gpu value="false"/>      <!-- If true, attempt to autoconfigure GPUs -->
  <fold-anon value="false"/>

  <!-- Folding Slots
    No folding slot configuration is necessary.  The client will
    automaticlaly choose a good configuration for you.  However, here
    are some examples:
  
      <slot id="0" type="CPU"/>

    or
    
      <slot id="0" type="CPU"/>
      <slot id="1" type="GPU"/>

    All slots in a configuration MUST have unique ids.
   -->

  Granting Remote FAHControl Access
    To grant remote access to FAHControl and the remote command server add
    the following:

       <allow v='127.0.0.1 0/0'/>
      <!-- <password>PASS</password> -->

    Where x.x.x.x is the IP address of the computer which should be granted
    remote access and PASS is you choose to further secure the connection.
 

  Granting Remote Web Access
    If you would like to grant remote Web access then you need these two
    configuration lines:

    <!-- HTTP Server -->

    <allow v='127.0.0.1 0/0'/>

    <!-- Web Server -->

    <web-allow v='127.0.0.1 0/0'/>

    Where x.x.x.x is the IP address of the computer which should be granted
    remote access.  You may also need to open port 7396 on your firewall.

    You can then access the Web interface remotely by going to this address:

      http://y.y.y.y:7396/

    Where y.y.y.y is the IP address of this computer.
 
</config>
EOT

export VERSION="v7.5"

sudo mkdir -p /opt/fahclient && \
    # download and untar
sudo apt-get install -y wget bzip2 && \
sudo wget https://download.foldingathome.org/releases/public/release/fahclient/debian-stable-64bit/${VERSION}/latest.tar.bz2 -O /tmp/fahclient.tar.bz2 && \
sudo tar -xjf /tmp/fahclient.tar.bz2 -C /opt/fahclient --strip-components=1 && \
    # fix permissions
sudo chown -R folding:folding /opt/fahclient && \
    # cleanup
sudo rm -rf /tmp/fahclient.tar.bz2 && \
sudo apt-get purge -y wget bzip2 && \
sudo apt-get clean autoclean && \
sudo apt-get autoremove --yes && \
sudo rm -rf /var/lib/apt/lists/*

sudo cp config.xml /opt/fahclient && /
    cd /opt/fahclient && /
    ./FAHClient
