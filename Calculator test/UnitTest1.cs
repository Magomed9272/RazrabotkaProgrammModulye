using Xunit;
using System;

public class CalculatorTests
{
    private Calculator calc = new Calculator();
    [Fact]
    public void Divide_NormalNumbers_ReturnsResult()
    {
        int result = calc.Divide(10, 2);
        Assert.Equal(5, result);
        }
    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>
    }
    
}