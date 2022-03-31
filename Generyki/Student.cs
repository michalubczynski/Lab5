using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generyki
{
    public class Student
    {
        public string Nazwisko { get; set; }
        public double Ocena { get; set; }
        public Student(string nazwisko, double ocena)
        {
            Nazwisko = nazwisko;
            Ocena = ocena;
        }
        public Student() { }
        public override string ToString()
        {
            return Nazwisko+", Twoja ocena:"+Ocena;
        }
    }
}
