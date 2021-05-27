using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolReminder.Models
{
    public class Rozvrh
    {
        public string Name;
        private List<Den> dni;
        public Rozvrh(string name)
        {
            Name = name;

            dni = new List<Den>();

            dni.Add(new Den("pondelok"));
            dni.Add(new Den("utorok"));
            dni.Add(new Den("streda"));
            dni.Add(new Den("stvrtok"));
            dni.Add(new Den("piatok"));
        }

        public override string ToString()
        {
            string s;
            s = Name;

            foreach (var den in dni)
            {
                s += den.ToString() + "\n";
            }
            return s;
        }
    }
}
