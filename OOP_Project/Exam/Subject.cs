using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project.Exam
{
    /// <summary>
    /// Represents an academic subject that can have an associated exam.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Gets or sets the unique identifier for the subject.
        /// </summary>
        protected int SubjectId { get; set; }

        /// <summary>
        /// Gets or sets the name of the subject.
        /// </summary>
        protected string SubjectName { get; set; }

        /// <summary>
        /// Gets or sets the exam associated with this subject.
        /// </summary>
        public Exam Exam { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subject"/> class with default values.
        /// </summary>
        public Subject()
        {
            SubjectId = 0;
            SubjectName = string.Empty;
            Exam = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Subject"/> class with specified values.
        /// </summary>
        /// <param name="subjectId">The unique identifier for the subject.</param>
        /// <param name="subjectName">The name of the subject.</param>
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        /// <summary>
        /// Creates an exam for this subject based on the specified exam type.
        /// </summary>
        /// <param name="timeOfExam">The duration of the exam in minutes.</param>
        /// <param name="questions">The list of questions for the exam.</param>
        /// <param name="examType">The type of exam to create (Final or Practical).</param>
        /// <returns>The created exam object.</returns>
        /// <exception cref="ArgumentException">Thrown when an invalid exam type is provided.</exception>
        public Exam CreateExam(int timeOfExam, List<Question.Question> questions, enExamType examType)
        {
            switch (examType)
            {
                case enExamType.Final:

                    Exam = new FinalExam(timeOfExam,questions,examType);
                    break;

                case enExamType.Practical:

                    Exam = new PracticalExam(timeOfExam,questions,examType);
                    break;

                default:
                    throw new ArgumentException("Invalid exam type");
            }

            return Exam;
        }

        /// <summary>
        /// Returns a string representation of the subject.
        /// </summary>
        /// <returns>A formatted string containing subject ID, name, and associated exam information.</returns>
        public override string ToString()
        {
            return $"Subject Id: {SubjectId}, Subject Name: {SubjectName}, Exam: {Exam}";
        }

    }
}
