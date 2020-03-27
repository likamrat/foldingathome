#!/bin/bash

sudo cat <<EOT >> ~/fahclient
#!/bin/sh
/opt/fahclient/FAHClient
EOT

sudo cp ~/fahclient /etc/init.d/
sudo chmod 755 /etc/init.d/fahclient
sudo update-rc.d fahclient defaults
