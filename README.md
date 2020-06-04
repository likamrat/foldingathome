# FOLDING@HOME Team 999 - Microsoft fight on COVID-19

From the FAH team [website](https://foldingathome.org/about/):

"Folding@home (FAH or F@h) is a distributed computing project for simulating protein dynamics, including the process of protein folding and the movements of proteins implicated in a variety of diseases. It brings together citizen scientists who volunteer to run simulations of protein dynamics on their personal computers. Insights from this data are helping scientists to better understand biology, and providing new opportunities for developing therapeutics."

The [FAH GitHub repo](https://github.com/FoldingAtHome/coronavirus) had additional details about it's implementation for the COVID-19.

## How does it work?

The FAH team are really the experts! Visit the [FAQ page](https://foldingathome.org/category/how-fah-works/) to learn more. 

## Why did I created this repo?

I wanted to contribute to the effort fighting COVID-19, raising awareness as well as making sure people can deploy and start folding an easy fashion as fast as possible. 

## Let's get started

I have created multiple instructions on how to deploy the FAH client based on the deployment scenarios below.

* [I am a Windows user and just want to install the client and start folding](docs/Windows.md)
* [I am a MacOS user and just want to install the client and start folding](docs/MacOS.md)
* [I have an Ubuntu Server which I want to use and start folding](docs/UbuntuServer.md)
* [I don't want to install anything locally but I'm cool with deploying a Docker container](docs/Docker.md)
* [I want to use a "Ready-to-go" Azure VM to do the heavy lifting](docs/Azure.md)
* [I want to use a "Ready-to-go" Azure GPU enabled VM to do the heavy lifting](docs/AzureGPU.md)

## Dashboards

While there are several statistics reports avaialble at http://stats.foldingathome.org, you may want to explore the data in other more graphical formats.  There are several tools avaialbe for data visualization that can leverage the data behind the Folding@Home APIs.  

* [Folding Power BI Dashboard](dashboards/PowerBI/README.md)

## The Folding@Home Chat Bot

To help answering Folding@Home FAQ, you can use the [Chat Bot](ChatBot/README.md).

## Contributing

Before contributing code, please see the [CONTRIBUTING](CONTRIBUTING.md) guide.

Issues, PRs and Feature Request have their own templates. Please fill out the whole template.
