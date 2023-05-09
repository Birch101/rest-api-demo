# REST API Demo

## Overview

This is a simple REST API to allow film data to be created, read, updated and deleted. It consists of the following parts:

- SQLite database generated using Entity Framework 'code first' approach. 
- C# REST API connecting to a SQLite database.

## Running

The REST API can be run from Visual Studio and should be run first before starting up any applications consuming this API.

## Database creation

The SQLite database is checked in with the code, but if required could be generated again by running the 'update-database' command from within Visual Studio.

## Deployment
The REST API is automatically deployed to an Azure App Service at this URL via a yaml script included in this repository:
- https://rest-api-demo-cb.azurewebsites.net/swagger/index.html

The following applications make use of this API:
- Angular web app - https://github.com/Birch101/angular-14-demo-app - deployed to https://angular-14-demo.azurewebsites.net
