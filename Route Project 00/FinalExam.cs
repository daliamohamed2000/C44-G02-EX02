namespace Route_Project_00
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }
        public override void ShowExam(List<Question> finQues)
        {
            char c;
            do
            {
                Console.WriteLine("Do you want to start exam? (Y|N)");
                char.TryParse(Console.ReadLine(), out c);
            } while (c != 'Y');
            Console.Clear();
            DateTime start = DateTime.Now;
            int totalGrades = 0, examGrades = 0, num = 1;
            int[] ansArr = new int[NumberOfQuestions];

            foreach (Question q in finQues)
            {
                Console.WriteLine("---------------Final Exam---------------\n\n");
                Console.WriteLine($"Time: {Time}min");
                Console.WriteLine(num++ + ")" + q.Header + "           " + "marks: " + q.Mark + "\n\n" + q.Body + "\n");
                int ansId;
                if (q.Header == "MCQ question")
                {
                    for (int i = 0; i < q.Answers.Length; i++)
                    {
                        Console.WriteLine($"{i + 1})" + q.Answers[i].AnswerText);
                    }
                    do
                    {
                        Console.WriteLine("choose your answer id: ");
                    } while (!int.TryParse(Console.ReadLine(), out ansId) || !(ansId >= 1 && ansId <= 3));
                }
                else
                {
                    do
                    {
                        Console.WriteLine("choose your answer id: (1 for true | 2 for false)");
                    } while (!int.TryParse(Console.ReadLine(), out ansId) || !(ansId == 1 || ansId == 2));
                }
                if (ansId == q.CorrectAnswer.AnswerId) totalGrades += q.Mark;
                examGrades += q.Mark;
                ansArr[num - 2] = ansId;
                Console.Clear();
            }
            Console.WriteLine("---------------Final Exam---------------\n\n");
            DateTime end = DateTime.Now;
            num = 1;
            Console.WriteLine($"Total Grades: {totalGrades} of {examGrades}\nExam Time: {Time}, Time Taken: {(end - start)}\n");
            foreach (Question q in finQues)
            {
                Console.WriteLine(num++ + ")" + q.Header + "           " + "marks: " + q.Mark + "\n\n" + q.Body);
                int ansId;
                if (q.Header == "MCQ question")
                {
                    for (int i = 0; i < q.Answers.Length; i++)
                    {
                        Console.WriteLine($"{i + 1})" + q.Answers[i].AnswerText);
                    }
                    Console.WriteLine($"\n your answer: {ansArr[num - 2]}\n correct answer: {q.CorrectAnswer.AnswerId}\n");
                }
                else
                {
                    if (ansArr[num - 2] == 1) Console.WriteLine("\n your answer: true");
                    else Console.WriteLine("\n your answer: false");
                    if (q.CorrectAnswer.AnswerId == 1)
                        Console.WriteLine($" correct answer: true\n");
                    else Console.WriteLine($" correct answer: false\n");
                }
            }
        }
    }
}
