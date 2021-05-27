using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolReminder.Models
{
    class Lesson
    {
        public TimeSpan Zaciatok { get; set; }
        public TimeSpan Koniec { get; set; }
        ///priradit predmet///

        public Lesson(TimeSpan zaciatok, TimeSpan koniec)
        {
            Zaciatok = zaciatok;
            Koniec = koniec;

        }
    
        public override string ToString()
        {
            return $"\nMeno:{Zaciatok}\nUcitel:{Koniec}";
        }
    }
}
