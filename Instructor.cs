using System;

namespace student_exercises
{    public class Instructor
    {
        public Instructor (string firstN, string lastN, string slackHandle, string cohortName)
        {
            //constructor for Instructor object
            firstName = firstN;
            lastName = lastN;
            slack = slackHandle;
            cohort = cohortName;

        }
        //Instructor object properties
        public string firstName {get; set;}
        public string lastName {get; set;}
        public string slack {get; set;}
        public string cohort {get; set;}

        // A method to assign an exercise to a student
        /*
        declare a method which takes the exercise and cohort classess as parameters. Exercise allows us to specify which exericse we want added to the students list, and cohort gives us access to the correct students for the teacher. For each of these students in the student list, we want to add the exercise.
        */
        public void asignExercise(Exercise anExercise, Cohort students) {
            foreach(Student student in students.studentList) {
                student.exerciseList.Add(anExercise);
                Console.WriteLine($"{student.firstName} is working on {anExercise.exerciseName}");
            }
        }
        // CODE TO TRY AND STREAMLINE WHAT IS PRINTED OUT- STUDENT AND BOTH EXERCISES ON ONE LINE
        // public void asignExercise(Exercise anExercise, Cohort students) {
        //     foreach(Student student in students.studentList) {
        //         foreach(Exercise exercise in students.exerciseList)
        //             if

        //             else(student.exerciseList.Add(anExercise);
        //         Console.WriteLine($"{student.firstName} is working on {anExercise.exerciseName}");
        //     }
        // }
    }
}
