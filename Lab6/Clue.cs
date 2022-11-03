////////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Project: Lab 6 Inheritance
// File Name: Consumable.cs
// Description: Represents the Consumable Object
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Jason Self, selfj1@etsu.edu, East Tennessee State University
// Created: 11/02/2022
// Copyright: Jason Self, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    /// <summary>
    /// Creates the class Clue which is a subclass of Item
    /// </summary>
    public class Clue : Item
    {
        #region Attributes
        /// <summary>
        /// Attributes - data that belongs to and describes an object of the class
        /// </summary>
        private string PersonInciminated { get; set; }
        private bool Accuracy { get; set; }
        #endregion

        #region Parameterized()
        /// <summary>
        /// Parameterized Constructor that also uses the Item parameterized constructor
        /// </summary>
        /// <param name="name">used to set Name from the parent class Item</param>
        /// <param name="description">used to set Description from the parent class Item</param>
        /// <param name="weight">used to set Weight from the parent class Item</param>
        /// <param name="value">used to set Value from the parent class Item</param>
        public Clue(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
            PersonInciminated = "";
            Accuracy = false;
        }
        #endregion
    }
}
