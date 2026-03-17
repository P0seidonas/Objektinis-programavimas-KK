using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class StudentService
    {
        private readonly IAverageStrategy _averageStrategy;

        public StudentService(IAverageStrategy averageStrategy)
        {
            _averageStrategy = averageStrategy;
        }

        public float GetAverage(Student student)
        {
            return _averageStrategy.Calculate(student);
        }
    }
}
