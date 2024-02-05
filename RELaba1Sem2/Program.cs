using Department;
using System.Xml.Serialization;

namespace FKSIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Physical first = new Physical()
            {
                Fio = "Darya Griko",
                SportDiscipline = "Hokkei"
            };
            Physical second = new Physical()
            {
                Fio = "David Darbinyan",
                SportDiscipline = "Football"
            };
            Physical third = new Physical()
            {
                Fio = "Egor Zhukov",
                SportDiscipline = "Volleyboll"
            };
            ClassDepartment<Physical> aboba = new ClassDepartment<Physical>()
            {
                Name = "Physical",
                Supervisor = "David Darbinyan"
            };
            aboba.EnrollStudent(first);
            aboba.EnrollStudent(second);
            aboba.EnrollStudent(third);
            Console.WriteLine("Студенты добавлены в массив! \n");
            foreach (Physical physical in aboba.list) 
            {
                Console.WriteLine(physical.ToString());
            }
            aboba.DeleteStudent(second);
            Console.WriteLine("\nУдалён студент Давид \n");
            foreach (Physical physical in aboba.list)
            {
                Console.WriteLine(physical.ToString());
            }
        }
    }
}
