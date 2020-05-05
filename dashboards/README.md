# FOLDING@HOME OCP Dashboard

In order to track folding activities by team, there is a Power BI report that exercises the folding.org APIs.  This dashboard shows the following information:
1. Folding Score by Team
1. Work Units by Team
1. Participants by Team
1. Units and Score by User Name.

In addition clicking on any bar in the chart will filter the list down to just the participants with that team.

![](../img/FoldingDashboard.png)

## Using the dashboard

The Power BI dashboard is setup to work with a parametrized list of teams.  Please use the following stesps to consume the dashbard on your local machine:
1. Download the pbix file from [/dashboards/FoldingDashboard.pbix](./FoldingDashboard.pbix)
1. Open the file in Power BI desktop
1. Click on the left navigation to switch to the tabular view of the model

    ![](../img/PowerBI-01.png)
1. Click on the "Transform Data" button and select the "Edit Parameters" button

    ![](../img/PowerBI-02.png)
1. Enter a comma separated list of TeamIds to load, and click "Ok"

    ![](../img/PowerBI-03.png)

1. Click "Refresh"

Note:  Power BI Desktop only works on windows, but if you publish this Power BI file you can schedule a refresh to acheive the same results.