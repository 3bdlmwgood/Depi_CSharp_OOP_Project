using OOP_Project.Exam;
using OOP_Project.Question;
using OOP_Project.Answer;


namespace OOP_Project
{
    /// <summary>
    /// Main entry point for the OOP Exam Management System application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main entry point that demonstrates the creation and usage of an exam system.
        /// Creates a subject, adds questions (True/False and Multiple Choice), and displays the exam.
        /// </summary>
        /// <param name="args">Command-line arguments (not used).</param>
        static void Main(string[] args)
        {
            TestFinalExam();

            Console.WriteLine("\n\nPress any key to test Practical Exam...");
            Console.ReadKey();

            TestPracticalExam();

            Console.ReadKey();
        }

        static void TestFinalExam()
        {
            Subject subject = new Subject(1, "C# OOP");

            List<Question.Question> questions = new List<Question.Question>();

            // ---------------- Question 1 ----------------

            Answer.Answer q1Answer1 = new Answer.Answer(1, "True");
            Answer.Answer q1Answer2 = new Answer.Answer(2, "False");

            List<Answer.Answer> q1Answers = new List<Answer.Answer>
            {
                q1Answer1,
                q1Answer2
            };

            TrueFalseQuestion question1 =
                new TrueFalseQuestion(
                    "Question 1",
                    "C# supports Object-Oriented Programming.",
                    5,
                    q1Answers,
                    q1Answer1
                );

            questions.Add(question1);


            // ---------------- Question 2 ----------------

            Answer.Answer q2Answer1 = new Answer.Answer(1, "C#");
            Answer.Answer q2Answer2 = new Answer.Answer(2, "HTML");
            Answer.Answer q2Answer3 = new Answer.Answer(3, "CSS");
            Answer.Answer q2Answer4 = new Answer.Answer(4, "SQL");

            List<Answer.Answer> q2Answers = new List<Answer.Answer>
            {
                q2Answer1,
                q2Answer2,
                q2Answer3,
                q2Answer4
            };

            MCQQuestion question2 =
                new MCQQuestion(
                    "Question 2",
                    "Which language is mainly used to build applications with .NET?",
                    5,
                    q2Answers,
                    q2Answer1
                );

            questions.Add(question2);


            // ---------------- Question 3 ----------------

            Answer.Answer q3Answer1 = new Answer.Answer(1, "Class");
            Answer.Answer q3Answer2 = new Answer.Answer(2, "Object");
            Answer.Answer q3Answer3 = new Answer.Answer(3, "Method");
            Answer.Answer q3Answer4 = new Answer.Answer(4, "Variable");

            List<Answer.Answer> q3Answers = new List<Answer.Answer>
            {
                q3Answer1,
                q3Answer2,
                q3Answer3,
                q3Answer4
            };

            MCQQuestion question3 =
                new MCQQuestion(
                    "Question 3",
                    "Which keyword is used to create a class in C#?",
                    5,
                    q3Answers,
                    q3Answer1
                );

            questions.Add(question3);


            // ---------------- Question 4 ----------------

            Answer.Answer q4Answer1 = new Answer.Answer(1, "True");
            Answer.Answer q4Answer2 = new Answer.Answer(2, "False");

            List<Answer.Answer> q4Answers = new List<Answer.Answer>
            {
                q4Answer1,
                q4Answer2
            };

            TrueFalseQuestion question4 =
                new TrueFalseQuestion(
                    "Question 4",
                    "Inheritance allows a class to inherit members from another class.",
                    5,
                    q4Answers,
                    q4Answer1
                );

            questions.Add(question4);


            // ---------------- Question 5 ----------------

            Answer.Answer q5Answer1 = new Answer.Answer(1, "private");
            Answer.Answer q5Answer2 = new Answer.Answer(2, "public");
            Answer.Answer q5Answer3 = new Answer.Answer(3, "static");
            Answer.Answer q5Answer4 = new Answer.Answer(4, "abstract");

            List<Answer.Answer> q5Answers = new List<Answer.Answer>
            {
                q5Answer1,
                q5Answer2,
                q5Answer3,
                q5Answer4
            };

            MCQQuestion question5 =
                new MCQQuestion(
                    "Question 5",
                    "Which access modifier allows a member to be accessed from anywhere?",
                    5,
                    q5Answers,
                    q5Answer2
                );

            questions.Add(question5);


            // ==========================================
            // Create Final Exam
            // ==========================================

            Exam.Exam exam =
                subject.CreateExam(
                    60,
                    questions,
                    enExamType.Final);

            Console.WriteLine(subject);
            Console.WriteLine(exam);

            Console.WriteLine();

            exam.ShowExam();
        }

