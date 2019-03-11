/*
 You must define a type for representing a student in code. A student can only be in one cohort at a time. A student can be working on many exercises at a time.
 */

using System;
using System.Collections.Generic;

namespace student_exercises
{
    public class Student
    {
        public Student (string firstN, string lastN, string slackHandle, string cohortName )
        {
            //constructor for Student object
            firstName = firstN;
            lastName = lastN;
            slack = slackHandle;
            cohort = cohortName;
            exerciseList = new List<Exercise>();
        }
        //Student object properties
        public string firstName {get; set;}
        public string lastName {get; set;}
        public string slack {get; set;}
        public string cohort {get; set;}

        public List<Exercise> exerciseList {get; set;}


    }
}
