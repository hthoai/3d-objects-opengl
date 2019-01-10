using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Vertex
    {
        public double x, y, z;

        public Vertex()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public Vertex(double a, double _length, double c)
        {
            x = a;
            y = _length;
            z = c;
        }
        public Vertex(Vertex A)
        {
            x = A.x;
            y = A.y;
            z = A.z;
        }
        ~Vertex()
        {
        }
    }
}
