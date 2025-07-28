namespace Route_Project_00
{
    class program
    {
        static void Main(string[] args)
        {
            Subject s = new Subject();
            int id; string name;
            do
            {
                Console.Write("Enter id of subject: ");
            } while (!int.TryParse(Console.ReadLine(), out id));
            s.SubjectId = id;
            do
            {
                Console.Write("Enter name of subject: ");
                name = Console.ReadLine();
            } while (string.IsNullOrEmpty(name));
            s.SubjectName = name;
            Console.Clear();
            s.CreateExam();

        }
    }
}
