//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		1260-DubinJustin-Lab6
//	File Name:		Clue.cs
//	Description:	Allows for Clue object to be created and passed into Item
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
    /// Creates clue object using Item, and has parameterized constructor for clue
    /// </summary>
    public class Clue : Item
    {
        private String PersonIncriminated { get; set; }
        private bool Accuracy { get; set; }
        
        /// <summary>
        /// Default Constructor of Clue
        /// </summary>
        public Clue() : base()
        {
            PersonIncriminated = "";
            Accuracy = true;
        }
        
        /// <summary>
        /// Parameterized constructor of Clue; passed into item
        /// </summary>
        /// <param name="name">Name of Clue</param>
        /// <param name="description">Basic description of Clue  </param>
        /// <param name="weight">Weight of Clue as double</param>
        /// <param name="value">Value of Clue as double</param>
        public Clue(string name, string description, double weight, double value) : base(name, description, weight, value)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Value = value;
            PersonIncriminated = "";
            Accuracy = true;
        }

    }
}
