using OOP_Project.Answer;
using OOP_Project.Question;

namespace OOP_Project_Tests
{
    public class QuestionTests
    {
        [Fact]
        public void MCQQuestion_Constructor_ShouldSetData()
        {
            // Arrange
            Answer answer1 = new Answer(1, "C#");
            Answer answer2 = new Answer(2, "Java");

            List<Answer> answers = new List<Answer>
            {
                answer1,
                answer2
            };

            // Act
            MCQQuestion question =new MCQQuestion("Question 1","Which language is used with .NET?",5,answers,answer1);

            // Assert
            Assert.Equal("Question 1", question.Header);
            Assert.Equal("Which language is used with .NET?",question.Body);

            Assert.Equal(5, question.Mark);
            Assert.Equal(2, question.Answers.Count);
            Assert.Equal(answer1, question.RightAnswer);
        }


        [Fact]
        public void TrueFalseQuestion_Constructor_ShouldSetData()
        {
            // Arrange
            Answer answer1 = new Answer(1, "True");
            Answer answer2 = new Answer(2, "False");

            List<Answer> answers = new List<Answer>
            {
                answer1,
                answer2
            };

            // Act
            TrueFalseQuestion question = new TrueFalseQuestion("Question 1","C# is an OOP language.",5,answers,answer1 );

            // Assert
            Assert.Equal("Question 1", question.Header);
            Assert.Equal("C# is an OOP language.", question.Body);
            Assert.Equal(5, question.Mark);
            Assert.Equal(2, question.Answers.Count);
            Assert.Equal(answer1, question.RightAnswer);
        }


        [Fact]
        public void Question_CompareTo_ShouldCompareByMark()
        {
            // Arrange
            MCQQuestion question1 = new MCQQuestion();

            MCQQuestion question2 = new MCQQuestion();

            question1.Mark = 5;
            question2.Mark = 10;

            // Act
            int result = question1.CompareTo(question2);

            // Assert
            Assert.True(result < 0);
        }


        [Fact]
        public void Question_Clone_ShouldCreateNewObject()
        {
            // Arrange
            MCQQuestion question = new MCQQuestion();

            question.Header = "Question 1";
            question.Body = "Test Question";
            question.Mark = 5;

            // Act
            MCQQuestion clonedQuestion = (MCQQuestion)question.Clone();

            // Assert
            Assert.NotSame(question, clonedQuestion);
            Assert.Equal(question.Header, clonedQuestion.Header);
            Assert.Equal(question.Body, clonedQuestion.Body);
            Assert.Equal(question.Mark, clonedQuestion.Mark);
        }
    }
}
