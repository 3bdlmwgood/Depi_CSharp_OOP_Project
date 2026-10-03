using OOP_Project.Answer;
using OOP_Project.Exam;
using OOP_Project.Question;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project_Tests
{
    public class PracticalExamTests
    {
        [Fact]
        public void PracticalExam_Constructor_ShouldSetExamType()
        {
            // Arrange
            List<Question> questions =new List<Question>();

            // Act
            PracticalExam exam =new PracticalExam(45, questions, enExamType.Practical);

            // Assert
            Assert.Equal(enExamType.Practical, exam.ExamType);
            Assert.Equal(45, exam.TimeOfExam);
            Assert.Equal(0, exam.NumberOfQuestions);
        }


        [Fact]
        public void PracticalExam_ShouldContainQuestions()
        {
            // Arrange
            Answer answer1 = new Answer(1, "C#");

            Answer answer2 = new Answer(2, "Java");

            List<Answer> answers = new List<Answer> {answer1,answer2};

            MCQQuestion question = new MCQQuestion( "Question 1", "Which language is used with .NET?", 5, answers, answer1);

            List<Question> questions = new List<Question> { question };

            // Act
            PracticalExam exam = new PracticalExam(45, questions, enExamType.Practical);

            // Assert
            Assert.Equal(1, exam.NumberOfQuestions);
            Assert.Equal(question, exam.Questions[0]);
        }
    }
}
