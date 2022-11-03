////////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Project: Lab 6 Inheritance
// File Name: Backpack.cs
// Description: Represents the Backpack Object
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Jason Self, selfj1@etsu.edu, East Tennessee State University
// Created: 11/02/2022
// Copyright: Jason Self, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    /// <summary>
    /// Creates the class Backpack
    /// </summary>
    public class Backpack
    {
        #region Attributes
        /// <summary>
        /// Attribute for creating The List of items named Contenrs
        /// </summary>
        private List<Item> Contents { get; set; }
        #endregion

        #region Backpack()
        /// <summary>
        /// Creates and Instantiates an empty List
        /// </summary>
        public Backpack()
        {
            Contents = new List<Item>();
        }
        #endregion

        #region Add()
        /// <summary>
        /// Creates the Add method using item
        /// </summary>
        /// <param name="item">item to be added to the List Contents</param>
        public void Add(Item item)
        {
            Contents.Add(item);
        }
        #endregion

        #region ListWeapons()
        /// <summary>
        /// Creates the ListWeapons method
        /// </summary>
        /// <returns>how weapons string info should be formatted</returns>
        public string ListWeapons()
        {
            string info = "\nWeapons ------------------------------------------";
            // Loop that looks at all items in the list Contents
            foreach (Item item in Contents)
            {
                // loop that checks if an item is a Weapon then that is what is added to the string to print
                if (item is Weapon)
                {
                    info += $"\n{item}";
                    info += "\n------------------------------------------------";
                }
            }
            return info;
        }
        #endregion

        #region ListClues
        /// <summary>
        /// Creates the ListClues method
        /// </summary>
        /// <returns>how clues string info should be formatted</returns>
        public string ListClues()
        {
            string info = "\nClues --------------------------------------------";
            // Loop that looks at all items in the list Contents
            foreach (Item item in Contents)
            {
                // loop that checks if an item is a Clue then that is what is added to the string to print
                if (item is Clue)
                {
                    info += $"\n{item}";
                    info += "\n------------------------------------------------";
                }
            }
            return info;
        }
        #endregion

        #region ListConsumables()
        /// <summary>
        /// Creates the ListConsumables method
        /// </summary>
        /// <returns>how consumables string info should be formatted</returns>
        public string ListConsumables()
        {
            string info = "\nConsumables --------------------------------------";
            // Loop that looks at all items in the list Contents
            foreach (Item item in Contents)
            {
                // loop that checks if an item is a Consumable then that is what is added to the string to print
                if (item is Consumable)
                {
                    info += $"\n{item}";
                    info += "\n------------------------------------------------";
                }
            }
            return info;
        }
        #endregion
    }
}
