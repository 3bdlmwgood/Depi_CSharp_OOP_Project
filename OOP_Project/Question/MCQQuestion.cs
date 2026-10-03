using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project.Question
{
    public class MCQQuestion : Question
    {
        public MCQQuestion() : base()
        {
            
        }

        public MCQQuestion(string header, string body, double mark, List<Answer.Answer> answers, Answer.Answer rightAnswer) 
            : base(header, body, mark, answers, rightAnswer)
        {
            
        }

        public override string ToString()
        {
            return $"MCQ: {Body}";
        }
    }
}
