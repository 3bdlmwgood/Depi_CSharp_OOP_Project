using OOP_Project.Exam;
using OOP_Project.Question;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project_Tests
{
    public class SubjectTests
    {
        [Fact]
        public void CreateExam_ShouldCreateFinalExam()
        {
            // Arrange
            Subject subject = new Subject(1, "C# OOP");

            List<Question> questions = new List<Question>();

            // Act
            Exam exam = subject.CreateExam(60,questions,enExamType.Final);

            // Assert
            Assert.NotNull(exam);
            Assert.IsType<FinalExam>(exam);
            Assert.Equal(enExamType.Final, exam.ExamType);
            Assert.Equal(60, exam.TimeOfExam);
        }


        [Fact]
        public void CreateExam_ShouldCreatePracticalExam()
        {
            // Arrange
            Subject subject = new Subject(2, "C# Programming");

            List<Question> questions = new List<Question>();

            // Act
            Exam exam = subject.CreateExam( 45, questions, enExamType.Practical);

            // Assert
            Assert.NotNull(exam);
            Assert.IsType<PracticalExam>(exam);
            Assert.Equal(enExamType.Practical, exam.ExamType);
            Assert.Equal(45, exam.TimeOfExam);
        }


        [Fact]
        public void Subject_ShouldStoreCreatedExam()
        {
            // Arrange
            Subject subject = new Subject(1, "C# OOP");

            List<Question> questions = new List<Question>();

            // Act
            Exam exam = subject.CreateExam(60,questions,enExamType.Final);

            // Assert
            Assert.Equal(exam, subject.Exam);
        }
    }
}
