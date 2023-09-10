# Project_PRG_282

Welcome to Project_PRG_282, a Data Capturer application designed to manage student and module information efficiently.

## Features

1. **User Authentication**
   - A user-friendly login form requiring a Username and Password.
   - User credentials stored securely in a text file (in any format you prefer).
   - Rigorous validation to ensure a secure login process.
   - New users can register, with their login details stored in the text file.

2. **Windows GUI for CRUD Operations**
   - A user-friendly Windows GUI for Data Capturers.
   - Utilizes ADO.Net for seamless interaction with the database.
   - All data is stored and managed in an SQL Server database.

3. **Student Information**
   - Create: Capture and store comprehensive student information, including:
     - Student Number
     - Student Name and Surname
     - Student Image
     - Date of Birth (DOB)
     - Gender
     - Phone
     - Address
     - Module Codes

4. **Student Information Management**
   - Read: Display student information in a ListView or DataGridView.
   - Update: Modify student information as needed.
   - Delete: Easily remove a student's information.
   - Search: Quickly find a specific student's details using their Student ID.

5. **Module Information**
   - Create: Capture and store essential module information, including:
     - Module Code
     - Module Name
     - Module Description
     - Links to relevant online resources (utilizing YouTube videos for module content).

6. **Module Information Management**
   - Read: Display module information clearly in a ListView or DataGridView.
   - Update: Edit module details seamlessly.
   - Delete: Remove module information when necessary.
   - Search: Effortlessly locate modules using their unique Module Code.

## Getting Started

1. Clone or download this repository to your local machine.

2. Set up an SQL Server database and ensure the database connection string in the application code is correctly configured.

3. Run the application, and follow the on-screen instructions to either log in with your credentials or register as a new user.

4. Use the intuitive Windows GUI to perform all CRUD operations for both student and module information.

## Dependencies

This application relies on ADO.Net for database interactions and requires access to an SQL Server
