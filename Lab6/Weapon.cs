using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Weapon:Clue
    {
        private int Damage { get; set; }
        private DamageType DamageType { get; set; }

        public Weapon(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
            Damage = 0;
            DamageType = DamageType.Slashing;
        }
    }
}
