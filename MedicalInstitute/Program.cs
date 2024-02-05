using Department;
namespace MedicalInstitute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medical first = new Medical()
            {
                Name = "Darya Griko",
                Specialization = "Нейрохирург"
            };
            Medical second = new Medical()
            {
                Name = "David Darbinyan",
                Specialization = "Кардиохирург"
            };
            Medical third = new Medical()
            {
                Name = "Egor Zhukov",
                Specialization = "Уролог"
            };
            ClassDepartment<Medical> aboba = new ClassDepartment<Medical>()
            {
                Name = "Medical",
                Supervisor = "David Darbinyan"
            };
            aboba.EnrollStudent(first);
            aboba.EnrollStudent(second);
            aboba.EnrollStudent(third);

            Console.WriteLine("Студенты добавлены в массив! \n");
            foreach (Medical Medical in aboba.list)
            {
                Console.WriteLine(Medical.ToString());
            }
            aboba.DeleteStudent(first);
            Console.WriteLine("\nУдалён студент Дарья \n");
            foreach (Medical Medical in aboba.list)
            {
                Console.WriteLine(Medical.ToString());
            }
        }
    }
}
