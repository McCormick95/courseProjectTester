using System;
using System.Collections.Generic;

namespace cs330_proj1
{
    public class CourseServices
    {
        private readonly ICourseRepository _repo;

        //private ICourseRepository _courseRepo;

        //when you create a new course services you can then pass in whichever repo you want to use.
        //looks something like the code below. 
        public CourseServices( ICourseRepository repo){
            _repo=repo;
         }

        //As a student, I want to search for course offerings that meet core goals 
        // so that I can register easily for courses that meet my program requirements
         public List<CourseOffering> getOfferingsByGoalIdAndSemester(String theGoalId, String semester) {
          //finish this method during the tutorial 
          //use the repo to get the data from the database (data store)
            List<CoreGoal> theGoals = _repo.GetCoreGoals();
            List<CourseOffering> theOfferings = _repo.GetCourseOfferings();
                        
            //Complete any other required functionality/business logic to satisfy the requirement
            CoreGoal theGoal =null;
            foreach(CoreGoal cg in theGoals) {
               if(cg.Id.Equals(theGoalId)) {
                  theGoal=cg; break;
            
               }
            }
            if(theGoal==null) throw new Exception("Didn't find the goal");
            //search list of courses, then for each course, search offerings
            List<CourseOffering> courseOfferingsThatMeetGoal = new List<CourseOffering>();
                        
            foreach(CourseOffering c in theOfferings) {
               if(c.Semester.Equals(semester) 
                  && theGoal.Courses.Contains(c.TheCourse) ) 
               {
                  courseOfferingsThatMeetGoal.Add(c);
               }
            
            }
            return courseOfferingsThatMeetGoal;
        }

        
        //Add more service functions here, as needed, for the project

        // User Story 2: As a student, I want to see all available courses so that I know what my options are 
         public List<Course> getCourses() 
         {
            List<Course> theCourses = _repo.GetCourses();
            List<Course> allCourses = new List<Course>();

            foreach(Course c in theCourses){
                   allCourses.Add(c);
            }

            return allCourses;
         }

        /* User Story 3: As a student, I want to see all course offerings by semester, so that I can choose from what's
           available to register for next semester */
        public List<CourseOffering> getCourseOfferingsBySemester(String semester) 
         {
            List<CourseOffering> theOffering = _repo.GetCourseOfferings();
            List<CourseOffering> courseOfferingsForThatSemester = new List<CourseOffering>();

            if(semester==null) throw new Exception("Didn't select a semester");

            foreach(CourseOffering co in theOffering){
               if(co.Semester.Equals(semester)){
                   courseOfferingsForThatSemester.Add(co);
               }
            }
            return courseOfferingsForThatSemester;
         } 


        /* User Story 4: As a student I want to see all course offerings by semester and department so that I can 
        choose major courses to register for */
        public List<CourseOffering> getCourseOfferingsBySemesterAndDept(string semester, string department){

            List<CourseOffering> theOffering = _repo.GetCourseOfferings();
            List<CourseOffering> courseOfferingsBySemesterAndDept = new List<CourseOffering>();

            if(semester==null) throw new Exception("Didn't select a semester");
            if(department==null) throw new Exception("Didn't select a department");

            foreach(CourseOffering co in theOffering){

            }

            foreach(CourseOffering co in theOffering){
               if(co.Semester.Equals(semester) && co.TheCourse.Name.Substring(0,4).Equals(department)){
                  courseOfferingsBySemesterAndDept.Add(co);
               }       
            }

            return courseOfferingsBySemesterAndDept;
        } 


        /* As a student I want to see all courses that meet a core goal, so that I can plan out
           my courses over the next few semesters and choose core courses that make sense for me */

        /* As a student I want to find a course that meets two different core goals, so that I can
        "feed two birds with one seed" (save time by taking one class that will fulfill two 
          requirements */

        /* As a freshman adviser, I want to see all the core goals which do not have any course offerings 
           for a given semester, so that I can work with departments to get some courses offered
           that students can take to meet those goals */

         
     }
     public interface ICourseRepository{
            public List<Course> GetCourses();
            public List<CoreGoal> GetCoreGoals();
            public List<CourseOffering> GetCourseOfferings();
      }
}
