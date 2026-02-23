using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Xml.Serialization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1, "Petras Petrauskas", "p.petrauskas@gmail.com", 8.5F);

            Student student2 = new Student(2, "Jonas Jonauskis", "j.jonauskis@gmail.com", 7.7F);

            Student student3 = new Student(3, "Linas Linauskas", "Linas Linauskas", 9.9F);

            Group group = new Group("PS-5");

            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);

            ChooseAction(group);
        }

        public static void ChooseAction(Group group)
        {
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
                    WriteToConsole(group, foundStud);
                }
                else
                {
                    WriteError("ID");
                }
            }

            else if (choice == 2)
            {
                Console.WriteLine("Įrašykite mokinio el. pašto adresą");
                string email = Console.ReadLine().ToLower();
                Student foundStud = group.FindByEmail(email);
                if (foundStud != null)
                {
                    WriteToConsole(group, foundStud);
                }
                else
                {
                    WriteError("el. pašto adresu");
                }
            }

            else
            {
                Console.WriteLine("Blogas pasirinkimas");
            }
        }

        public static void WriteToConsole(Group group, Student foundStud)
        {
            Console.WriteLine($"Studentas rastas. " +
                        $"Grupės pavadinimas: {group.Pavadinimas} ID: {foundStud.Id} Vardas: {foundStud.Vardas} " +
                        $"El pašto adresas:{foundStud.ElPastas} Vidurkis: {foundStud.Vidurkis}");
        }

        public static void WriteError(string error)
        {
            Console.WriteLine($"Mokinys su tokiu {error} nerastas!");
        }
    }

}

public class Student
{
    public int Id { get;}
    public string Vardas { get;}
    public string ElPastas { get;}
    public float Vidurkis { get; }

    public Student(int id, string vardas, string elPastas, float vidurkis)
    {
        Id = id;
        Vardas = vardas;
        ElPastas = elPastas;
        Vidurkis = vidurkis;
    }
}

public class Group
{
    public string Pavadinimas { get;}
    private List<Student> Students = new List<Student>();

    public Group(string pavadinimas) 
    {
        Pavadinimas = pavadinimas;
    }

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