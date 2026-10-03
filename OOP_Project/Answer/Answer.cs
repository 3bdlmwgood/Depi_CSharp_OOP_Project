using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project.Answer
{
    /// <summary>
    /// Represents an answer option for an exam question.
    /// </summary>
    public class Answer
    {
        /// <summary>
        /// Gets or sets the unique identifier for the answer.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the text content of the answer.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Answer"/> class with default values.
        /// </summary>
        public Answer()
        {
            Id = 0;
            Text = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Answer"/> class with specified values.
        /// </summary>
        /// <param name="AnswerId">The unique identifier for the answer.</param>
        /// <param name="AnswerText">The text content of the answer.</param>
        public Answer(int AnswerId, string AnswerText)
        {
            Id = AnswerId;
            Text = AnswerText;
        }
            
        /// <summary>
        /// Returns a string representation of the answer.
        /// </summary>
        /// <returns>A formatted string containing the answer ID and text.</returns>
        public override string ToString()
        {
            return $"Answer Id: {Id}, Answer Text: {Text}";
        }
    }
}
