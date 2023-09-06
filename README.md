# CMPG-323-Project-3
# Standards & Patterns

************************************************************************************

Welcome to the CMPG 323 Project 3, This repository contains an ASP.NET Core MVC Web Application that has been enhanced and improved according to architectural patterns, coding principles, and design patterns. The project focuses on implementing best practices and standards to create a more maintainable and robust application.This README.md file will serve as your comprehensive guide to ensure you have a smooth and impressive project experience.

## Table of Contents
************************************************************************************
1. [GitHub Administration](#github-administration)
   - [Create and Configure GitHub Repository](#create-and-configure-github-repository)
   - [Project Progress](#project-progress)

2. [Project Setup](#project-setup)
   - [Access the Existing Project](#access-the-existing-project)
   - [Connect the Web App to the Data Source](#connect-the-web-app-to-the-data-source)

3. [Design Pattern Implementation](#design-pattern-implementation)
   - [Create Repository Classes](#create-repository-classes)
   - [Transfer Data Access Operations](#transfer-data-access-operations)
   - [Implement Repository Classes](#implement-repository-classes)

4. [Project Close-out](#project-close-out)
   - [Security](#security)
   - [Web API Cloud Hosting](#web-api-cloud-hosting)

## GitHub Administration
************************************************************************************

### Create and Configure GitHub Repository

To begin your project, you will need a well-organized and professionally set up GitHub repository. Follow these steps:

- **Create a Repository**: Create a repository named 'CMPG 323 Project 3 - \<add your student number\>'.

- **Create a README.md**: Craft an informative README.md file that will describe your project and how stakeholders are to use the report that you have developed. Make it informative and engaging to capture your audience's attention.

### Project Progress
************************************************************************************

To ensure transparency and demonstrate your project's iterative progress, follow these best practices:

- **Commit Frequently**: Throughout the project, commit your changes to source control regularly. Use meaningful commit messages to document your progress.

- **Update GitHub Project**: Keep your GitHub project board updated iteratively. Use it to showcase how progress was made, what tasks are completed, and what's in progress.

## Project Setup
************************************************************************************

### Access the Existing Project


Before diving into development, it's crucial to set up your development environment correctly:

- **Fork the Repository**: Fork the existing GitHub repository to create your own copy that you can work on.

- **Create a Development Branch**: Create a new development branch to isolate your work from the main branch.

### Connect the Web App to the Data Source


To ensure your web application connects seamlessly to the data source, follow these steps:

- **Update appsettings.json**: Add the connection string to your hosted database in the `appsettings.json` file. This connection string is essential for your application to interact with the database.

## Design Pattern Implementation
************************************************************************************

### Create Repository Classes


Organize your data access operations effectively with repository classes:

- **Orders Repository**: Create a repository class that contains all data access operations relating to Orders.

- **Customers Repository**: Create a repository class that contains all data access operations relating to Customers.

- **Products Repository**: Create a repository class that contains all data access operations relating to Products.

### Transfer Data Access Operations

Streamline your code by transferring data access operations:

- **Orders**: Transfer all data access operations from the Orders controller to the Orders Repository class.

- **Customers**: Transfer all data access operations from the Zones controller to the Customers Repository class.

- **Products**: Transfer all data access operations from the Categories controller to the Products Repository class.

### Implement Repository Classes

Integrate repository classes into your project for improved data management:

- **Orders Controller**: Implement the use of the Customer repository class in the Orders controller, replacing data access operations that have been transferred to the repository class.

- **Orders Controller**: Implement the use of the Products repository class in the Orders controller, replacing data access operations that have been transferred to the repository class.

## Project Close-out
************************************************************************************

### Security

Maintain a high level of security throughout your project:

- **No Credentials on GitHub**: Ensure that no credentials, such as API keys or sensitive information, are stored on GitHub. Always use environment variables or other secure methods for storing sensitive data.

### Web API Cloud Hosting

I Hosted web API in the cloud for accessibility:

- **Create an App Service**: Set up an App Service, connected to an F1 tier (free) service plan, in your preferred cloud platform (e.g., Azure).

- **Publish Your App**: Deploy your web application to the service hosted on Azure, ensuring it is secure and accessible.
*************************************************************************
![nwu](https://github.com/Madzivhandila/CMPG-323-Project-3---30332338/assets/75025282/a0283a1d-34d9-489c-8c44-90bccfc065f6)

