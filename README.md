#Student Report
#Project Overview
Student Report is a Visual C# application designed to manage and analyze student records. It enables users to input, view, and filter information such as quiz marks, lab test scores, lecture test marks, research project grades, and final project scores for individual students. The application is built using three main forms: the Main Form, Data Entry Form, and Data Display Form, each providing specific functionalities to manage the student data effectively.

#Features
Main Form
The Main Form serves as the entry point to the application and offers three key options:

Input Data: Opens the Data Entry Form, allowing users to add and edit student records in a GridView table format.
Display Data: Opens the Data Display Form, which shows detailed views of student records and provides various filtering options.
Exit: Closes the application.

#Data Entry Form
The Data Entry Form is designed for entering and updating student information. It includes fields for:

Student Number (Primary Key)
First Name
Last Name
Quiz Mark
Lab Test Mark
Lecture Test Mark
Research Project Mark
Final Project Mark
The Average is automatically calculated using an event handler when all the marks are entered. The form also has buttons to:

Calculate Class Average: Computes the average of all student averages and displays it in a MessageBox.
Calculate Class Standard Deviation: Calculates the standard deviation of the average marks and displays it.
#Data Display Form
The Data Display Form provides a detailed view of all student records. It offers the following functionalities:

Filter by Category: Allows users to filter records based on a specific category (e.g., Quiz, Lab Test, Lecture Test, Research Project, Final Project).
Filter by Range: Allows users to apply secondary filters such as:
Greater than 80
Less than 50
Between 60 and 70
#Project Structure
MainForm.cs: Implements the Main Form interface and handles navigation between forms.
DataEntryForm.cs: Manages data entry, validation, and calculation of averages and standard deviation.
DataDisplayForm.cs: Displays detailed student records and provides options for filtering based on user input.
Student.cs: Defines the Student class and properties such as StudentNumber, FirstName, LastName, QuizMark, LabTestMark, LectureTestMark, ResearchProjectMark, FinalProjectMark, and Average.
#Formulae Used
Average Calculation
The average mark for a student is calculated using the following formula:
Average = (Σ Mark_i) / N

Where:

Mark_i = Mark obtained in each category
N = Total number of categories (Quiz, Lab Test, Lecture Test, etc.)
Standard Deviation Calculation
The standard deviation of the class averages is calculated using the formula:

σ = sqrt(Σ (Average_i - X̄)^2 / (N - 1))
Where:

σ = Standard deviation
Average_i = Average of each student
X̄ = Class average
N = Total number of students
#Getting Started
Prerequisites
Visual Studio 2019 or higher
.NET Framework 4.7.2 or later
Installation
Clone the Repository
Clone the project repository to your local machine using the command:

git clone https://github.com/vdave18/StudentReport.git
Open in Visual Studio

Open Visual Studio.
Go to File > Open > Project/Solution.
Select the .sln file from the cloned directory.
Build and Run the Project

Build the solution using Build > Build Solution.
Run the application using Debug > Start Debugging or by pressing F5.
Future Enhancements
Implement database connectivity for persistent storage.
Add additional filters and sorting capabilities.
Create a graphical dashboard for visualizing student performance.
#License
This project is licensed under the MIT License - see the LICENSE file for details.

#Contact
For more information or suggestions, please reach out to the project author.
