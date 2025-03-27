namespace Strings.Test
{
    public class NamesTest
    {
        [Fact]
        public void MakeFullName_GivenFirstNameLastName_ReturnsFullName()
        {
            // Arrange
            var name = new Names();

            // Act
            var fullName = name.MakeFullName("Rodrigo", "Kmiecik");

            // Assert

            Assert.Equal("Rodrigo Kmiecik", fullName);
        }

        [Fact]
        public void MakeFullName_GivenFirstNameLastNameIgnoringCase_ReturnsFullName()
        {
            // Arrange
            var name = new Names();

            // Act
            var fullName = name.MakeFullName("Rodrigo", "Kmiecik");

            // Assert

            Assert.Equal("rOdRiGo KmIeCik", fullName, ignoreCase: true);
        }

        [Fact]
        public void MakeFullName_GivenFirstNameLastName_FirstNameExists()
        {
            // Arrange
            var name = new Names();

            // Act
            var fullName = name.MakeFullName("Rodrigo", "Kmiecik");

            // Assert

            Assert.Contains("Rodrigo", fullName);
        }

        [Fact]
        public void MakeFullName_GivenFirstNameLastName_BeginsWithFirstName()
        {
            // Arrange
            var name = new Names();

            // Act
            var fullName = name.MakeFullName("Rodrigo", "Kmiecik");

            // Assert

            Assert.StartsWith("Rodrigo", fullName);
        }

        [Fact]
        public void MakeFullName_GivenFirstNameLastName_MatchesRegex()
        {
            // Arrange
            var name = new Names();

            // Act
            var fullName = name.MakeFullName("Rodrigo", "Kmiecik");

            // Assert

            Assert.Matches("^[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+$", fullName);
        }

        [Fact]
        public void MakeFullName_GivenFirstNameLastNameBeforeAndAfterCallMethod_VerifyInitials()
        {
            // Arrange
            var name = new Names();

            // Act
            Assert.Null(name.Initials); // an assert is used before the act to verify if the variable is null. The method is not called yet, so the variable is suposed to be null
            var fullName = name.MakeFullName("Rodrigo", "Kmiecik");

            // Assert
            Assert.NotNull(name.Initials); // here the variable cannot be null, because the method is already called
            Assert.True(!String.IsNullOrEmpty(name.Initials));
        }
    }
}
