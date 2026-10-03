using System;
using System.Collections.Generic;
using System.Text;
using OOP_Project.Answer;

namespace OOP_Project.Question
{
    /// <summary>
    /// Represents an abstract base class for different types of exam questions.
    /// </summary>
    public abstract class Question : ICloneable, IComparable<Question>
    {
        /// <summary>
        /// Gets or sets the header/title of the question.
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        /// Gets or sets the text content of the question.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the mark/points awarded for this question.
        /// </summary>
        public double Mark { get; set; }

        /// <summary>
        /// Gets or sets the list of answer options for this question.
        /// </summary>
        public List<Answer.Answer> Answers { get; set; }

        /// <summary>
        /// Gets or sets the correct answer for this question.
        /// </summary>
        public Answer.Answer RightAnswer { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Question"/> class with default values.
        /// </summary>
        public Question()
        {
            Header = string.Empty;
            Body = string.Empty;
            Mark = 0;
            Answers = new List<Answer.Answer>();
            RightAnswer = new Answer.Answer();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Question"/> class with specified values.
        /// </summary>
        /// <param name="header">The header/title of the question.</param>
        /// <param name="body">The text content of the question.</param>
        /// <param name="mark">The mark/points for this question.</param>
        /// <param name="answers">The list of answer options.</param>
        /// <param name="rightAnswer">The correct answer.</param>
        public Question(string header, string body, double mark, List<Answer.Answer> answers, Answer.Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            RightAnswer = rightAnswer;
        }

        /// <summary>
        /// Creates a shallow copy of the current question.
        /// </summary>
        /// <returns>A new object that is a shallow copy of the current question.</returns>
        public virtual object Clone()
        {
            return MemberwiseClone();
        }

        /// <summary>
        /// Compares the current question with another question based on marks.
        /// </summary>
        /// <param name="other">The question to compare with.</param>
        /// <returns>A value indicating the relative order of the objects being compared.</returns>
        public int CompareTo(Question other)
        {
            if (other == null)
                return 1;

            return Mark.CompareTo(other.Mark);
        }

        /// <summary>
        /// Returns a string representation of the question.
        /// </summary>
        /// <returns>A formatted string containing header, body, and mark.</returns>
        public override string ToString()
        {
            return $"Header: {Header}, Body: {Body}, Mark: {Mark}";
        }

    }
}
