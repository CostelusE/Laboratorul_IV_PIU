using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Agenda
    {
        //constate

        private const int aceeasi_varsta = 0;
        private const int mai_mare_prima = 1;
        private const int mai_mare_a_doua= -1;

        //date membre private

        private string nume;
        private string prenume;
        private string nr_telefon;
        private string adresa_email;
        private string data_nastere;

        //proprietati auto-implemented

        public string NumeComplet
        {
            get
            {
                return nume + " " + prenume;
            }
        }
       

        //Constructor implicit

        public Agenda()
        {
            nume = string.Empty;
            prenume = string.Empty;
            adresa_email = string.Empty;
            data_nastere = string.Empty;
            nr_telefon = string.Empty;
           
        }

        //Constructor cu parametri

        public Agenda(string _nume,string _prenume,string _data_nastere,string _nr_telefon, string _adresa_email)
        {
            nume = _nume;
            prenume = _prenume;
            adresa_email = _adresa_email;
            data_nastere = _data_nastere;
            nr_telefon = _nr_telefon;
           
         
        }

        //Constructor cu parametru de tip string

        public Agenda(string sir)
        {
            string[] buf = sir.Split(' ');
            nume = buf[0];
            prenume = buf[1];
            data_nastere = buf[2];
            nr_telefon = buf[3];
            adresa_email = buf[4];
        }

       //Compararea varstei a doua persoane din agenda

         public int ComparareVarsta(Agenda b)
        {
            string []sir2 = data_nastere.Split('.');
            string []sir1 = b.data_nastere.Split('.');
            int []s1 = new int[3];
            int []s2 = new int[3];
            for (int i=0;i<3;i++)
            {
                s2[i] = Convert.ToInt32(sir2[i]);
                s1[i] = Convert.ToInt32(sir1[i]);
   
            }
            if (s1[2] == s2[2])
                    if (s1[1] == s2[1])
                           if (s1[0] == s2[0])
                                   return aceeasi_varsta;
                           else if (s1[0] < s2[0])
                                   return mai_mare_a_doua;
                           else
                                   return mai_mare_prima;

                    else if (s1[1] < s2[1])
                           return mai_mare_a_doua;
                    else
                           return mai_mare_prima;

            else if (s1[2] < s2[2])
                return mai_mare_a_doua; 
            else
                return mai_mare_prima;

        }
       
            //Afisare date 

            public string ConversieLaSir()
        {
            return String.Format("{0,-12}{1,8}{2,20}{3,21}{4,29}", nume,prenume,data_nastere,nr_telefon, adresa_email);
        }
    }
   

}
