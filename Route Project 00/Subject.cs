namespace Route_Project_00
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public Exam ExamObject { get; set; }
        public void CreateExam()
        {
            int Etype, time, numOfQues;
            do
            {
                Console.WriteLine("Please enter the type for exam: (1 for practical | 2 for final)");
            } while (!int.TryParse(Console.ReadLine(), out Etype) || (Etype != 1 && Etype != 2));
            do
            {
                Console.WriteLine("Please enter time for exam: (30 min to 180 min)");
            } while (!int.TryParse(Console.ReadLine(), out time) || !(time >= 30 && time <= 180));
            do
            {
                Console.WriteLine("Please enter number of questions: ");
            } while (!int.TryParse(Console.ReadLine(), out numOfQues) || numOfQues == 0);
            Console.Clear();

            if (Etype == 1)
            {
                ExamObject = new PracticalExam(time, numOfQues);
                List<Question> finQuestions = new List<Question>();
                for (int i = 0; i < numOfQues; i++)
                {
                    MCQ mcq = new MCQ();
                    mcq.Header = "MCQ question";
                    Console.WriteLine(mcq.Header);
                    do
                    {
                        Console.WriteLine("Please enter the Body: ");
                        mcq.Body = Console.ReadLine();
                    } while (string.IsNullOrEmpty(mcq.Body));
                    int mrk;
                    do
                    {
                        Console.WriteLine("Please enter the Mark: ");
                    } while (!int.TryParse(Console.ReadLine(), out mrk) || mrk == 0);
                    mcq.Mark = mrk;
                    Console.WriteLine("Choices of Question");
                    for (int j = 0; j < 3; j++)
                    {
                        do
                        {
                            Console.WriteLine($"Please enter choice number {j + 1}: ");
                            mcq.Answers[j].AnswerText = Console.ReadLine();
                        } while (string.IsNullOrEmpty(mcq.Answers[j].AnswerText));
                    }
                    int rightAnswer;
                    do
                    {
                        Console.WriteLine("Please enter the right answer: ");
                    } while (!int.TryParse(Console.ReadLine(), out rightAnswer) || !(rightAnswer >= 1 && rightAnswer <= 3));
                    mcq.CorrectAnswer.AnswerId = rightAnswer;
                    finQuestions.Add(mcq);
                    Console.Clear();
                }
                ExamObject.ShowExam(finQuestions);
            }
            else if (Etype == 2)
            {
                ExamObject = new FinalExam(time, numOfQues);
                List<Question> finQuestions = new List<Question>();
                for (int i = 0; i < numOfQues; i++)
                {
                    int Qtype;
                    do
                    {
                        Console.WriteLine("Plesae enter type for question:  (1 for MCQ | 2 for TrueOrFalse)");
                    } while (!int.TryParse(Console.ReadLine(), out Qtype) || (Qtype != 1 && Qtype != 2));
                    Console.Clear();
                    if (Qtype == 1)
                    {
                        MCQ mcq = new MCQ();
                        mcq.Header = "MCQ question";
                        Console.WriteLine(mcq.Header);
                        do
                        {
                            Console.WriteLine("Please enter the Body: ");
                            mcq.Body = Console.ReadLine();
                        } while (string.IsNullOrEmpty(mcq.Body));
                        int mrk;
                        do
                        {
                            Console.WriteLine("Please enter the Mark: ");
                        } while (!int.TryParse(Console.ReadLine(), out mrk) || mrk == 0);
                        mcq.Mark = mrk;
                        Console.WriteLine("Choices of Question");
                        for (int j = 0; j < 3; j++)
                        {
                            do
                            {
                                Console.WriteLine($"Please enter choice number {j + 1}: ");
                                mcq.Answers[j].AnswerText = Console.ReadLine();
                            } while (string.IsNullOrEmpty(mcq.Answers[j].AnswerText));
                        }
                        int rightAnswer;
                        do
                        {
                            Console.WriteLine("Please enter the right answer: ");
                        } while (!int.TryParse(Console.ReadLine(), out rightAnswer) || !(rightAnswer >= 1 && rightAnswer <= 3));
                        mcq.CorrectAnswer.AnswerId = rightAnswer;
                        finQuestions.Add(mcq);
                        Console.Clear();
                    }
                    else if (Qtype == 2)
                    {
                        TrueOrFalse tORf = new TrueOrFalse();
                        tORf.Header = "True OR False question";
                        Console.WriteLine(tORf.Header);
                        do
                        {
                            Console.WriteLine("Please enter the Body: ");
                            tORf.Body = Console.ReadLine();
                        } while (string.IsNullOrEmpty(tORf.Body));
                        int mrk;
                        do
                        {
                            Console.WriteLine("Please enter the Mark: ");
                        } while (!int.TryParse(Console.ReadLine(), out mrk) || mrk == 0);
                        tORf.Mark = mrk;
                        int rightAnswer;
                        do
                        {
                            Console.WriteLine("Please enter the right answer: (1 for true | 2 for false)");
                        } while (!int.TryParse(Console.ReadLine(), out rightAnswer) || !(rightAnswer == 1 || rightAnswer == 2));
                        tORf.CorrectAnswer.AnswerId = rightAnswer;
                        finQuestions.Add(tORf);
                        Console.Clear();
                    }
                }
                ExamObject.ShowExam(finQuestions);
            }
        }
    }
}
