namespace LabTask15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new("Veli", "Ismaylov", "Fakul", new int[] {1, 50, 49, 35, 44});
            Student student2 = new("Pirveli", "Ismaylov", "Fakul2", new int[] {49, 11, 23, 16, 44});
            Student student3 = new("Eli", "Ismaylov", "Fakul3", new int[] {23, 17, 32, 46,50});

            Exam exams1 = new(new string[] {"Fen1", "Fen2", "Fen3", "Fen4", "Fen5"}, new int[] {23, 35, 44, 50, 15});
            Exam exams2 = new(new string[] { "Fen1", "Fen2", "Fen3", "Fen4", "Fen5" }, new int[] { 40, 25, 34, 10, 25 });
            Exam exams3 = new(new string[] { "Fen1", "Fen2", "Fen3", "Fen4", "Fen5" }, new int[] { 26, 37, 43, 50, 45 });

            Exam[] exams = new Exam[] {exams1, exams2, exams3};
            Student[] students = new Student[] { student1, student2, student3 };
            
            for (int i = 0; i < 3; i++)
            {
                students[i].CheckExam(exams[i].ImtahanBali, exams[i].ImtahanAdi);
                students[i].StudentInfo();

                Console.WriteLine("\n");
            }
        }
    }
}
