using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.ChangeMark(1, 0, 0);
            st.Info();
            st.get_GPA(1);
        }
    }
}
