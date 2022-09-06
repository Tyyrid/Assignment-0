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
        public void Checks_if_user_gets_yay_feedback()
    {
        //Arrange//
        var sut = new LeapYear();
        //var feedback = "";
        using var writer = new StringWriter();
        Console.SetOut(writer);

        var textReader = new StringReader("2000");
        Console.SetIn(textReader);
	    

        //Act//
        sut.isLeapYearWithUserInput();

        //Assert//
        var output = writer.GetStringBuilder();
        var lines = output.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
        Assert.Equal("yay", lines[1]);


        /*var outputLines = writer.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        if(String.Equals(outputLines[2], "yay")) {
            feedback = "yay";
        } else {
            feedback = "nay";
        }
        Assert.Equal("Enter year: ", outputLines[0]); //Sammenligner det som console skriver (men som bruger kan man ikke se det længere)
        Assert.Equal(outputLines[1], outputLines[1]); //Sammenligner input frá bruger
        Assert.Equal(feedback, outputLines[2]); //Sammenligner feedback ("yay" eller "nay")*/
        
    }


    //år før 1582
    /*[Fact]
    public void check_exception_when_year_before_1582() {
        //Arrange//
        var sut = new LeapYear();
        using var writer = new StringWriter();
        Console.SetOut(writer);

        var textReader = new StringReader("1581");
        Console.SetIn(textReader);

        //Act//
        sut.isLeapYearWithUserInput();
       
        //Assert//
        var output = writer.GetStringBuilder();
        var lines = output.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
        Assert.Equal("Please enter a year after 1582.", lines[1]);

    }*/


    //bogstaver + andet
    [Fact]
       public void check_exception_when_input_is_invalid() {
        //Arrange//
        var sut = new LeapYear();
        using var writer = new StringWriter();
        Console.SetOut(writer);

        var textReader = new StringReader("Hej");
        Console.SetIn(textReader);

        //Act//
        sut.isLeapYearWithUserInput();
       
        //Assert//
        var output = writer.GetStringBuilder();
        var lines = output.ToString().Split(Environment.NewLine, StringSplitOptions.TrimEntries);
        Assert.Equal("Please enter a valid year", lines[1]);

    }
  
}