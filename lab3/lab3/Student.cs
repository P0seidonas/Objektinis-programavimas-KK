using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Student 
    { 
        public int Id { get; } 
        public string Vardas { get; } 
        public string ElPastas { get; } 
        public float Vidurkis { get; } 
        public Student(int id, string vardas, string elPastas, float vidurkis) 
        { 
            Id = id; Vardas = vardas; ElPastas = elPastas; Vidurkis = vidurkis; 
        } 
    }
}
