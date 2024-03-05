This serves as a sample project for the GitHub Copilot lab exercise.
The project is a simple web application that allows users to create, read, update, and delete (CRUD) users with sample data. 

## Prerequisites
- Visual Studio 2022 with version 17.6 or later
- GitHub Copilot
- GitHub account

## Getting Started
1. Clone the repository to your local machine.
1. Open the solution in Visual Studio 2022.
1. Run the application.
1. Open a web browser and navigate to localhost.
1. You should see the home page of the application.

## Lab Excersise
1. Open the `User` class in the `Models` folder.
	1. Ask GitHub Copilot to generate a sample user model.
1. Open the `IUserService` class in the `Services` folder.
	1. Ask GitHub Copilot to generate a new method to the `IUserService` interface that returns a user by ID.
	1. Ask GitHub Copilot to generate a new method to the `IUserService` interface that creates a new user.
	1. Ask GitHub Copilot to generate a new method to the `IUserService` interface that updates a user by ID.
	1. Ask GitHub Copilot to generate a new method to the `IUserService` interface that deletes a user by ID.
1. Open the `UserService` class in the `Services` folder.
	1. Ask GitHub Copilot to Initialize user list with sample data and implement the IUserService interface
	1. Ask GitHub Copilot to implement the method that returns a list of users.
	1. Ask GitHub Copilot to implement the method that returns a user by ID.
	1. Ask GitHub Copilot to implement the method that creates a new user.
	1. Ask GitHub Copilot to implement the method that updates a user by ID.
	1. Ask GitHub Copilot to implement the method that deletes a user by ID.
1. Open the `UserController` class in the `Controllers` folder.
	1. Generate the crud methods for the User Controller using the IUserService
	1. Ask GitHub Copilot to generate a new method that returns a view to create a new user.
	1. Ask GitHub Copilot to generate a new method that returns a view to update a user by ID.
	1. Ask GitHub Copilot to generate a new method that returns a view to delete a user by ID.
	1. Ask GitHub Copilot to generate a new method that returns a view to view a user by ID.
	1. Ask GitHub Copilot to generate a new method that returns a view to view all users.
1	Open the `Program` class
	1. Ask GitHub Copilot to inject IUserService into the controller and the service class as singleton instance

1. Open the `app.tf` file located within the terraform directory inside the iac folder.
	1. Ask GitHub Copilot to define variables for azure subscription id, resource group, SKU, Size and location inside the app.tf file
	1. Ask GitHub Copilot to generate a new resource block for the Azure App Service.
	1. Ask GitHub Copilot to generate a new resource block for the Azure App Service Plan.

1. Open the `build-and-push.yaml` file located within the .github/workflows directory.
	1. Ask GitHub Copilot to Create build and deploy workflow for deploying .Net 8.0 application to Azure App Service using GitHub Actions 
	1. Ask GitHub Copilot to define the environment variables for the Azure subscription id, resource group, SKU, Size and location inside the build-and-push.yaml file
	1. Ask GitHub Copilot to define the secrets for the Azure client id, client secret and tenant id inside the build-and-push.yaml file
	1. Ask GitHub Copilot to define the steps for the Azure login and Azure Web App deploy actions inside the build-and-push.yaml file
	1. Ask GitHub Copilot to define the trigger for the workflow to run on push and pull request events
	1. Ask GitHub Copilot to define the on and off jobs for the workflow to run on the latest version of the ubuntu-latest runner
	1. Ask GitHub Copilot to define the steps for the checkout, setup .Net, build, and publish actions inside the build-and-push.yaml file






 




