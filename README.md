### Repository Overview: ASP.NET MVC Student Management System

This repository contains an ASP.NET MVC web application for managing student data with an SQLite database. Below is a concise description of the project components and their roles:

### Project Setup

- **ASP.NET MVC Application**: Structured using ASP.NET MVC framework.
- **NuGet Packages**:
  - **SQLite**: Database support.
  - **System.Data.SQLite**: ADO.NET provider for SQLite.

### Database Interaction

- **SQLite Connection**: 
  - **Creating Connection**: `SQLiteConnection` with database path.
  - **Executing Query**: `SQLiteCommand` for `SELECT * FROM personal_info`.
  - **Reading Data**: `SQLiteDataReader` outputs data to debug console.

### Models

- **Person**: Represents a person with attributes from `personal_info` table.
- **Personal_info**:
  - `GetAllPerson()`: Returns all persons.
  - `GetPerson(int id)`: Returns a person by `id`.

### Controllers and Views

- **PersonController**:
  - `All()`: Displays all persons in a table.
  - `Details(int id)`: Displays details of a person by `id`, shows a message if `id` is invalid.
  - `Search()`: Form to search by `first_name` and `country`, redirects to details of the matching person.

- **Views**:
  - **All.cshtml**: Displays all persons.
  - **Details.cshtml**: Displays person details.
  - **Search.cshtml**: Search form.

### Usage Instructions

1. **Setup**:
   - Clone the repository.
   - Open in Visual Studio.
   - Install NuGet packages (`SQLite`, `System.Data.SQLite`).

2. **Configure Database**:
   - Set the correct database file path in the connection string.

3. **Run Application**:
   - Build and run.
   - Navigate to `/Person/all` to view all persons.
   - Navigate to `/Person/{id}` to view details by `id`.
   - Navigate to `/Person/search` to search for a person.

### Summary

This project provides CRUD operations for managing student records, using ASP.NET MVC and SQLite. The structure ensures maintainability and scalability.
