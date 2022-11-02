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

        public void Add(Item item)
        {
            Contents = new List<Item>();
            Contents.Add(item);
        }

        public string ListWeapons()
        {
            string info = "";
            for(int i = 0; i < Contents.Count; i++)
            {
                if(i is Weapon)
                {
                    info = base.ToString();
                    info += "-----------------------------------";
                }
            }
            return info;
        }

        public string ListClues()
        {
            string info = "";
            for(var i = 0; i < Contents.Count; i++)
            {
                if(Contents[i] is Clue)
                {
                    info = base.ToString();
                    info += "-----------------------------------";
                }
            }
            return info;
        }

        public string ListConsumables()
        {
            string info = "";
            for( int i = 0; i < Contents.Count; i++)
            {
                if(i is Consumable)
                {
                    info = base.ToString();
                    info += "-----------------------------------";
                }
            }  
            return info;
        }
    }
}
