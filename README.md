# Deploying Azure App using GitHub Actions

This repository contains an Azure Resource Manager (ARM) template and a GitHub Actions workflow that automates the deployment of an Azure App Service using the ARM template.

## Prerequisites

Before you begin, make sure you have the following:

- An Azure subscription
- A GitHub account

## Steps to Deploy

Follow these steps to deploy the Azure App using GitHub Actions:

1. Fork this repository to your GitHub account.
2. Open the `azuredeploy.json` file in the repository.
3. Customize the ARM template according to your requirements. You can modify the parameters, resources, and other settings as needed.
4. Commit and push the changes to your forked repository.
5. In your Azure portal, create a new resource group to deploy the Azure App.
6. Go to the Actions tab in your forked repository.
7. Click on "Set up a workflow yourself" to create a new workflow file.
8. Replace the content of the workflow file with the following code:
9. Replace `<your-resource-group-name>`, `<your-app-service-name>`, `<your-location>`, and `<your-sku>` with the appropriate values.
10. Save the workflow file.
11. Go back to the Actions tab and click on "Enable workflows" to enable the GitHub Actions workflow for your repository.
12. Push any changes to the repository to trigger the deployment workflow.
13. Monitor the workflow execution in the Actions tab.
14. Once the workflow completes successfully, your Azure App will be deployed.

## Conclusion

By following these steps, you can deploy an Azure App using GitHub Actions and automate the deployment process using an ARM template.

Happy coding!
