namespace Route_Project_00
{
    internal class MCQ : Question
    {
        public MCQ()
        {
            Answers = new Answer[3];
            for (int i = 0; i < Answers.Length; i++)
            {
                Answers[i] = new Answer();
            }

        }
    }
}
