#!/bin/bash

#install the latest nvidia gpu drivers
sudo add-apt-repository -y ppa:graphics-drivers
sudo apt-get install -y nvidia-driver-430
sudo apt install -y ocl-icd-opencl-dev
sudo apt-get update

export VERSION="v7.6"

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

sudo cat <<EOT >> /opt/fahclient/config.xml
<config>
  <user value="Anonymous"/>
  <team value="999"/>      
  <passkey value=""/>      

  <power value="full"/>
  <gpu value="true"/>
  <fold-anon value="false"/>

  <allow v='127.0.0.1 0/0'/>
  <web-allow v='127.0.0.1 0/0'/>
  
  <slot id="0" type="CPU"/>
  <slot id="-1" type="GPU"/>  
</config>
EOT

echo "@reboot cd /opt/fahclient && ./FAHClient" | crontab -

sudo cat <<EOT >> run_fah.sh
#!/bin/bash
cd /opt/fahclient && ./FAHClient
EOT

sudo chmod +x run_fah.sh

at now + 3 minutes -f run_fah.sh
