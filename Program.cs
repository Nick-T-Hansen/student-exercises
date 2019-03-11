using System;
using System.Collections.Generic;
// Have each instructor assign 2 exercises to each of the students.

namespace student_exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            //CREATE STUDENT OBJECTS
            Student Jordan = new Student("Jordan", "Rosas", "@JJROS", "C28");
            Student Nick = new Student("Nick", "Hansen", "@NTHANSEN", "C29");
            Student Bubba = new Student("Bubba", "Franks", "@BIGbubba", "C29");
            Student Hunter = new Student("Hunter", "Metts", "@HunterDaddy", "C30");
            Student Asia = new Student("Asia", "Carter", "@AsianPersuasian", "C31");

            //CREATE INSTRUCTOR OBJECTS
            Instructor Jisie = new Instructor("Jisie", "David", "@boss", "C29");
            Instructor Steve = new Instructor("Steve", "McCodeycode", "@coach", "C30");
            Instructor Han = new Instructor("Han", "Solo", "@nonationarmy", "C28");
            Instructor Rick = new Instructor("Rick", "Roll", "@nevergiveyouup", "C31");


            //CREATE COHORT OBJECTS
            Cohort c28 = new Cohort("C28");
            Cohort c29 = new Cohort("C29");
            Cohort c30 = new Cohort("C30");
            Cohort c31 = new Cohort("C31");

            //CREATE INSTANCES FOR EACH STUDENT EXERCISE LISTS
            List<Exercise> nickExercises = new List<Exercise>();
            List<Exercise> hunterExercises = new List<Exercise>();
            List<Exercise> asiaExercises = new List<Exercise>();
            List<Exercise> jordanExercises = new List<Exercise>();

            //ADD EXERCISE OBJECTS
            Exercise loops = new Exercise("loops", "JavaScript");
            Exercise headers = new Exercise("headers", "HTML");
            Exercise arrays = new Exercise("arrays", "JavaScript");
            Exercise grids = new Exercise("grids", "CSS");

            //USING THE .studentListIN THE COHORT OBJECT, CREATE STUDENT LISTS FOR EACH COHORT.
            c28.studentList= new List<Student>();
            c29.studentList = new List<Student>();
            c30.studentList = new List<Student>();
            c31.studentList = new List<Student>();

            //ADD STUDENTS TO THEIR RESPECTIVE COHORT LIST
            c28.studentList.Add(Jordan);

            c29.studentList.Add(Nick);
            c29.studentList.Add(Bubba);

            c30.studentList.Add(Hunter);

            c31.studentList.Add(Asia);

            //CREATE INSTANCES OF INSTRUCTOR LISTS
            List<Instructor> cohort28Instructors = new List<Instructor>();
            List<Instructor> cohort29Instructors = new List<Instructor>();
            List<Instructor> cohort30Instructors = new List<Instructor>();
            List<Instructor> cohort31Instructors = new List<Instructor>();

            //ADD INSTRUCTORS TO RESPECTIVE COHORT LIST
            cohort28Instructors.Add(Han);
            cohort29Instructors.Add(Jisie);
            cohort30Instructors.Add(Steve);
            cohort31Instructors.Add(Rick);

            //ADD STUDENT LIST AND TEACHER LIST TO COHORTS (is this necessary?)
            // c28.Add(cohort28Students);
            // c28.Add(cohort28Instructors);

            //METHOD CALL FOR AN INSTRUCTOR TO ASSIGN AN EXCERCISE TO AN ENTIRE COHORT OF STUDENTS
            // Jisie.asignExercise(loops, cohort29Students);
            Han.asignExercise(arrays,c28);
            Han.asignExercise(loops, c28);
            Jisie.asignExercise(arrays, c29);
            Jisie.asignExercise(grids,c29);
            Steve.asignExercise(grids, c30);
            Steve.asignExercise(headers, c30);
            Rick.asignExercise(arrays, c31);
            Rick.asignExercise(headers, c31);
        }
    }
}
