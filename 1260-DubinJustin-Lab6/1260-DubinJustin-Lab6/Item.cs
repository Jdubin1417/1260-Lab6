//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		1260-DubinJustin-Lab6
//	File Name:		Item.cs
//	Description:	Allows for Items to be made and displayed; and allows Weapons, Consumables, and Clues to be passed as items into backpack.
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
    /// Creates new Item and allows item to have Clue, Weapon, or Consumable to be passed into it. Also formats string for user to read
    /// </summary>
    public class Item
    {
        protected String Name   { get; set; }
        protected String Description    { get; set; }
        protected Double Weight { get; set; }
        protected Double Value  { get; set; }
        
        /// <summary>
        /// Default constructor of item. Sets values to blank strings and 0 for doubles
        /// </summary>
        public Item()
        {
            Name = "";
            Description = "";
            Weight = 0;
            Value = 0; 
        }
        
        /// <summary>
        /// Parameterized Constructor for item. Clue, Weapon, and Consumables are passed into it as different kinds of items
        /// </summary>
        /// <param name="name">Name of the Item</param>
        /// <param name="description">Basic description of the item</param>
        /// <param name="weight">Weight of the Item as a double</param>
        /// <param name="value">Value of the item as a double</param>
        public Item(string name, string description, Double weight, Double value)
        {
            Name = name;
            Description = description;
            Weight = weight;
            Value = value;
        }

        /// <summary>
        /// Formats Items to be read by user
        /// </summary>
        /// <returns>Item in format to read name, description, weight, and value</returns>
        public override string ToString()
        {
            string ItemStr = " ";       //Defaults ItemStr to blank, ItemStr formats items for user to read

            ItemStr = "\nItem Name: " + Name +
                    "\nDescription: " + Description +
                    "\nWeight: " + Weight + " Pounds" +
                    "\nValue: " + Value + " Gold Pieces";
           
            return ItemStr;
        }


    }
}
