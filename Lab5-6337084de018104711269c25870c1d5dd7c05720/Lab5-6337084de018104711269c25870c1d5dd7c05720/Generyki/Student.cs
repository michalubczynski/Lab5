using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generyki
{
    public class Student: IComparable
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

        public int CompareTo(Object oth)
        {
            Student other = oth as Student;
            if (this.Nazwisko[0] > other.Nazwisko[0]) return 1;
            else if (this.Nazwisko[0] < other.Nazwisko[0]) return -1;
            else { return 0; }
        }
    }
    public static class KlasaStatyczna 
    {
        public static T ZnajdzWiekszy<T> (T param1, T param2) where T:IComparable
        {
            if (param2.CompareTo(param1) > 0) return param2; else return param1;
        }


    }
    public class Regal<T> {


        public Regal() { 
        Polka1 = default(T);
        Polka2 = default(T);
        Polka3 = default(T); 
        }
        public T Polka1 { get; set; }
        public T Polka2 { get; set; }
        public T Polka3 { get; set; }
        public void WstawNaWolnaPolke(T rzecz) {
            if (object.Equals(Polka1, default(T)))
            {
                Polka1 = rzecz;
            }
            else {
                if (object.Equals(Polka2, default(T)))
                {

                    Polka2 = rzecz;
                }
                else {
                    if (object.Equals(Polka1, default(T))) { 
                    Polka3 = rzecz;
                    }
                }
                
            }
        }
        public override string ToString()
        {
            return "Pierwsza:"+Polka1.ToString()+"\nDruga:"+Polka2.ToString()+"\nTrzecia:"+Polka3.ToString();
        }
    }
}
