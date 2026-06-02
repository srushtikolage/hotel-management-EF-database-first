# Customer & Order Management System

A web-based application developed using ASP.NET MVC and Entity Framework (Database First Approach) to manage customer and order information efficiently. 
The application provides a simple and user-friendly interface for handling customer records and order details 
while maintaining proper database relationships.

## 🚀 Technologies Used

### Backend

* ASP.NET MVC
* Entity Framework (Database First Approach)
* SQL Server

### Frontend

* HTML5
* CSS3
* Bootstrap

### Tools
*Visual Studio 22
*SQL SERVER Management Studio21

## ✨ Key Features

### 👤 Customer Management

* Manage customer information through a centralized system.
* Maintain and update customer records efficiently.
* View customer details in an organized manner.

### 📦 Order Management

* Manage customer orders and related information.
* Associate orders with customers using database relationships.
* Maintain accurate order records and transaction details.

### 🗄️ Database Design

* Implemented Entity Framework Database First Approach.
* Established a Foreign Key relationship between Customer and Order tables.
* Ensured data integrity and consistency using SQL Server.

## Database Schema

### Customer Table

| Column Name  | Description      |
| ------------ | ---------------- |
| CustomerId   | Primary Key      |
| CustomerName | Customer Name    |
| Email        | Customer Email   |
| PhoneNumber  | Contact Number   |

### Order Table

| Column Name | Description       |
| ----------- | ----------------- |
| OrderId     | Primary Key       |
| OrderName   | Order Information |
| OrderDate   | Date of Order     |
| Amount      | Order Amount      |
| CustomerId  | Foreign Key       |

### Relationship

* One Customer can have multiple Orders.
* CustomerId in the Order table references CustomerId in the Customer table.
* The relationship is maintained using a Foreign Key constraint to ensure data integrity.

## 🏗️ Project Architecture

* MVC (Model-View-Controller) Architecture
* Entity Framework Database First Approach
* SQL Server Relational Database
* Responsive User Interface using Bootstrap

## 📚 Learning Outcomes
## 🎯 Project Purpose

This is a learning-based project created to practice ASP.NET MVC, Entity Framework, SQL Server, HTML, CSS, and Bootstrap.
The project focuses on implementing CRUD operations, managing relational data using Foreign Keys,
and understanding the MVC architecture through a practical application.


Through this project, I gained practical experience in:

* ASP.NET MVC Application Development
* Entity Framework Database First Approach
* SQL Server Database Design
* Relational Database Concepts
* Foreign Key Implementation
* CRUD Operations
* Bootstrap-based Responsive Design
* MVC Architecture and Design Patterns

## 🔮 Future Enhancements

* User Authentication and Authorization
* Search and Filtering Functionality
* Pagination Support
* Enhanced Form Validations
* Dashboard and Reporting Features

## 👨‍💻 Author

Developed as a learning project to strengthen skills in ASP.NET MVC, Entity Framework, SQL Server, and web application development.

## 👨‍💻 Developed By

**Srushti Kolage**