        static void TestPracticalExam()
        {
            Subject subject = new Subject(2, "C# Programming");

            List<Question.Question> questions = new List<Question.Question>();

            // ---------------- Question 1 ----------------

            Answer.Answer q1Answer1 = new Answer.Answer(1, "Encapsulation");
            Answer.Answer q1Answer2 = new Answer.Answer(2, "Inheritance");
            Answer.Answer q1Answer3 = new Answer.Answer(3, "Polymorphism");
            Answer.Answer q1Answer4 = new Answer.Answer(4, "Compilation");

            List<Answer.Answer> q1Answers = new List<Answer.Answer> {q1Answer1,q1Answer2,q1Answer3,q1Answer4};

            MCQQuestion question1 =new MCQQuestion("Question 1","Which OOP concept allows the same method to behave differently?",5,q1Answers,q1Answer3);

            questions.Add(question1);


            // ---------------- Question 2 ----------------

            Answer.Answer q2Answer1 = new Answer.Answer(1, "List");
            Answer.Answer q2Answer2 = new Answer.Answer(2, "String");
            Answer.Answer q2Answer3 = new Answer.Answer(3, "Integer");
            Answer.Answer q2Answer4 = new Answer.Answer(4, "Boolean");

            List<Answer.Answer> q2Answers = new List<Answer.Answer> {q2Answer1,q2Answer2,q2Answer3,q2Answer4};

            MCQQuestion question2 =new MCQQuestion("Question 2","Which collection can store multiple elements in C#?",5,q2Answers,q2Answer1);

            questions.Add(question2);


            // ---------------- Question 3 ----------------

            Answer.Answer q3Answer1 = new Answer.Answer(1, "override");
            Answer.Answer q3Answer2 = new Answer.Answer(2, "new");
            Answer.Answer q3Answer3 = new Answer.Answer(3, "base");
            Answer.Answer q3Answer4 = new Answer.Answer(4, "this");

            List<Answer.Answer> q3Answers = new List<Answer.Answer> {q3Answer1,q3Answer2,q3Answer3,q3Answer4};

            MCQQuestion question3 = new MCQQuestion("Question 3","Which keyword is used to override a virtual method?",5,q3Answers,q3Answer1);

            questions.Add(question3);


            // ---------------- Question 4 ----------------

            Answer.Answer q4Answer1 = new Answer.Answer(1, "Interface");
            Answer.Answer q4Answer2 = new Answer.Answer(2, "Namespace");
            Answer.Answer q4Answer3 = new Answer.Answer(3, "Property");
            Answer.Answer q4Answer4 = new Answer.Answer(4, "Constructor");

            List<Answer.Answer> q4Answers = new List<Answer.Answer>  {q4Answer1,q4Answer2,q4Answer3,q4Answer4};

            MCQQuestion question4 = new MCQQuestion("Question 4","Which C# type is commonly used to define a contract?",5,q4Answers,q4Answer1);

            questions.Add(question4);


            // ---------------- Question 5 ----------------

            Answer.Answer q5Answer1 = new Answer.Answer(1, "IComparable");
            Answer.Answer q5Answer2 = new Answer.Answer(2, "ICloneable");
            Answer.Answer q5Answer3 = new Answer.Answer(3, "IDisposable");
            Answer.Answer q5Answer4 = new Answer.Answer(4, "IEnumerable");

            List<Answer.Answer> q5Answers = new List<Answer.Answer>{q5Answer1,q5Answer2,q5Answer3,q5Answer4};

            MCQQuestion question5 = new MCQQuestion("Question 5","Which interface is used to compare objects?",5,q5Answers,q5Answer1);

            questions.Add(question5);


            Exam.Exam exam = subject.CreateExam(45,questions,enExamType.Practical);

            Console.WriteLine(subject);
            Console.WriteLine(exam);

            Console.WriteLine();

            exam.ShowExam();
        }
    }

}
