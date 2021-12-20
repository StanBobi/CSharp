using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratul1_remaster_
{
    class ComparaNume:IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return string.Compare(x.NumeStudent, y.NumeStudent);
        }
    }
}
