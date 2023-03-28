using cs330_proj1;
using Moq;

namespace CourseProject.Test{

public class CourseTest
{
    [Fact]
    public void OfferingsByGoalAndSemester_IsNull_ThrowsException(){
       var repo = new Mock<ICourseRepository>();
        
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
        repo.Setup(m=>m.GetCourses()).Returns(courses);

        CoreGoal tg = new CoreGoal() {
            Id="TG1",
            Name="Test Goal",
            Description="description for test",
            Courses = new List<Course>() {tc}
        };
        coreGoals.Add(tg);
        repo.Setup(m=>m.GetCoreGoals()).Returns(coreGoals);

        CourseOffering tco = new CourseOffering() {
            TheCourse=tc,
            Section="T1",
            Semester="Spring 2021"

        };
        courseOfferings.Add(tco);
        repo.Setup(m=>m.GetCourseOfferings()).Returns(courseOfferings);

        CourseServices courseSer = new CourseServices(repo.Object);

        //List<CourseOffering> newList = service.getOfferingsByGoalIdAndSemester(null, null);

        Assert.Throws<Exception>(()=> courseSer.getOfferingsByGoalIdAndSemester(null, null));

    }

    [Fact]
    public void OfferingsByGoalAndSemester_GoalIDIsNotNull_ReturnsList(){
        var repo = new Mock<ICourseRepository>();
        
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
        repo.Setup(m=>m.GetCourses()).Returns(courses);

        CoreGoal tg = new CoreGoal() {
            Id="TG1",
            Name="Test Goal",
            Description="description for test",
            Courses = new List<Course>() {tc}
        };
        coreGoals.Add(tg);
        repo.Setup(m=>m.GetCoreGoals()).Returns(coreGoals);

        CourseOffering tco = new CourseOffering() {
            TheCourse=tc,
            Section="T1",
            Semester="Spring 2021"

        };
        courseOfferings.Add(tco);
        repo.Setup(m=>m.GetCourseOfferings()).Returns(courseOfferings);
        

        CourseServices courseSer = new CourseServices(repo.Object);

        List<CourseOffering> m = courseSer.getOfferingsByGoalIdAndSemester("TG1", "Spring 2021");

        Assert.Equal(courseOfferings, m);
        //CourseRepository _repo = new CourseRepository(courses, coreGoals, courseOfferings);  
    }  

    [Fact]
    public void GetCourses_ReturnsList(){
        var repo = new Mock<ICourseRepository>();
        
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
        repo.Setup(m=>m.GetCourses()).Returns(courses);

        CoreGoal tg = new CoreGoal() {
            Id="TG1",
            Name="Test Goal",
            Description="description for test",
            Courses = new List<Course>() {tc}
        };
        coreGoals.Add(tg);
        repo.Setup(m=>m.GetCoreGoals()).Returns(coreGoals);

        CourseOffering tco = new CourseOffering() {
            TheCourse=tc,
            Section="T1",
            Semester="Spring 2021"

        };
        courseOfferings.Add(tco);
        repo.Setup(m=>m.GetCourseOfferings()).Returns(courseOfferings);
        

        CourseServices courseSer = new CourseServices(repo.Object);

        List<Course> m = courseSer.getCourses();

        Assert.Equal(courses, m);
    }

    [Fact]
    public void GetCourseOfferingsBySemester_IsNull_ThrowsException(){
        var repo = new Mock<ICourseRepository>();
        
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
        repo.Setup(m=>m.GetCourses()).Returns(courses);

        CoreGoal tg = new CoreGoal() {
            Id="TG1",
            Name="Test Goal",
            Description="description for test",
            Courses = new List<Course>() {tc}
        };
        coreGoals.Add(tg);
        repo.Setup(m=>m.GetCoreGoals()).Returns(coreGoals);

        CourseOffering tco = new CourseOffering() {
            TheCourse=tc,
            Section="T1",
            Semester="Spring 2021"

        };
        courseOfferings.Add(tco);
        repo.Setup(m=>m.GetCourseOfferings()).Returns(courseOfferings);
        

        CourseServices courseSer = new CourseServices(repo.Object);

        Assert.Throws<Exception>(()=> courseSer.getCourseOfferingsBySemester(null));
    }

    [Fact]
    public void GetCourseOfferingsBySemester_SemesterIsNotNull_ReturnsOfferings(){
        var repo = new Mock<ICourseRepository>();
        
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
        repo.Setup(m=>m.GetCourses()).Returns(courses);

        CoreGoal tg = new CoreGoal() {
            Id="TG1",
            Name="Test Goal",
            Description="description for test",
            Courses = new List<Course>() {tc}
        };
        coreGoals.Add(tg);
        repo.Setup(m=>m.GetCoreGoals()).Returns(coreGoals);

        CourseOffering tco = new CourseOffering() {
            TheCourse=tc,
            Section="T1",
            Semester="Spring 2021"

        };
        courseOfferings.Add(tco);
        repo.Setup(m=>m.GetCourseOfferings()).Returns(courseOfferings);
        

        CourseServices courseSer = new CourseServices(repo.Object);

        List<CourseOffering> m = courseSer.getCourseOfferingsBySemester("Spring 2021");

        Assert.Equal(courseOfferings, m);
    }

    [Fact]
    public void GetCourseOfferingsBySemesterAndDept_IsNull_ThrowsException(){
        var repo = new Mock<ICourseRepository>();
        
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
        repo.Setup(m=>m.GetCourses()).Returns(courses);

        CoreGoal tg = new CoreGoal() {
            Id="TG1",
            Name="Test Goal",
            Description="description for test",
            Courses = new List<Course>() {tc}
        };
        coreGoals.Add(tg);
        repo.Setup(m=>m.GetCoreGoals()).Returns(coreGoals);

        CourseOffering tco = new CourseOffering() {
            TheCourse=tc,
            Section="T1",
            Semester="Spring 2021"

        };
        courseOfferings.Add(tco);
        repo.Setup(m=>m.GetCourseOfferings()).Returns(courseOfferings);
        
        CourseServices courseSer = new CourseServices(repo.Object);

        Assert.Throws<Exception>(()=> courseSer.getCourseOfferingsBySemesterAndDept(null, null));
    }

    [Fact]
    public void GetCourseOfferingsBySemesterAndDept_IsNotNull_ReturnsList(){
        var repo = new Mock<ICourseRepository>();
        
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
        repo.Setup(m=>m.GetCourses()).Returns(courses);

        CoreGoal tg = new CoreGoal() {
            Id="TG1",
            Name="Test Goal",
            Description="description for test",
            Courses = new List<Course>() {tc}
        };
        coreGoals.Add(tg);
        repo.Setup(m=>m.GetCoreGoals()).Returns(coreGoals);

        CourseOffering tco = new CourseOffering() {
            TheCourse=tc,
            Section="T1",
            Semester="Spring 2021"

        };
        courseOfferings.Add(tco);
        repo.Setup(m=>m.GetCourseOfferings()).Returns(courseOfferings);
        
        CourseServices courseSer = new CourseServices(repo.Object);

        List<CourseOffering> m = courseSer.getCourseOfferingsBySemesterAndDept("Spring 2021", "TEST");

        Assert.Equal(courseOfferings, m);
    }

}
}