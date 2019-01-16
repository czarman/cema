﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadFromFIle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        OpenFileDialog ofd = new OpenFileDialog();

        private void PlikOsobowy_Click(object sender, EventArgs e)
        {
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
            Variables.finanseFilePath = FinanseFilePath.Text;
            Variables.personFilePath = PersonFilePath.Text;
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
