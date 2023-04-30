# CHI Academy. Homework 4

### ASP.NET developer registration application

#### Assignment date: 28.04.2023

#### Task:

The founder of the startup "I am an ASP.NET developer" has asked you to implement his idea. This will be the world's first social network for ASP .NET developers. 

The site consists of two pages:

1) Submit Form:
  - Name
  - Email
  - "Become a Developer" button.

2) Successful registration page

When the button is clicked, the data is sent to the server and the user is taken to a page with the following text: "I, Name (Email), have become an ASP .NET developer".

#### Additional task:

Create database that stores registered developers. 

Site visitors will be able to view how many developers have already registered and who they are. 

Note that a user cannot re-register with the same email address.

#### Solution description

For initial task developed:
  1. ASPDeveloper model for storing developer data
  2. HomeController for managing Home and Community pages 
  3. RegistrationController for registration handling
  4. Views
  
For database developed:
  1. AppDbContext for working with database
  2. DeveloperRepository for storing set of records from table Developer
  3. HomeViewModel for storing developers and their amount and passing them to Home and Community pages

#### Results

Web-application with 4 pages:
  1. Home
  2. Community
  3. Registration
  4. Successful registration
and local SQL Server database.

  
  
