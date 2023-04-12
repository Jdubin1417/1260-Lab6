//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		1260-DubinJustin-Lab6
//	File Name:		Backpack.cs
//	Description:	Backpack has list that holds Items, and has methods to add items and list them by type
//	Course:			CSCI 1260-001 - Intro to Computer Sci II
//	Author:			Justin Dubin, dubinj@etsu.edu
//	Created:		Wednesday, November 02, 2022
//  Modified:       11/04/22 by Justin Dubin
//	Copyright:		Justin Dubin, 2022
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1260_DubinJustin_Lab6
{
    /// <summary>
    /// Class creates backpack object to store Item objects inside, and has methods for adding and listing items
    /// </summary>
    public class Backpack
    {
        private List<Item> Contents;    //List that all items are passed into 

        /// <summary>
        /// Default constructor of Backpack object with Contents list inside
        /// </summary>
        public Backpack()
        {
            Contents = new List<Item>();    //New contents list for items
        }
        
        /// <summary>
        /// Method adds item passed into it into backpack
        /// </summary>
        /// <param name="item">Item is passed in to be added to list</param>
        public void Add(Item item)
        {
            Contents.Add(item);     //Adds whatever item is being passed in into the Contents list
        }

        /// <summary>
        /// Method lists all weapons inside of backpack
        /// </summary>
        /// <returns>All weapons with correct format</returns>
        public string ListWeapons()
        {
            String WeaponFormat = "Weapon-------------------------------------------------------------";
            String WeaponStr = " "; //Defaults WeaponStr to blank. All Weapons are listed for user with lines seperating them
            
            foreach (Item item in Contents)
            {
                if(item is Weapon)
                {
                    WeaponStr += item + "\n-------------------------------------------------------------------";
                }
            }

            return WeaponFormat + WeaponStr;
        }

        /// <summary>
        /// Method lists all clues inside of backpack
        /// </summary>
        /// <returns>All clues with correct format</returns>
        public string ListClues()
        {
            String ClueFormat = "\nClue---------------------------------------------------------------";
            String CluesStr = " ";  //Defaults ClueStr to blank. All Clues are listed for user with lines seperating them
            foreach (Item item in Contents)
            {
                if(item is Clue)
                {
                    CluesStr += item + "\n-------------------------------------------------------------------";
                }
            }
            return ClueFormat + CluesStr;
        }

        /// <summary>
        /// Method lists all consumables inside of backpack
        /// </summary>
        /// <returns>All consumables with correct format</returns>
        public string ListConsumables()
        {
            String ConsumablesFormat = "\nConsumables--------------------------------------------------------";
            String ConsumablesStr = " ";    //Defaults ConsumablesStr to blank. All Consumables are listed for user with lines seperating them
            foreach (Item item in Contents)
            {
                if(item is Consumable)
                {
                    ConsumablesStr += item + "\n-------------------------------------------------------------------";
                }
            }
            return ConsumablesFormat + ConsumablesStr;
        }
    }
}
