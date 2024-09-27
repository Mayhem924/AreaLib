using AreaLib.Figures;

namespace AreaLib.Unit;

public class CircleTests
{
    [Fact]
    public void GetCircleArea_ValidData_ShouldEqual()
    {
        // Arrange
        var areaCalculator = new AreaCalculator();
        var circle = new Circle("Circle1", 50);

        // Act
        var circleArea = areaCalculator.GetArea(circle);
        
        // Assert
        Assert.Equal(7853.981633974483, circleArea);
    }
    
    [Fact]
    public void GetCircleArea_InvalidData_ShouldNotEqual()
    {
        // Arrange
        var areaCalculator = new AreaCalculator();
        var circle = new Circle("Circle1", 25);

        // Act
        var circleArea = areaCalculator.GetArea(circle);
        
        // Assert
        Assert.NotEqual(7853.981633974483, circleArea);
    }
}