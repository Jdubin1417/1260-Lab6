//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		1260-DubinJustin-Lab6
//	File Name:		Weapon.cs
//	Description:	Allows for Weapon object to be created and passed into Clue
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
    /// Creates weapon object using clue, and has parameterized constructor for Weapon
    /// </summary>
    public class Weapon : Clue
    {
        private int Damage { get; set; }
        private DamageType DamageType { get; set; }
        
        /// <summary>
        /// Default constructor of Weapon
        /// </summary>
        public Weapon() : base()
        {
            Damage = 0;
            DamageType = DamageType.Slashing;   //Default type of damage is SLASH DAMAGE
        }

        /// <summary>
        /// Parameterized constructor of Weapon; passed into Clue
        /// </summary>
        /// <param name="name">Name of Weapon</param>
        /// <param name="description">Basic description of Weapon</param>
        /// <param name="weight">weight of Weapon as a double</param>
        /// <param name="value">Value of Weapon as a double</param>
        public Weapon(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Value = value; 
        }
    }
}
