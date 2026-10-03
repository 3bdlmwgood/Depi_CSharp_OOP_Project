using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project.Exam
{
    /// <summary>
    /// Represents a final exam that includes grading of student responses.
    /// </summary>
    public class FinalExam : Exam
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FinalExam"/> class with default values.
        /// </summary>
        public FinalExam() : base()
        {
            ExamType = enExamType.Final; 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinalExam"/> class with specified values.
        /// </summary>
        /// <param name="TimeOfExam">The duration of the exam in minutes.</param>
        /// <param name="questions">The list of questions for the exam.</param>
        /// <param name="examType">The type of the exam (should be Final).</param>
        public FinalExam(int TimeOfExam,List<Question.Question> questions,enExamType examType) : base(TimeOfExam, questions, examType)
        {

        }

        /// <summary>
        /// Displays the exam questions, collects user responses, and calculates the grade.
        /// </summary>
        public override void ShowExam()
        {
            double grade = 0;
            double totalMark = 0;

            Console.WriteLine("\n================ FINAL EXAM ================\n");

            foreach (Question.Question question in Questions)
            {
                Console.WriteLine(question.Body);
                Console.WriteLine($"Mark: {question.Mark}");

                foreach (var answer in question.Answers)
                {
                    Console.WriteLine(answer);
                }

                Console.Write("Your Answer: ");
                int userAnswer = int.Parse(Console.ReadLine());

                if (userAnswer == question.RightAnswer.Id)
                {
                    grade += question.Mark;
                }

                totalMark += question.Mark;

                Console.WriteLine();
            }

            Console.WriteLine("============================================");
            Console.WriteLine($"Your Grade: {grade} / {totalMark}");

        }

        /// <summary>
        /// Returns a string representation of the final exam.
        /// </summary>
        /// <returns>A formatted string containing exam duration and number of questions.</returns>
        public override string ToString()
        {
            return $"Final Exam: Time of Exam: {TimeOfExam} Minutes, Number of Questions: {NumberOfQuestions}";
        }
    }
}