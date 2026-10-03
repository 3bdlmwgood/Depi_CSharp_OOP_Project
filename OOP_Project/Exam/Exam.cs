using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project.Exam
{
    /// <summary>
    /// Represents an abstract base class for different types of exams.
    /// </summary>
    public abstract class Exam
    {
        /// <summary>
        /// Gets or sets the duration of the exam in minutes.
        /// </summary>
        public int TimeOfExam { get; set; }

        /// <summary>
        /// Gets the total number of questions in the exam.
        /// </summary>
        public int NumberOfQuestions { get { return Questions.Count; } }

        /// <summary>
        /// Gets or sets the type of the exam (Final or Practical).
        /// </summary>
        public enExamType ExamType { get; set; }

        /// <summary>
        /// Gets or sets the list of questions in the exam.
        /// </summary>
        public List<Question.Question> Questions { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Exam"/> class with default values.
        /// </summary>
        public Exam()
        {
            TimeOfExam = 0;
            Questions = new List<Question.Question>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Exam"/> class with specified values.
        /// </summary>
        /// <param name="timeOfExam">The duration of the exam in minutes.</param>
        /// <param name="questions">The list of questions for the exam.</param>
        /// <param name="examType">The type of the exam.</param>
        protected Exam(int timeOfExam, List<Question.Question> questions,enExamType examType)
        {
            TimeOfExam = timeOfExam;
            Questions = questions;
            ExamType = examType;
        }

        /// <summary>
        /// Displays the exam questions and collects user responses.
        /// </summary>
        public abstract void ShowExam();

        /// <summary>
        /// Creates a shallow copy of the current exam.
        /// </summary>
        /// <returns>A new object that is a shallow copy of the current exam.</returns>
        public virtual object Clone()
        {
            return MemberwiseClone();
        }

        /// <summary>
        /// Compares the current exam with another exam based on exam duration.
        /// </summary>
        /// <param name="other">The exam to compare with.</param>
        /// <returns>A value indicating the relative order of the objects being compared.</returns>
        public int CompareTo(Exam other)
        {
            if (other == null)
                return 1;

            return TimeOfExam.CompareTo(other.TimeOfExam);
        }

        /// <summary>
        /// Returns a string representation of the exam.
        /// </summary>
        /// <returns>A formatted string containing exam type, duration, and number of questions.</returns>
        public override string ToString()
        {
            return $"Exam Type: {ExamType}, Time of Exam: {TimeOfExam} Minutes, Number of Questions: {NumberOfQuestions}";
        }
    }
}
