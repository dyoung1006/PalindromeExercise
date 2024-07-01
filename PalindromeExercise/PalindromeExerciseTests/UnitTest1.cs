using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("kayak", true)] //Add test data <-------
        [InlineData("mom", true)]
        [InlineData("racecar", true)]
        [InlineData("racecax", false)]
        public void IsAPalindromeTest(string input, bool expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var test = new WordSmith();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = test.IsAPalindrome(input);    
            
            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }
    }
}
