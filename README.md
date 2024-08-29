
## Introduction

### Labb_3_Webb_API is a RESTful web API built using ASP.NET Core and Entity Framework Core. This API allows users to manage Persons, Interests, and Links, providing endpoints to create, read, update, and delete data. The project also includes the use of Swagger for API documentation and testing.

## Features
- Create, Read, Update, Delete (CRUD) Operations: Perform CRUD operations on Persons, Interests, and Links.
- Database Management: Uses Entity Framework Core for database management and migrations.
- API Documentation: Integrated with Swagger for easy API documentation and testing.
- Responsive Endpoints: Validates input data and returns appropriate HTTP responses.

## Technologies Used

- ASP.NET Core: The main framework used to build the API.
- Entity Framework Core: Used for ORM (Object-Relational Mapping) and database management.
- Swagger: For API documentation and testing.
- SQL Server: The default database for development and testing.

## Usage & Available Endpoints

#### Here is a list of the available endpoints in the API:

-	GET /Get all persons in DB: *Retrieves all persons in the DB.*
-	POST /Add a new person: *Adds a new person to the DB.*
- GET /Get interests by person ID/{id}/interest: *Retrieves interest by person by ID.*
- GET /Get links associated to person/{id}: *Retrieves all links by person ID.*
-	POST /Add new link to specific person and interest: *Adds a new link to a specific person and interest.*
-	POST /Add an interest to person: *Adds a new interest to a specific person.*

## Database Initialization

This project is pre-seeded with initial data and is set up to automatically seed the database with data after the following steps. 

### Running the Application

Before you run the application for the first time, the following steps are required to execute the intended functionality of the application:

- **Database Creation**: Prior to debugging the application, you will need to migrate the data using the command *Add-Migration* in your NuGetPackaage Manager console, following a *namming for your migration within a double quote eg. "my new migration"* in order to create the Database and seed all data.
- **Applying Migrations**: After adding the migration, the database needs to be updated by using the command *Update-Database* in the NuGetPackaage Manager console so that all data is synced to the newly created DB. The database is pre-seeded with sample data for demonstration and testing purposes. This includes sample persons, interests, and links that are already populated.

### Important Notes

- If you want to start with a fresh database without the seeded data, you can delete the existing database file (if using a local database like SQLite) and re-run the application.
- If you make changes to the models or database context, make sure to create a new migration and update the database accordingly.


