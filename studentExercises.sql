
DROP TABLE IF EXISTS StudentExercise;
DROP TABLE IF EXISTS Student;
DROP TABLE IF EXISTS Instructor;
DROP TABLE IF EXISTS Exercise;
DROP TABLE IF EXISTS Cohort;

CREATE TABLE Exercise (
 Id INT NOT NULL PRIMARY KEY IDENTITY,
 [ExerciseName] VARCHAR(50) NOT NULL,
 [ExerciseLanguage] VARCHAR(50) NOT NULL
 );

 INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
 VALUES ('ChickenMonkey', 'JavaScript');
 INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
 VALUES ('Planet', 'C#');
 INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
 VALUES ('Most Famous', 'HTML');
 INSERT INTO Exercise (ExerciseName, ExerciseLanguage)
 VALUES ('Overly Excited', 'JavaScript');
 
 CREATE Table Cohort (
 Id INT NOT NULL PRIMARY KEY IDENTITY,
 CohortName VARCHAR(50) NOT NULL
 );

 INSERT INTO Cohort (CohortName)
 VALUES ('Day Cohort 30');
 INSERT INTO Cohort (CohortName)
 VALUES ('Day Cohort 28');
 INSERT INTO Cohort (CohortName)
 VALUES ('Day Cohort 29');

 CREATE Table Student (
 Id INT NOT NULL PRIMARY KEY IDENTITY,
 FirstName VARCHAR(50) NOT NULL,
 LastName VARCHAR(50) NOT NULL,
 Slack VARCHAR(50) NOT NULL,
 Cohort_id INT NOT NULL,
 CONSTRAINT FK_StudentCohort FOREIGN KEY(Cohort_id) REFERENCES Cohort(Id)
 );

 INSERT INTO Student (FirstName, LastName, Slack, Cohort_id)
 VALUES ('Nick', 'Hansen', '@nhansen', 1);
 INSERT INTO Student (FirstName, LastName, Slack, Cohort_id)
 VALUES ('Han', 'Solo', '@hsolo', 1);
 INSERT INTO Student (FirstName, LastName, Slack, Cohort_id)
 VALUES ('Lea', 'Vader', '@lvader', 2 );
 INSERT INTO Student (FirstName, LastName, Slack, Cohort_id)
 VALUES ('Luke', 'Liedto', '@daddyissues', 1 );
 INSERT INTO Student (FirstName, LastName, Slack, Cohort_id)
 VALUES ('Chew', 'Bakka', '@bigfoot', 2 );
 INSERT INTO Student (FirstName, LastName, Slack, Cohort_id)
 VALUES ('Anakin', 'Skywalker', '@confused', 3 );
 INSERT INTO Student (FirstName, LastName, Slack, Cohort_id)
 VALUES ('C', '3PO', '@ogtwitter', 3 );
 INSERT INTO Student (FirstName, LastName, Slack, Cohort_id)
 VALUES ('R2', 'D2', '@yourmom', 2 );

 CREATE Table StudentExercise (
 Id INT NOT NULL PRIMARY KEY IDENTITY,
 Student_id INT NOT NULL,
 Exercise_id INT NOT NULL,
 CONSTRAINT FK_StudentExerciseStudent FOREIGN KEY(Student_id) REFERENCES Student(Id),
 CONSTRAINT FK_StudentExerciseExercise FOREIGN KEY(Exercise_id) REFERENCES Exercise(Id)
 );

 INSERT INTO StudentExercise (Student_id, Exercise_id)
 VALUES (1, 2);
 INSERT INTO StudentExercise (Student_id, Exercise_id)
 VALUES (1, 3);
 INSERT INTO StudentExercise (Student_id, Exercise_id)
 VALUES (2, 3);
 INSERT INTO StudentExercise (Student_id, Exercise_id)
 VALUES (2, 4);
 INSERT INTO StudentExercise (Student_id, Exercise_id)
 VALUES (3, 1);
 INSERT INTO StudentExercise (Student_id, Exercise_id)
 VALUES (3, 4);
 INSERT INTO StudentExercise (Student_id, Exercise_id)
 VALUES (4, 2);
 INSERT INTO StudentExercise (Student_id, Exercise_id)
 VALUES (4, 3);
 INSERT INTO StudentExercise (Student_id, Exercise_id)
 VALUES (5, 1);
 INSERT INTO StudentExercise (Student_id, Exercise_id)
 VALUES (5, 2);
 INSERT INTO StudentExercise (Student_id, Exercise_id)
 VALUES (6, 4);
 INSERT INTO StudentExercise (Student_id, Exercise_id)
 VALUES (7, 1);
 INSERT INTO StudentExercise (Student_id, Exercise_id)
 VALUES (8, 3);
 INSERT INTO StudentExercise (Student_id, Exercise_id)
 VALUES (8, 4);

 CREATE Table Instructor (
 Id INT NOT NULL PRIMARY KEY IDENTITY,
 FirstName VARCHAR(50) NOT NULL,
 LastName VARCHAR(50) NOT NULL,
 Slack VARCHAR(50) NOT NULL,
 Cohort_id INT NOT NULL
 CONSTRAINT FK_InstructorCohort FOREIGN KEY(Cohort_id) REFERENCES Cohort(Id)
 );

 INSERT INTO Instructor(FirstName, LastName, Slack, Cohort_id)
 VALUES ('Chuck', 'Norris', '@fist', 1);
 INSERT INTO Instructor(FirstName, LastName, Slack, Cohort_id)
 VALUES ('Mister', 'T', '@chainsonchains', 2);
 INSERT INTO Instructor(FirstName, LastName, Slack, Cohort_id)
 VALUES ('Little Bobby', 'Tables', '@mehjokes', 3);
 INSERT INTO Instructor(FirstName, LastName, Slack, Cohort_id)
 VALUES ('Andy', 'Collins', '@codecodecode', 3);
 
 



