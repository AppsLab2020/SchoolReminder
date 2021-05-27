using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolReminder.Models
{
    class Subject
    {
        public string Meno { get; set; }
        public string Ucitel { get; set; }
        public string Trieda { get; set; }


        public Subject(string meno, string ucitel, string trieda)
        {
            Meno = meno;
            Ucitel = ucitel;
            Trieda = trieda;
        }
        public Subject()
        {
            Meno = "-1";
            Ucitel = "-1";
            Trieda = "-1";
        }
        public override string ToString()
        {
            return $"\nMeno:{Meno}\nUcitel:{Ucitel}\nTrieda:{Trieda}";
        }
    }
}