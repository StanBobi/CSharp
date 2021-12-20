using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratul1_remaster_
{
    class Student:Persoana
    {
        private byte an;
        private byte[] note = new byte[5];

       public Student() { }
        public Student(string nume, byte varsta, byte an, byte []note):base(nume, varsta)
        {
            this.an = an;
            this.note = note;
        }   

        public byte AnStudiu { get { return an; } }
        public string NumeStudent { get { return nume; } }

        public float Medie()
        {
            float suma = 0;

           foreach(byte n in note)
            {
                suma += n;
            }
            return suma / note.Length;
        }

        public string AfisareStudent()
        {
            return nume + " " + varsta + " ani " + an + " media: " + Medie(); 
        }

    }
}
