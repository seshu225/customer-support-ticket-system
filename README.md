# Support Ticket System

## Project Overview
This project is a simple Support Ticket Management System.
Users can create tickets and admins can manage and resolve them.

## Tech Stack
- .NET (visual studio 2022)
- C#
- Windows Forms
- MySQL
- REST API


## Features
- User Login
- Create Ticket
- View Ticket Details
- Admin Assign Ticket
- Update Ticket Status
- Add Comments

## Steps to Run the Project

1. Clone the repository from GitHub
2. Open the project in Visual Studio
3. Import the database.sql file into MySQL
4. Update connection string in appsettings.json
5. Run the backend API
6. Run the desktop application

## Assumptions
- Only admins can assign tickets
- Users can create and view tickets
- Tickets contain subject, description and priority

##Note----
-- step1 : tool-> nuGet Package manager->package manager console-> dotnet dev-certs https --trust 
