namespace MyApp.Tests;

public class MyAppTests
{
    [Fact]
    public void Checks_if_year_2000_is_leap_year()
    {
        //Arrange//
        var sut = new LeapYear();

        //Act//
        var result = sut.isLeapYear(2000);

        //Assert//
        result.Should().Be(true);
    }

    [Fact]
        public void Checks_if_year_1700_is_leap_year()
    {
        //Arrange//
        var sut = new LeapYear();

        //Act//
        var result = sut.isLeapYear(1700);

        //Assert//
        result.Should().Be(false);
    }

        [Fact]
        public void Checks_if_user_gets_correct_feedback()
    {
        //Arrange//
        var sut = new LeapYear();
        var yayFeedback = "yay";
        //var nayFeedback = "nay";
        using var writer = new StringWriter();
        Console.SetOut(writer);
	    
	    /*var reader = new StringReader(yayFeedback);
	    Console.SetIn(reader);*/

        //Act//
        sut.isLeapYearWithUserInput();

        /*var program = Assembly.load(nameof(HelloWorld));
        program.EntryPoint?.Invoke(null, new[] {Array.Empty<string>() });*/

        //Assert//
        //var output = writer.GetStringBuilder().ToString().TrimEnd();
        var outputLines = writer.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        Assert.Equal("Enter year: ", outputLines[0]);
        Assert.Equal($"yay", outputLines[1]);
        //yayFeedback.Should().Be(output);
    }
  
}