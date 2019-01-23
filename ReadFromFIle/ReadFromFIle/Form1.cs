using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO To co w poprzednich zadaniach - czyli czysty kod, wydzielone klasy itp :)


namespace ReadFromFIle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //TODO OpenFileDialog jest klasą, którą trzeba zwolnić po skończeniu używania. Dobrą praktyką jest tworzenie w miejscu gdzie potrzebujesz jej użyć i opakowanie w using
        OpenFileDialog ofd = new OpenFileDialog();

        private void PlikOsobowy_Click(object sender, EventArgs e)
        {
            //TODO skoro uzywamy dialoga to dobrze byłoby dodać filter - żeby user mógł tylko plik tekstowy
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                PersonFilePath.Text = ofd.FileName;
            }

        }

        private void PlikFinansowy_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FinanseFilePath.Text = ofd.FileName;
            }

        }

        private void Start_Click(object sender, EventArgs e)
        {
            //TODO Staraj sie nie uzywac zmiennych/metod/klas statycznych - taki kod jest cieżko testowalny. W niektórych frameworkach tylko stosuje się statyczne rzeczy(np MSPEC) ale w pozostalych przypadkach to jest zły pomysł :)
            Variables.finanseFilePath = FinanseFilePath.Text;
            Variables.personFilePath = PersonFilePath.Text;
            //TODO Sprobuj wprowadzic klasę PersonData gdzie beda informacje o danych danej osoby i klase PersonDataReader - ktora ci takie info wypluje
            //TODO Bedzie to testowalne, czytelne itp :)
            string[] person = System.IO.File.ReadAllLines(Variables.personFilePath);
            int sizeOfArray = person.Length;
            string[] finanse = System.IO.File.ReadAllLines(Variables.finanseFilePath);
            string[] final = new string[sizeOfArray];
            int i =0;
            final[i] = "Imię, Nazwisko, Wynagrodzenie";
            
            foreach (string l in person)
            {
                
                
                
                
                foreach(string f in finanse)
                {
                

                if (f == "Pesel,Wynagrodzenie"|| l == "Imie,Nazwisko,Pesel")
                
                    { }
                    else
                    {
                        //TODO Ło panie - ja za stary jestem, żeby to zrozumieć:D Sprobuj przerobić na klasy tak jak wyżej proponowałem, powinno to wyglądać czytelniej.
                        //TODO Metoda string.Split może być pomocna
                        if (l.Substring(l.IndexOf(",", l.IndexOf(",") + 1) + 1, 11)==f.Substring(0,11))
                        {
                            i++;
                            final[i]= l.Substring(0,l.IndexOf(",", l.IndexOf(",") + 1) + 1) +" "+ f.Substring(12, f.Length-12);
                        }
                        
                    }
                
                }
                
            }
            
            foreach (string fin in final)
            {
                Output.Text = Output.Text + "\r\n" + fin;
            }

            
        }
    }
}
