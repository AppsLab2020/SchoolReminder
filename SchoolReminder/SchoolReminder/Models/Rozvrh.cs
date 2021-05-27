using System.Collections.Generic;

namespace SchoolReminder.Models
{
    public class Rozvrh
    {
        public string Name { get; }
        private List<Den> dni;

        public Rozvrh(string name)
        {
            Name = name;

            dni = new List<Den>
            {
                new Den("pondelok"),
                new Den("utorok"),
                new Den("streda"),
                new Den("stvrtok"),
                new Den("piatok")
            };
        }

        public override string ToString()
        {
            string s = Name;
            foreach (var den in dni)
            {
                s += den.ToString() + "\n";
            }

            return s;
        }
    }
}
