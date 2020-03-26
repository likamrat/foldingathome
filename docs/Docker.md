# Prerequisites

Although this seems to be a more "advanced" way of deploy FAH, it's really not!
The entire point is to deploy an isolated environment without having anything installed locally. 

* Well, you will need to [download & install Docker](https://www.docker.com/products/docker-desktop) on your machine (dahhhh :smile:)

* The Docker image is stored in an [Azure Container Registry (ACR)](https://azure.microsoft.com/en-us/services/container-registry/#security) with no Anonymous access enabled. Prior to running the container, log in to the mentioned ACR:

```docker login -u pulltoken -p 4A=jBw69CoMNqLq2Lqrb2YVapQWPC19e liordevacr.azurecr.io```

# Running to container

To run the container, simply run below command in your terminal.

```docker run \
 --name folding-at-home \
 -p 7396:7396 \
 -p 36330:36330 \
 --restart unless-stopped \
 liordevacr.azurecr.io/msfolding/msfolding:latest