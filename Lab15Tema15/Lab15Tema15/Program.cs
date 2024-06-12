// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Un student este caracterizat de
• Id (unic)
• Nume
• Prenume
• Varsta
• Specializare*/

var ms = new StudentManagement();
ms.AddStudent(new Student { Id=Guid.NewGuid(), Name="Popescu", FirstName="Dorel", Age=20, Profile=Profile.Letters});
ms.AddStudent(new Student { Id = Guid.NewGuid(), Name = "Apetrii", FirstName = "Marian", Age = 27, Profile = Profile.Informatics });
ms.AddStudent(new Student { Id = Guid.NewGuid(), Name = "Filipciuc", FirstName = "Daniel", Age = 30, Profile = Profile.Building });
ms.AddStudent(new Student { Id = Guid.NewGuid(), Name = "Hrisca", FirstName = "Dorina", Age = 22, Profile = Profile.Letters });
ms.AddStudent(new Student { Id = Guid.NewGuid(), Name = "Pintilie", FirstName = "Gabriel", Age = 29, Profile = Profile.Informatics });
ms.AddStudent(new Student { Id = Guid.NewGuid(), Name = "Malis", FirstName = "George", Age = 24, Profile = Profile.Building });

class Student
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string FirstName { get; set; }
    public int Age { get; set; }
    public Profile Profile { get; set; }
}
