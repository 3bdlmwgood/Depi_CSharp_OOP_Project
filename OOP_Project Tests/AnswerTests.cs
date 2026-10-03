using OOP_Project.Answer;

namespace OOP_Project_Tests
{
    public class AnswerTests
    {
        [Fact]
        public void Answer_Constructor_ShouldSetIdAndText()
        {
            // Arrange
            Answer answer = new Answer(1, "True");

            // Assert
            Assert.Equal(1, answer.Id);
            Assert.Equal("True", answer.Text);
        }

        [Fact]
        public void Answer_ToString_ShouldReturnCorrectText()
        {
            // Arrange
            Answer answer = new Answer(1, "True");

            // Act
            string result = answer.ToString();

            // Assert
            Assert.Equal("Answer Id: 1, Answer Text: True", result);
        }
    }
}