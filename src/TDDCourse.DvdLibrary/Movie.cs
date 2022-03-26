using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCourse.DvdLibrary
{
    public class Movie
    {
        public double Copies { get; private set; }

        public void AddCopy()
        {
            Copies++;
        }
    }
}
