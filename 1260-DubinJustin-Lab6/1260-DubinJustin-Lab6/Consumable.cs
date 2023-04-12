//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		1260-DubinJustin-Lab6
//	File Name:		Consumable.cs
//	Description:	Allows for Consumable object to be created and passed into Item
//	Course:			CSCI 1260-001 - Intro to Computer Sci II
//	Author:			Justin Dubin, dubinj@etsu.edu
//	Created:		Wednesday, November 02, 2022
//  Modified:       11/04/22 by Justin Dubin
//	Copyright:		Justin Dubin, 2022
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1260_DubinJustin_Lab6
{
    /// <summary>
    /// Creates consumable object using item, and has parameterized constructor for consumable
    /// </summary>
    public class Consumable : Item
    {
        private int HealthEffect { get; set; }
        private int DosesRemaining { get; set; }
        
        /// <summary>
        /// Default constructor of Consumable
        /// </summary>
        public Consumable() : base()
        {
            HealthEffect = 0;
            DosesRemaining = 0;
        }

        /// <summary>
        /// Parameterized constructor of Consumable; passed into item
        /// </summary>
        /// <param name="name">Name of Consumable</param>
        /// <param name="description">Description of Consumable</param>
        /// <param name="weight">Weight of Consumable as double</param>
        /// <param name="value">Value of Consumable as double</param>
        public Consumable(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Value = value;
        }
    }
}
