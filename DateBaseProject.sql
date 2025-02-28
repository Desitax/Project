CREATE DATABASE DataBaseProject

CREATE TABLE Subjects(
subject_id INT PRIMARY KEY IDENTITY(1,1),
name NVARCHAR(50),
price DECIMAL (10,2),
duration INT NOT NULL
)
 
CREATE TABLE Students(
student_id INT PRIMARY KEY IDENTITY(1,1),
name NVARCHAR(50) NOT NULL,
surname NVARCHAR(50) NOT NULL,
age INT CHECK(age>=5) NOT NULL,
city NVARCHAR(50),
dateOfBirth DATE NOT NULL
)
 
CREATE TABLE Teachers(
teacher_id INT PRIMARY KEY IDENTITY(1,1),
subject_id INT FOREIGN KEY REFERENCES Subjects(subject_id),
name NVARCHAR(50) NOT NULL,
surname NVARCHAR(50) NOT NULL,
age INT NOT NULL,
city NVARCHAR(50),
phoneNumber NVARCHAR(12),
dateOfBirth DATE NOT NULL,
yearsOfTeaching INT
)
 
CREATE TABLE StudentsTeachers(
people_id INT PRIMARY KEY IDENTITY(1,1),
student_id INT FOREIGN KEY REFERENCES Students(student_id),
teacher_id INT FOREIGN KEY REFERENCES Teachers(teacher_id),
yearsOfCollaborationWork INT
)
 
CREATE TABLE Academy(
academy_id INT PRIMARY KEY IDENTITY(1,1),
name NVARCHAR(20) NOT NULL,
student_id INT FOREIGN KEY REFERENCES Students(student_id),
teacher_id INT FOREIGN KEY REFERENCES Teachers(teacher_id)
)
 

 