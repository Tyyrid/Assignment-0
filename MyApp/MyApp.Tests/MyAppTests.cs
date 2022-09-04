namespace MyApp.Tests;

public class MyAppTests
{
    [Fact]
    public void Checks_if_year_2000_is_leap_year()
    {
        //Act//
        var sut = new LeapYear();

        //Arrange//
        var result = sut.IsALeapYear(2000);

        //Assert//
        result.Should().Be(false);
    }
  
}