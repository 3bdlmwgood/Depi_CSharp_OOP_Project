using OOP_Project.Answer;
using OOP_Project.Exam;
using OOP_Project.Question;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project_Tests
{
    public class FinalExamTests
    {
        [Fact]
        public void FinalExam_Constructor_ShouldSetExamType()
        {
            // Arrange
            List<Question> questions = new List<Question>();

            // Act
            FinalExam exam = new FinalExam(60, questions, enExamType.Final);

            // Assert
            Assert.Equal(enExamType.Final, exam.ExamType);
            Assert.Equal(60, exam.TimeOfExam);
            Assert.Equal(0, exam.NumberOfQuestions);
        }


        [Fact]
        public void FinalExam_ShouldContainQuestions()
        {
            // Arrange
            Answer answer = new Answer(1, "True");

            List<Answer> answers = new List<Answer> {answer };

            MCQQuestion question = new MCQQuestion("Question 1","Test Question",5,answers,answer);

            List<Question> questions =new List<Question>{question};

            // Act
            FinalExam exam =new FinalExam(60, questions, enExamType.Final);

            // Assert
            Assert.Equal(1, exam.NumberOfQuestions);
            Assert.Equal(question, exam.Questions[0]);
        }
    }
}
