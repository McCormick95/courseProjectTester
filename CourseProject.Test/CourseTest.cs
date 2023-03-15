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
     public void OfferingsByGoalAndSemester_GoalIDIsNotNull_ThrowsException(){
        private List<Course> courses;
        private List<CoreGoal> coreGoals;
        private List<CourseOffering> courseOfferings;
        private CourseRepository _repo = new CourseRepository(courses, coreGoals, courseOfferings);
        
    }
}
}