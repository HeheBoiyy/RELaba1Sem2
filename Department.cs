using System;
namespace Department 
{ 
	public interface IDepartment<T>
	{
		string Name { get; set; }
		string Supervisor { get; set; }
		void EnrollStudent(T student);
		void ExpellStudent(T student);
		List<T> ListofStudents;
	}
	public class Department<T> : IDepartment <T>
	{
		public string Name { get; set; }
		public string Supervisor { get; set; }
		public void EnrollStudent(T student)
		{
			list.Add(student);
		}
		public void ExpellStudet(T student)
		{
			list.Remove(student);
		}
		public List<T> list {  get; set; }
	}
}