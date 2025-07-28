namespace Route_Project_00
{
    internal class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] Answers { get; set; }
        public Answer CorrectAnswer { get; set; }
        public Question()
        {
            Header = string.Empty;
            Body = string.Empty;
            Answers = new Answer[0];
            CorrectAnswer = new Answer();
        }
    }
}
