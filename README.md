
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

This project is set up to automatically apply migrations and seed the database with initial data when the application runs. 

### How It Works

- **Automatic Migrations**: Upon starting the application, the database will automatically apply any pending migrations. This ensures that the database schema is always up-to-date with the latest version of the application.
- **Seeded Data**: The database is pre-seeded with sample data for demonstration and testing purposes. This includes sample persons, interests, and links that are already populated in the database when the app starts.

### Running the Application

When you run the application for the first time, the following steps are executed automatically:

1. **Database Creation**: If a database does not already exist, it will be created.
2. **Applying Migrations**: Any pending migrations will be applied to the database.
3. **Seeding the Database**: The database will be populated with initial data.

### Important Notes

- If you want to start with a fresh database without the seeded data, you can delete the existing database file (if using a local database like SQLite) and re-run the application.
- If you make changes to the models or database context, make sure to create a new migration and update the database accordingly.


