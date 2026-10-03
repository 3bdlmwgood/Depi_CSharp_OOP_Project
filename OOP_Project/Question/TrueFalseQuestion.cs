using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project.Question
{
    /// <summary>
    /// Represents a True/False question type.
    /// </summary>
    public class TrueFalseQuestion : Question
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseQuestion"/> class with default values.
        /// </summary>
        public TrueFalseQuestion() : base()
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrueFalseQuestion"/> class with specified values.
        /// </summary>
        /// <param name="header">The header/title of the question.</param>
        /// <param name="body">The text content of the question.</param>
        /// <param name="mark">The mark/points for this question.</param>
        /// <param name="answers">The list of answer options (True and False).</param>
        /// <param name="rightAnswer">The correct answer.</param>
        public TrueFalseQuestion(string header, string body, double mark, List<Answer.Answer> answers, Answer.Answer rightAnswer) 
            : base(header, body, mark, answers, rightAnswer)
        {

        }

        /// <summary>
        /// Returns a string representation of the True/False question.
        /// </summary>
        /// <returns>A formatted string in the format "True/False: [question body]".</returns>
        public override string ToString()
        {
            return $"True/False: {Body}";
        }
    }
}
