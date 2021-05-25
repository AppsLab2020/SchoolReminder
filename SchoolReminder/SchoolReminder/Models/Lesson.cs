using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolReminder.Models
{
    class Lesson
    {
        public string Zaciatok { get; set; }
        public string Koniec { get; set; }

        public Lesson(string zaciatok, string koniec)
        {
            Zaciatok = zaciatok;
            Koniec = koniec;
        }
        public Lesson()
        {
            Zaciatok = "-1";
            Koniec = "-1";
        }
        public override string ToString()
        {
            return $"\nMeno:{Zaciatok}\nUcitel:{Koniec}";
        }
    }
}
