using System;
using System.Collections.Generic;

namespace student_exercises
{

    public class Cohort
    {
        //Constructor for Cohort object
        public Cohort(string cohortName) {
            cohort = cohortName;
            studentList = new List<Student>();
            instructorList = new List<Instructor>();
        }
        //Cohort object properties
        public string cohort {get; set;}
        public List<Student> studentList {get; set;}
        public List<Instructor> instructorList {get; set;}

    }
}