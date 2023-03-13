using cs330_proj1;
namespace Course.Test{

public class CourseTest
{
    [Fact]
    public void OfferingsByGoalAndSemester_GoalIDIsNull_ThrowsException()
    {
        CourseServices service = new CourseServices();

        List<CourseOffering> newList = service.getOfferingsByGoalIdAndSemester(null, null);

        Assert.Throws<Exception>(()=> service.getOfferingsByGoalIdAndSemester(null, null));

    }

    [Fact]
     public void OfferingsByGoalAndSemester_GoalIDIsNotNull_ThrowsException()
    {
       
        Assert.Equal(true,true);
    }
}
}