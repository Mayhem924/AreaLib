using AreaLib.Figures;

namespace AreaLib.Unit;

public class TriangleTests
{
    [Fact]
    public void GetTriangleArea_ValidData_ShouldEqual()
    {
        // Arrange
        var areaCalculator = new AreaCalculator();
        var triangle = new Triangle("Triangle1", 16, 12, 20);

        // Act
        var triangleArea = areaCalculator.GetArea(triangle);
        
        // Assert
        Assert.Equal(96, triangleArea);
    }
    
    [Fact]
    public void GetTriangleArea_InvalidData_ShouldNotEqual()
    {
        // Arrange
        var areaCalculator = new AreaCalculator();
        var triangle = new Triangle("Triangle1", 17, 15, 25);

        // Act
        var triangleArea = areaCalculator.GetArea(triangle);
        
        // Assert
        Assert.NotEqual(96, triangleArea);
    }
    
    [Fact]
    public void CheckIsRightTriangle_ValidData_ShouldTrue()
    {
        // Arrange
        var triangle = new Triangle("Triangle1", 12, 16, 20);

        // Act
        var isRightTriangle = triangle.CheckRightTriangle();
        
        // Assert
        Assert.True(isRightTriangle);
    }
    
    [Fact]
    public void CheckIsRightTriangle_InvalidData_ShouldFalse()
    {
        // Arrange
        var triangle = new Triangle("Triangle1", 18, 15, 19);

        // Act
        var isRightTriangle = triangle.CheckRightTriangle();
        
        // Assert
        Assert.False(isRightTriangle);
    }
}