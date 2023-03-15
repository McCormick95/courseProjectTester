using cs330_proj1;
namespace CourseProject.Test{

public class CourseTest
{
    [Fact]
    public void OfferingsByGoalAndSemester_GoalIDIsNull_ThrowsException(){
        CourseServices service = new CourseServices();

        List<CourseOffering> newList = service.getOfferingsByGoalIdAndSemester(null, null);

        Assert.Throws<Exception>(()=> service.getOfferingsByGoalIdAndSemester(null, null));

    }

    [Fact]
    public void OfferingsByGoalAndSemester_GoalIDIsNotNull_ReturnsList(){

        List<Course> courses = new List<Course>();
        List<CoreGoal> coreGoals = new List<CoreGoal>();
        List<CourseOffering> courseOfferings = new List<CourseOffering>();

        
        Course tc = new Course() {
            Name="TEST 101",
            Title="test class",
            Credits=4.0,
            Description="this is a test class"

        };
        courses.Add(tc);

        CoreGoal tg = new CoreGoal() {
            Id="TG1",
            Name="Test Goal",
            Description="description for test",
            Courses = new List<Course>() {tc}
        };
        coreGoals.Add(tg);

        CourseOffering tco = new CourseOffering() {
            TheCourse=tc,
            Section="T1",
            Semester="Spring 2021"

        };
        courseOfferings.Add(tco);
        
        CourseRepository _repo = new CourseRepository(courses, coreGoals, courseOfferings);
    }    
}
}