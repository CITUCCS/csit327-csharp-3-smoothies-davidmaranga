using Shouldly;
using Xunit;

namespace LeapYear.Tests;

public class LeapYearUtilTests
{
    [Theory]
    [InlineData(2020, true)]
    [InlineData(2024, true)]
    [InlineData(2028, true)]
    [InlineData(2019, false)]
    [InlineData(2021, false)]
    [InlineData(2025, false)]
    [Trait("TestGroup", "LeapYearExpected")]
    public void LeapYearUtil_IsLeapYear_ShouldReturnExpected(int year, bool isLeapYear)
    {
        var util = new LeapYearUtil();

        util.IsLeapYear(year).ShouldBe(isLeapYear);
    }

    [Theory]
    [InlineData(2017)]
    [InlineData(2016)]
    [InlineData(2015)]
    [InlineData(1998)]
    [Trait("TestGroup", "LeapYearExcluded")]
    public void LeapYearUtil_IsLeapYear_ReturnFalseOnExcludedYears(int year)
    {
        var util = new LeapYearUtil();

        util.IsLeapYear(year).ShouldBeFalse();
    }
}