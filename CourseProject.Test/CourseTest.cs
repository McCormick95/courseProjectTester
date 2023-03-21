using cs330_proj1;
using Moq;
namespace CourseProject.Test{

public class CourseTest
{
    [Fact]
    public void OfferingsByGoalAndSemester_GoalIDIsNull_ThrowsException(){
        var repo = new Mock<CourseServices.ICourseRepository>();

        CourseServices service = new CourseServices(repo);

        List<CourseOffering> newList = service.getOfferingsByGoalIdAndSemester(null, null);

        Assert.Throws<Exception>(()=> service.getOfferingsByGoalIdAndSemester(null, null));

    }

    [Fact]
    public void OfferingsByGoalAndSemester_GoalIDIsNotNull_ReturnsList(){

        var repo = new Mock<CourseServices.ICourseRepository>();


         CourseServices courseSer = new CourseServices(repo);


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
        
        //CourseRepository _repo = new CourseRepository(courses, coreGoals, courseOfferings);

        repo.Setup(m=>m.getOfferingsByGoalIdAndSemester("TG1", "Spring 2021").Returns(courseOfferings));

        
        
    }    
}
}