using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            var afis_agenda = string.Format("{0,60}","AGENDA");
            Console.WriteLine(afis_agenda);
            Console.ReadKey();
            const int max = 100;
            Agenda[] agenda = new Agenda[max];
            int contor = 0;
            Console.ForegroundColor = ConsoleColor.White;
            string optiune;
            do
            {
                Console.Clear();
                Console.WriteLine("A. Adaugare persoane in agenda prin intermediul constructorilor");
                Console.WriteLine("T. Adaugare persoane in agenda prin intermediul citirii de la tastatura");
                Console.WriteLine("P. Afisare persoane din agenda");
                Console.WriteLine("C. Comparare a 2 persoane din agenda dupa varsta");
                Console.WriteLine("X. Iesire program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "A":
                        var persoana1 = new Agenda("Popescu", "Ioan", "23.6.1989", "0752024987", "popescuion@yahoo.com");
                        agenda[contor++] = persoana1;
                        var persoana2 = new Agenda("Ionescu Radu 8.12.1992 075898782 radu_ionescu@gmail.com");
                        agenda[contor++] = persoana2;
                        var persoana3 = new Agenda("Rusu Lacramioara 19.10.2003 2345678091 lacryrusu@student.usv.ro");
                        agenda[contor++] = persoana3;
                        Console.ReadKey();
                        break;
                    case "T":
                        Console.WriteLine("Introdu numele persoanei pe care vrei sa o adaugi in agenda:");
                        string _nume = Console.ReadLine();
                        Console.WriteLine("Introdu prenumele persoanei pe care vrei sa o adaugi in agenda:");
                        string _prenume = Console.ReadLine();
                        Console.WriteLine("Introdu data nasterii a persoanei pe care vrei sa o adaugi in agenda:");
                        string _data_nastere = Console.ReadLine();
                        Console.WriteLine("Introdu numarul de telefon al persoanei pe care vrei sa o adaugi in agenda:");
                        string _nr_telefon = Console.ReadLine();
                        Console.WriteLine("Introdu adresa de email a persoanei pe care vrei sa o adaugi in agenda:");
                        string _adresa_email = Console.ReadLine();
                        var persoana4 = new Agenda(_nume, _prenume, _data_nastere, _nr_telefon, _adresa_email);
                        agenda[contor++] = persoana4;
                        Console.ReadKey();
                        break;
                    case "P":
                        var header = String.Format("{0,-12}{1,8}{2,20}{3,21}{4,29}\n",
                             "Nume", "Prenume", "Data de nastere", "Numar de telefon", "Adresa de email");
                        Console.WriteLine(header);
                        for (int i = 0; i < contor; i++)
                            Console.WriteLine(agenda[i].ConversieLaSir());
                        Console.ReadKey();
                        break;
                    case "C":
                        Console.WriteLine("Alegeti 2 persoane din agenda pe care doriti sa le comparati");
                        for (int j = 0; j < contor; j++)
                            Console.WriteLine("{0}.{1}", j+1, agenda[j].NumeComplet);
                        Console.WriteLine("Alegeti indexul primei persoana pe care doriti sa o comparati");
                        int pers1 = Convert.ToInt32(Console.ReadLine());
                        while(pers1 > contor)
                        {
                            Console.WriteLine("Indexul persoanei selectate nu se afla in agenda\nSelectati alt index care se gaseste in agenda:");
                             pers1 = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Alegeti indexul celei de-a doua persoane pe care doriti sa o comparati");
                        int pers2 = Convert.ToInt32(Console.ReadLine());
                        while (pers2 > contor)
                        {
                            Console.WriteLine("Indexul persoanei selectate nu se afla in agenda\nSelectati alt index care se gaseste in agenda:");
                            pers2 = Convert.ToInt32(Console.ReadLine());
                        }
                        if (agenda[pers1 - 1].ComparareVarsta(agenda[pers2 - 1]) == 0)
                            Console.WriteLine("{0} si {1} au aceeasi varsta", agenda[pers1 - 1].NumeComplet, agenda[pers2 - 1].NumeComplet);
                        else if (agenda[pers1 - 1].ComparareVarsta(agenda[pers2 - 1]) == 1)
                            Console.WriteLine("{0} este mai mare decat {1} ", agenda[pers1 - 1].NumeComplet, agenda[pers2 - 1].NumeComplet);
                        else
                            Console.WriteLine("{0} este mai mare decat {1} ", agenda[pers2 - 1].NumeComplet, agenda[pers1 - 1].NumeComplet);
                        Console.ReadKey();
                        break;

                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }
    }
}
