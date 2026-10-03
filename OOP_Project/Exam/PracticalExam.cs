using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Project.Exam
{
    /// <summary>
    /// Represents a practical exam that displays questions and answers without immediate grading.
    /// </summary>
    public class PracticalExam : Exam
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PracticalExam"/> class with default values.
        /// </summary>
        public PracticalExam()
        {
            ExamType = enExamType.Practical;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PracticalExam"/> class with specified values.
        /// </summary>
        /// <param name="TimeOfExam">The duration of the exam in minutes.</param>
        /// <param name="questions">The list of questions for the exam.</param>
        /// <param name="examType">The type of the exam (should be Practical).</param>
        public PracticalExam(int TimeOfExam, List<Question.Question> questions, enExamType examType) : base(TimeOfExam, questions, examType)
        {

        }

        /// <summary>
        /// Displays the exam questions and collects user responses, then shows all correct answers.
        /// </summary>
        public override void ShowExam()
        {
            Console.WriteLine("\n================ PRACTICAL EXAM ================\n");

            foreach (Question.Question question in Questions)
            {
                Console.WriteLine(question.Body);

                foreach (var answer in question.Answers)
                {
                    Console.WriteLine(answer);
                }

                Console.Write("Your Answer: ");
                int userAnswer = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("\n=============== CORRECT ANSWERS ===============");

            foreach (Question.Question question in Questions)
            {
                Console.WriteLine(question.Body);
                Console.WriteLine($"Correct Answer: {question.RightAnswer}");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Returns a string representation of the practical exam.
        /// </summary>
        /// <returns>A formatted string containing exam duration and number of questions.</returns>
        public override string ToString()
        {
            return $"Practical Exam: Time of Exam: {TimeOfExam} Minutes, Number of Questions: {NumberOfQuestions}";
        }
    }
}
