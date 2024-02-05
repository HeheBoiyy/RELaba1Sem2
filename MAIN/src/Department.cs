using System;
using System.Xml.Linq;
namespace Department 
{ 
	public interface IDepartment<T>
	{
		string Name { get; set; }
		string Supervisor { get; set; }
		void EnrollStudent(T student);
		void DeleteStudent(T student);
		public T[] list { get; set; }
	}
	public class ClassDepartment<T> : IDepartment <T>
	{
		public string Name { get; set; }
		public string Supervisor { get; set; }
		public void EnrollStudent(T student)
		{
			T[] aboba = new T[1] {student};
			list = list.Concat(aboba).ToArray();
        }
		public void DeleteStudent(T student)
		{
            int index = Array.IndexOf(list, student);

            if (index >= 0)
            {
                
                for (int i = index; i < list.Length - 1; i++)
                {
                    list[i] = list[i + 1];
                }

				list[list.Length - 1] = default;
				list = list.Where(x=>x!=null).ToArray();
            }

        }
		public T[] list {get; set;} = new T[0];
	}
}