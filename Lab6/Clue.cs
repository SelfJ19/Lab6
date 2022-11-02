using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Clue : Item
    {
        private string PersonInciminated { get; set; }
        private bool Accuracy { get; set; }

        public Clue(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
            PersonInciminated = "";
            Accuracy = false;
        }

        public override string ToString()
        {
            string info = base.ToString();
            
            return info;
        }
    }
}
