
 /*
You must define a type for representing an exercise in code. An exercise can be assigned to many students.

Name of exercise
Language of exercise (JavaScript, Python, CSharp, etc.)
 */

using System;

namespace student_exercises
{
    public class Exercise
    {
        //Constructor for exercise object
        public Exercise(string exercise, string language){
            exerciseName = exercise;
            exerciseLanguage = language;
        }
        //Exercise object properties
        public string exerciseName {get; set;}
        public string exerciseLanguage {get; set;}


    }
}