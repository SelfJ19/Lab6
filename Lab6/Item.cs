using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Item
    {
        #region Attributes
        protected string Name { get; set; }
        protected string Description { get; set; }
        protected double Weight { get; set; }
        protected double Value { get; set; }
        #endregion

        #region Parameterized()
        public Item(string name, string desrciption, double weight, double value)
        {
            Name = name;
            Description = desrciption;
            Weight = weight;
            Value = value;
        }
        #endregion

        #region ToString()
        public override string ToString()
        {
            string info = "";

            info += $"Item name: {Name}";
            info += $"\n Description: {Description}";
            info += $"\n Weight: {Weight} pounds";
            info += $"\n Value: {Value} gold pieces";

            return info;
        }
        #endregion
    }
}
