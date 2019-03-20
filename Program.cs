using System;
using System.Collections.Generic;
using System.Linq;
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
            c28.studentList = new List<Student>();
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
            //Han.asignExercise(arrays, c28);
            //Han.asignExercise(loops, c28);
            Jisie.asignExercise(arrays, c29);
            Jisie.asignExercise(grids, c29);
            Steve.asignExercise(grids, c30);
            Steve.asignExercise(headers, c30);
            Rick.asignExercise(arrays, c31);
            Rick.asignExercise(headers, c31);
            Rick.asignExercise(loops, c31);

            List<Student> students = new List<Student>()
               {
                Jordan,
                Nick,
                Bubba,
                Hunter,
                Asia
            };
            List<Exercise> exercises = new List<Exercise>()
            {
                loops,
                headers,
                arrays,
                grids
            };

            List<Instructor> instructors = new List<Instructor>()
            {
                Han,
                Jisie,
                Steve,
                Rick,
            };

            List<Cohort> cohorts = new List<Cohort>()
            {
                c28,
                c29,
                c30,
                c31
            };

            /*
            List exercises for the JavaScript language by using the Where() LINQ method.
            */
            IEnumerable<Exercise> JSexercises = (from e in exercises
                                                 where e.exerciseLanguage == "JavaScript"
                                                 select e).ToList();
            foreach (Exercise e in JSexercises)
            {
                Console.WriteLine($"{e.exerciseName} is written in JS");
            }

            /*
           List students in a particular cohort by using the Where() LINQ method.
           */

            IEnumerable<Student> c29Students = (from s in students
                                                where s.cohort == "C29"
                                                select s).ToList();

            foreach (Student s in c29Students)
            {
                Console.WriteLine($"{ s.firstName} { s.lastName} is in cohort 29 ");
            }

            /*
            List instructors in a particular cohort by using the Where() LINQ method.
            */

            IEnumerable<Instructor> c29Instructor = (from i in instructors
                                                     where i.cohort == "C29"
                                                     select i).ToList();
            foreach (Instructor i in c29Instructor)
            {
                Console.WriteLine($"{i.firstName} is an instrutor for C29");
            }

            /*
            Sort the students by their last name.
            */
            IEnumerable<Student> allStudents = (from a in students
                                                orderby a.lastName descending
                                                select a).ToList();

            Console.WriteLine("");
            Console.WriteLine("Students ordered by last name");
            foreach (Student a in allStudents)
            {
                Console.WriteLine($"{a.lastName}, {a.firstName}");
            }

            /*
            Display any students that aren't working on any exercises (Make sure one of your student instances don't have any exercises. Create a new student if you need to.)
            */


            IEnumerable<Student> studentExercises = (from n in students
                                                     where n.exerciseList.Count() == 0
                                                     select n).ToList();
            
            foreach(Student n in studentExercises)
            {
                Console.WriteLine($"{n.firstName} has no exercises.");
            }


            /*
            Which student is working on the most exercises? Make sure one of your students has more exercises than the others.
            */
            IEnumerable<Student> mostExercises = (from m in students
                                                  orderby m.exerciseList.Count descending
                                                  select m).ToList();
            var topStudent = mostExercises.First();
            {
                Console.WriteLine($"{topStudent.firstName} has the most exercises");
            }


            /*
           How many students in each cohort?
           */
            IEnumerable<Student> studentByCohort = new List<Student>
            {
             
            };
            Console.ReadKey();
        }
    }
}