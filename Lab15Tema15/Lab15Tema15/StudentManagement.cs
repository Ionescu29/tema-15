// See https://aka.ms/new-console-template for more information
using Linq;
using System.Net.Cache;
//Am creeat o metoda prin care se dauga studenti 

class StudentManagement
{
    private List<Student> students = new List<Student>();
    public void AddStudent(Student student)
    {
        students.Add(student);
    }
}
//Afisati cel mai in varsta student de la Informatica
public List<Student> GetAgeFromInformatics(Profile profile)
{
    var filtered=students
        .Where(e=>e.Profile==profile)
        .OrderBy(e => e.Age>24)
        return filtered;
}

//Afisati cel mai tanar student
public List<Student> YoungerStudents()
{
    var filtered = students
        .Where(e => e.Profile == Profile)
        .OrderBy(e => e.Age < 27)
        .ToList();
    return filtered;
}
//Afisati in ordine crescatoare a varstei toti, studentii de la litere.
public List<Student> YoungerStudents()
{
    var filtered = students
        .Where(e => e.Profile == Profile)
        .OrderThenBy(e => e.Age)
        .ToList();
        return filtered;
}



