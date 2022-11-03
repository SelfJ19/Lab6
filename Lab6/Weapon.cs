////////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Project: Lab 6 Inheritance
// File Name: Weapon.cs
// Description: Represents the Weapon Object
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
    /// creates the weapon class which is a subclass of clue
    /// </summary>
    public class Weapon:Clue
    {
        #region Attributes
        /// <summary>
        /// Attributes - data that belongs to and describes an object of the class
        /// </summary>
        private int Damage { get; set; }
        private DamageType DamageType { get; set; }
        #endregion

        #region Parameterized()
        /// <summary>
        /// Parameterized Constructor that also uses the Clues parameterized constructor
        /// </summary>
        /// <param name="name">used to set Name from the parent class Clue</param>
        /// <param name="description">used to set the Description from the parent class Clue</param>
        /// <param name="weight">used to set the Weight from the parent class Clue</param>
        /// <param name="value">used to set the Value from the parent class Clue</param>
        public Weapon(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
            Damage = 0;
            DamageType = DamageType.Slashing;
        }
        #endregion
    }
}
