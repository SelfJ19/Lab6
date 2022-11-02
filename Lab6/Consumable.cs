using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Consumable : Item
    {
        private int HealthEffect { get; set; }
        private int DosesRemaining { get; set; }

        public Consumable(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
            HealthEffect = 0;
            DosesRemaining = 0;
        }
    }
}
