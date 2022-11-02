using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Backpack
    {
        private List<Item> Contents { get; set; }

        public Backpack()
        {
            Contents = new List<Item>();
        }
        public void Add(Item item)
        {
            Contents.Add(item);
        }

        public string ListWeapons()
        {
            string info = "\nWeapons -------------------------------";
            foreach (Item item in Contents)
            {
                if (item is Weapon)
                {
                    info += $"\n{item}";
                    info += "\n-----------------------------------";
                }
            }
            return info;
        }

        public string ListClues()
        {
            string info = "\nClues -------------------------------";
            foreach(Item item in Contents)
            {
                if(item is Clue)
                {
                    info += $"\n{item}";
                    info += "\n-----------------------------------";
                }
            }
            return info;
        }

        public string ListConsumables()
        {
            string info = "\nConsumables -------------------------------";
            foreach (Item item in Contents)
            {
                if (item is Consumable)
                {
                    info += $"\n{item}";
                    info += "\n-----------------------------------";
                }
            }
            return info;
        }
    }
}
