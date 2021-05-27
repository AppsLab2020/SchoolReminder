using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolReminder.Models
{
    class Den
    {
        public string Name;
        private List<Lesson> lessons;


        public Den(string name)
        {
            Name = name;
            lessons = new List<Lesson>();
        }
        public override string ToString()
        {
            string s;
            s = Name;

            foreach (var lesson in lessons)
            {
                s += lesson.ToString() + "\n";
            }
            return s;
        }
    }
}
