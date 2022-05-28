using System;
using System.Collections.Generic;
using System.Text;

/***************************************************************************************************
* CIS 123: Introduction to OOP     |                                                               *
* Murach's C#, 7th Edition         |    Exercise 12-1    Create and use a class                    *
* Chapter 12 Extra Exercises       |    Add a class to an Inventory Maintenance application and    *
* Team 2 Assignment, 28MAY2022     |    then add code to the two forms that use this class.        *
* Patrick McKee & Dominique Tepper |                                                               *
***************************************************************************************************/

/* *******************************************************************************************
* 2. Add a class named InvItem to the project and add:
* 
*       a. Properties
*           i. ItemNo           int
*          ii. Description      string
*         iii. Price            decimal
*
*       b. Method           GetDisplayText() 
*          Returns a string that contains itemNo, description, and price
*          Item number and description are separated by 4 spaces
*          
*       c. Constructor
*           ()
*               Creates an InvItem object with default values
*           (itemNo, description, price)
*               Creates an InvItem object with the specified values
*               
*  Patrick McKee & Dominique Tepper, 28MAY2022
* *******************************************************************************************/

namespace InventoryMaintenance
{
    public class InvItem
    {
        public InvItem() { }



        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public string GetDisplayText()
        {
            return ItemNo.ToString() + "    " + Description + "  " + Price.ToString("c");
        }
    }
}