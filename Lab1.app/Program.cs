using System;
using System.Collections.Specialized;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student
            {
                Id = 1,
                Vardas = "Petras Petrauskas",
                ElPastas = "p.petrauskas@gmail.com",
                Vidurkis = 8.5F
            };

            Student student2 = new Student
            {
                Id = 2,
                Vardas = "Jonas Jonauskis",
                ElPastas = "j.jonauskis@gmail.com",
                Vidurkis = 7.7F
            };

            Student student3 = new Student
            {
                Id = 3,
                Vardas = "Linas Linauskas",
                ElPastas = "l.linauskas@gmail.com",
                Vidurkis = 9.9F
            };

            Group group = new Group
            {
                Pavadinimas = "PS-5",

            };

            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);

            Console.WriteLine("Pagal ką norite ieškoti studento?");
            Console.WriteLine("Pagal ID įrašykite 1. Pagal email įrašykite 2.");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Įrašykite mokinio ID");
                int id = int.Parse(Console.ReadLine());
                Student foundStud = group.FindById(id);
                if (foundStud != null)
                {
                    Console.WriteLine($"Studentas rastas. " +
                        $"Grupės pavadinimas: {group.Pavadinimas} ID: {foundStud.Id} Vardas: {foundStud.Vardas} " +
                        $"El pašto adresas:{foundStud.ElPastas} Vidurkis: {foundStud.Vidurkis}");
                }
                else
                {
                    Console.WriteLine("Mokinys su tokiu ID nerastas!");
                }
            }

            else if (choice == 2)
            {
                Console.WriteLine("Įrašykite mokinio el. pašto adresą");
                string email = Console.ReadLine().ToLower();
                Student foundStud = group.FindByEmail(email);
                if (foundStud != null)
                {
                    Console.WriteLine($"Studentas rastas. Studento duomenys: " +
                        $"Grupės pavadinimas: {group.Pavadinimas} ID: {foundStud.Id} Vardas: {foundStud.Vardas} " +
                        $"El pašto adresas:{foundStud.ElPastas} Vidurkis: {foundStud.Vidurkis}");
                }
                else
                {
                    Console.WriteLine("Mokinys su tokiu el. pašto adresu nerastas!");
                }
            }

            else
            {
                Console.WriteLine("Blogas pasirinkimas");
            }
        }
    }
}

public class Student
{
    public int Id { get; set; }
    public string Vardas { get; set; }
    public string ElPastas { get; set; }
    public float Vidurkis { get; set; }
}

public class Group
{
    public string Pavadinimas { get; set; }
    private List<Student> Students = new List<Student>();

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
    public Student FindById(int id)
    {
        Student foundStudent = null;
        foreach (Student student in Students)
        {
            if (student.Id == id)
            {
                foundStudent = student;
                break;
            }
        }
        return foundStudent;
    }

    public Student FindByEmail(string email)
    {
        Student foundStudent = null;

        foreach (Student student in Students)
        {
            if (student.ElPastas == email)
            {
                foundStudent = student;
                break;
            }
        }

        return foundStudent;
    }
}