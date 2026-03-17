using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Group 
    { 
        public string Pavadinimas { get; } 
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
            foreach (Student student in Students) 
            { 
                if (student.Id == id) 
                { 
                    return student; 
                } 
            } return null; 
        } 
        public Student FindByEmail(string email) 
        { 
            foreach (Student student in Students) 
            { 
                if (student.ElPastas == email) 
                { 
                    return student; 
                } 
            } 
            return null; 
        } 
    }
}
