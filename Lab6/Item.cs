using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    /// <summary>
    /// creates the public class Item
    /// </summary>
    public class Item
    {
        #region Attributes
        /// <summary>
        /// Attributes - data that belongs to and describes an object of the class
        /// </summary>
        protected string Name { get; set; }
        protected string Description { get; set; }
        protected double Weight { get; set; }
        protected double Value { get; set; }
        #endregion

        #region Parameterized()
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name">used to set Name</param>
        /// <param name="desrciption">used to set the description</param>
        /// <param name="weight">used to set Weight</param>
        /// <param name="value">used to set Value</param>
        public Item(string name, string description, double weight, double value)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Value = value;
        }
        #endregion

        #region ToString()
        /// <summary>
        /// formats the output to the screen
        /// </summary>
        /// <returns>how the output should be displayed to the screen</returns>
        public override string ToString()
        {
            string info = "";

            info += $"Item name: \t{Name}";
            info += $"\nDescription: \t{Description}";
            info += $"\nWeight: \t{Weight} pounds";
            info += $"\nValue: \t\t{Value} gold pieces";

            return info;
        }
        #endregion
    }
}
