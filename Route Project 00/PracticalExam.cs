
namespace Route_Project_00
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberOfQuestions) : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam(List<Question> pracQues)
        {
            char c;
            do
            {
                Console.WriteLine("Do you want to start exam? (Y|N)");
                char.TryParse(Console.ReadLine(), out c);
            } while (c != 'Y');
            Console.Clear();
            DateTime start = DateTime.Now;
            int num = 1;
            int[] ansArr = new int[NumberOfQuestions];

            foreach (Question q in pracQues)
            {
                Console.WriteLine("---------------Practical Exam---------------\n\n");
                Console.WriteLine($"Time: {Time}min");
                Console.WriteLine(num++ + ")" + q.Header + "           " + "marks: " + q.Mark + "\n\n" + q.Body + "\n");
                int ansId;
                for (int i = 0; i < q.Answers.Length; i++)
                {
                    Console.WriteLine($"{i + 1})" + q.Answers[i].AnswerText);
                }
                do
                {
                    Console.WriteLine("choose your answer id: ");
                } while (!int.TryParse(Console.ReadLine(), out ansId) || !(ansId >= 1 && ansId <= 3));
                ansArr[num - 2] = ansId;
                Console.Clear();
            }
            Console.WriteLine("---------------Practical Exam---------------\n\n");
            DateTime end = DateTime.Now;
            num = 1;
            Console.WriteLine($"Exam Time: {Time}, Time Taken: {(end - start)}\n");
            foreach (Question q in pracQues)
            {
                Console.WriteLine(num++ + ")" + q.Header + "           " + "marks: " + q.Mark + "\n\n" + q.Body);
                for (int i = 0; i < q.Answers.Length; i++)
                {
                    Console.WriteLine($"{i + 1})" + q.Answers[i].AnswerText);
                }
                Console.WriteLine($"\n your answer: {ansArr[num - 2]}\n correct answer: {q.CorrectAnswer.AnswerId}\n");
            }
        }
    }
}
