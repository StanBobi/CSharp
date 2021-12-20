using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3_L2_combination
{
    class JucatorClass
    {
        private string nume;
        private string cnp;
        private Post post;

       public JucatorClass(string nume, string CNP, Post post)
        {
            this.nume = nume;
            this.cnp = CNP;
            this.post = post;
        }

        [Description("Numele jucatorului"), Category("Date personale")]
        public string Nume 
        { 
            get { return nume; }
        }

        [Description("Postul pe care joaca"), Category("Cariera")]
        public Post Post
        {
            get { return post; }
            set { post = value; }
        }

        [Description("CNP"), Category("Date personale")]
        public string CNP
        {
            get { return cnp; }
            set { cnp = value; }
        }


        [Description("Data nasterii"), Category("Date personale")]
        public DateTime DataNasterii
        {
            get
            {
                int zi;
                int luna;
                int an;

                try
                {
                    zi = int.Parse(CNP.Substring(5, 2));
                    luna = int.Parse(CNP.Substring(3, 2));

                    if (CNP.Substring(0, 1) == "5" || CNP.Substring(0, 1) == "6") an = 2000 + int.Parse(CNP.Substring(1, 2));
                    else if (CNP.Substring(0, 1) == "3" || CNP.Substring(0, 1) == "4") an = 1800 + int.Parse(CNP.Substring(1, 2));
                    else if (CNP.Substring(0, 1) == "1" || CNP.Substring(0, 1) == "2") an = 1900 + int.Parse(CNP.Substring(1, 2));
                    else throw new Exception();

                }
                catch (Exception)
                {
                    an = 2000;
                    luna = 1;
                    zi = 1;
                }

                return new DateTime(an, luna, zi);
            }
            set { DataNasterii = value; }
        }

        [Description("Varsta"), Category("Cariera")]
        public int Varsta
        {
            get { return new DateTime(DateTime.Now.Subtract(DataNasterii).Ticks).Year - 1; }
        }

    }
}
