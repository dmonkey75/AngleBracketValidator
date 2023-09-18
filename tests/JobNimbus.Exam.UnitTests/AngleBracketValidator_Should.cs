namespace JobNimbus.Exam.UnitTests;

public class AngleBracketValidator_Should
{ 
    [Fact]
    public void Return_False_When_Only_One_Open_Bracket_From_Input()
    {
        //arrrage 
        var expected = false;
        var input = "this is a string with one < open bracket only.";
        var sut = new AngleBracketValidator();

        //act
        var actual = sut.Validate(input);

        //assert
        Assert.Equal(expected, actual);
    }
     
    [Fact]
    public void Return_False_When_Only_One_Close_Bracket_From_Input()
    {
        //arrrage 
        var expected = false;
        var input = "this is a string with one > close bracket only.";
        var sut = new AngleBracketValidator();

        //act
        var actual = sut.Validate(input);

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Return_False_When_Two_Open_Brackets_But_Only_One_Has_The_Matching_Close_Bracket_From_Input()
    {
        //arrrage 
        var expected = false;
        var input = "this is a string with two open brackets << but only one has the mactching > close bracket.";
        var sut = new AngleBracketValidator();

        //act
        var actual = sut.Validate(input);

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Return_False_When_Three_Open_Brackets_But_Only_One_Has_The_Matching_Close_Bracket_From_Input()
    {
        //arrrage 
        var expected = false;
        var input = "this is a string with three < open < brackets < but only one has the mactching > close bracket.";
        var sut = new AngleBracketValidator();

        //act
        var actual = sut.Validate(input);

        //assert
        Assert.Equal(expected, actual);
    }
      
    [Fact]
    public void Return_False_When_One_Open_Brackets_But_With_Three_Open_Brackets_From_Input()
    {
        //arrrage 
        var expected = false;
        var input = "this is a string with one open < brackets but with three > closing >> bracket.";
        var sut = new AngleBracketValidator();

        //act
        var actual = sut.Validate(input);

        //assert
        Assert.Equal(expected, actual);
    }
     
    [Fact]
    public void Return_False_When_Two_Open_Brackets_Has_A_Match_And_The_Last_One_Does_Have_Closign_Bracket_From_Input()
    {
        //arrrage 
        var expected = false;
        var input = "this is a string with two < open < brackets with a > match > and the last open < bracket has no match closing bracket.";
        var sut = new AngleBracketValidator();

        //act
        var actual = sut.Validate(input);

        //assert
        Assert.Equal(expected, actual);
    }
     
    [Fact]
    public void Return_False_When_First_Open_Bracket_Does_Not_Have_A_Match_And_The_Next_Two_Brackets_Has_Matching_Closing_Bracket_From_Input()
    {
        //arrrage 
        var expected = false;
        var input = "this is a string with first < open bracket with not mraching closing bracket and the next two << open brackets has matching > close > brackets.";
        var sut = new AngleBracketValidator();

        //act
        var actual = sut.Validate(input);

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Return_True_When_No_Angle_Bracket_From_Input()
    {
        //arrrage 
        var expected = true;
        var input = "this is a simple string with no brackets.";
        var sut = new AngleBracketValidator();

        //act
        var actual = sut.Validate(input);

        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Return_True_When_All_Open_Brackets_Has_Matching_Closing_Brackets_From_Input()
    {
        //arrrage 
        var expected = true;
        var input = "this is a string < when < all << open brackets has matching > closing >>> brackets.";
        var sut = new AngleBracketValidator();

        //act
        var actual = sut.Validate(input);

        //assert
        Assert.Equal(expected, actual);
    } 
}