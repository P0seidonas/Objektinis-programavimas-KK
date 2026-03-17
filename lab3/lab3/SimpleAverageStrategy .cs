using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class SimpleAverageStrategy : IAverageStrategy
    {
        public float Calculate(Student student)
        {
            return student.Vidurkis;
        }
    }
}
