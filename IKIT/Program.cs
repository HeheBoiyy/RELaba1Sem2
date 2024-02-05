using Department;

namespace IKIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProgrammerEngineer first = new ProgrammerEngineer()
            {
                FIO = "Darya Griko",
                ProgrammingLanguage = "GO"
            };
            ProgrammerEngineer second = new ProgrammerEngineer()
            {
                FIO = "David Darbinyan",
                ProgrammingLanguage = "C#"
            };
            ProgrammerEngineer third = new ProgrammerEngineer()
            {
                FIO = "Екатерина Мурашко",
                ProgrammingLanguage = "JavaScript"
            };
            ClassDepartment<ProgrammerEngineer> aboba = new ClassDepartment<ProgrammerEngineer>()
            {
                Name = "ProgrammerEngineer",
                Supervisor = "David Darbinyan"
            };
            aboba.EnrollStudent(first);
            aboba.EnrollStudent(second);
            aboba.EnrollStudent(third);

            Console.WriteLine("Студенты добавлены в массив! \n");
            foreach (ProgrammerEngineer ProgrammerEngineer in aboba.list)
            {
                Console.WriteLine(ProgrammerEngineer.ToString());
            }
            aboba.DeleteStudent(third);
            Console.WriteLine("\nУдалён студент Екатерина \n");
            foreach (ProgrammerEngineer ProgrammerEngineer in aboba.list)
            {
                Console.WriteLine(ProgrammerEngineer.ToString());
            }
        }
    }
}
